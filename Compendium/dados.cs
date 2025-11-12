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
    public partial class dados : Form
    {
        public dados()
        {
            InitializeComponent();
        }

        int d4 = 0;
        int d6 = 0;
        int d8 = 0;
        int d10 = 0;
        int d12 = 0;
        int d20 = 0;
        string rolls = string.Empty;
        int total = 0;
        int notificacao = 0;

        private void bttn_d4_Click(object sender, EventArgs e)
        {
            d4++;
            vezes_d4.Value = d4;
        }

        private void vezes_d4_ValueChanged(object sender, EventArgs e)
        {
            d4 = (int)vezes_d4.Value;
        }

        private void bttn_d6_Click(object sender, EventArgs e)
        {
            d6++;
            vezes_d6.Value = d6;
        }

        private void vezes_d6_ValueChanged(object sender, EventArgs e)
        {
            d6 = (int)vezes_d6.Value;
        }

        private void bttn_d8_Click(object sender, EventArgs e)
        {
            d8++;
            vezes_d8.Value = d8;
        }

        private void vezes_d8_ValueChanged(object sender, EventArgs e)
        {
            d8 = (int)vezes_d8.Value;
        }

        private void bttn_d10_Click(object sender, EventArgs e)
        {
            d10++;
            vezes_d10.Value = d10;
        }

        private void vezes_d10_ValueChanged(object sender, EventArgs e)
        {
            d10 = (int)vezes_d10.Value;
        }

        private void bttn_d12_Click(object sender, EventArgs e)
        {
            d12++;
            vezes_d12.Value = d12;
        }

        private void vezes_d12_ValueChanged(object sender, EventArgs e)
        {
            d12 = (int)vezes_d12.Value;
        }

        private void bttn_d20_Click(object sender, EventArgs e)
        {
            d20++;
            vezes_d20.Value = d20;
        }

        private void vezes_d20_ValueChanged(object sender, EventArgs e)
        {
            d20 = (int)vezes_d20.Value;
        }

        private void bttn_roll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (d4 != 0)
            {
                for (int i = 0;i < d4;i++)
                {
                    notificacao = total;
                    total += rnd.Next(1, 5);
                    notificacao = total - notificacao;
                    rolls += "1d4:" + notificacao +"\n";
                }
            }

            if (d6 != 0)
            {
                for (int i = 0; i < d6;i++)
                {
                    notificacao = total;
                    total += rnd.Next(1, 7);                    
                    notificacao = total - notificacao;
                    rolls += "1d6:" + notificacao + "\n";
                }
            }

            if (d8 != 0)
            {
                for (int i = 0; i < d8; i++)
                {
                    notificacao = total;
                    total += rnd.Next(1, 9);
                    notificacao = total - notificacao;
                    rolls += "1d8:" + notificacao + "\n";
                }
            }

            if (d10 != 0)
            {
                for (int i = 0; i < d10; i++)
                {
                    notificacao = total;
                    total += rnd.Next(1, 11);
                    notificacao = total - notificacao;
                    rolls += "1d10:" + notificacao + "\n";
                }
            }

            if (d12 != 0)
            {
                for (int i = 0; i < d12; i++)
                {
                    notificacao = total;
                    total += rnd.Next(1, 13);
                    notificacao = total - notificacao;
                    rolls += "1d12:" + notificacao + "\n";
                }
            }

            if (d20 != 0)
            {
                for (int i = 0; i < d20; i++)
                {
                    total += rnd.Next(1, 21);
                    rolls += "1d20:" + notificacao + "\n";
                }
            }

            rolls += "Bônus:" + valor_bonus.Value+"\n";
            rolls += "Total(sem bônus):" + total + "\n";
            total += (int)valor_bonus.Value;
            rolls += "Total(com bônus):" + total + "\n";

            txt_historico.Text = rolls;
            total = 0;
        }

        private void bttn_limpar_Click(object sender, EventArgs e)
        {
            txt_historico.Text = String.Empty;
            total = 0;
        }
    }
}
