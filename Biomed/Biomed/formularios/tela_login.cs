using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biomed
{
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
        }

        public void btnAcessar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario == "admin" && senha == "admin")

            {
                tela_login novo = new tela_login();
                novo.Show();
                this.Visible = false;

            }


             
        }
    }
}
