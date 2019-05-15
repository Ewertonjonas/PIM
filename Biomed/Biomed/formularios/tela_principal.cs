using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biomed.formularios;


namespace Biomed.formularios
{
    public partial class tela_principal : Form
    {
        public tela_principal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tela_principal_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            agenda ag1 = new agenda();
            ag1.ShowDialog(); 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
