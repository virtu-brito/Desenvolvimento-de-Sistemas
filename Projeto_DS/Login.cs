using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_ProjetoDS;
using BLL_ProjetoDS;


namespace UI_ProjetoDS //UI- User Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDTO obj = new LoginDTO();
                PessoaDTO pessoa = new PessoaDTO();

                obj.prpUsuario = txtNome.Text;
                obj.prpSenha = txtSenha.Text;

                pessoa = LoginBLL.vldLogin(obj);

                

               /* if (mensagem == "true")
                {
                    MessageBox.Show("Login feito com sucesso");
                }
                else
                {
                    MessageBox.Show("Usuário ou senha invalida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
