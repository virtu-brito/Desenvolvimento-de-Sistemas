using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using System.Data;
using System.Data.SqlClient;



namespace DAL_ProjetoDS
{
    public class Login_DAL
    {
        public static string vldLogin(loginDTO obj)
        {
            try
                //inicia o bloco de tratamento de exception
            {
                string script = "SELECT * FROM Credencial WHERE (userName = @login OR email = @login)" + "AND senha = @senha;";
                //cria uma string com consuta sql

                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                //cria o comando para rodar a instrução, passando instrução sql e coxeção

                cm.Parameters.AddWithValue("@login", obj.prpUsuario);
                cm.Parameters.AddWithValue("@senha", obj.prpSenha);
                //substitui as variaveis na instrução sql pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                //roda a instrução sql e atribui resultado no sqlDataReader

                while (dados.Read())
                //le a proxima linha do resultado da instrução
                {
                    if (dados.HasRows)
                        //verifica se existe a linha com as credenciais
                    {
                        return "true";
                    }
                }
                return "Erro na Conexão, contate o administrador do sistema!";
            }
            catch (Exception)
            //esse bloco e executado caso aconteça exceção no bloco try
            {
                throw;
            }

            finally
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
