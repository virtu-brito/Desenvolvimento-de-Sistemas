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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            loginDTO obj = new loginDTO();

            obj.prpUsuario = txtNome.Text;
            obj.prpSenha = txtSenha.Text;

            string mensagem = LoginBLL.vldLogin(obj);

            if( mensagem == "true")
            {
                this.Hide();
                Projeto_DS.Home tela2 = new Projeto_DS.Home();
                tela2.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!", "ERRO", MessageBoxButtons.OK);
            }
           
        }
    }
}
