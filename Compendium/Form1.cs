using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compendium
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFeiticos_Click(object sender, EventArgs e)
        {

            catalogofeiticos catalogofeiticos = new catalogofeiticos();
            catalogofeiticos.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMonstros_Click(object sender, EventArgs e)
        {
            catalogomonstros catalogomonstros = new catalogomonstros();
            catalogomonstros.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            catalogopersonagens catalogopersonagens = new catalogopersonagens();
            catalogopersonagens.Show();
        }
    }
}
