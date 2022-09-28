using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despertador
{
    public partial class Form1 : Form
    {
        Despertador desp = new Despertador();
        Horas hor = new Horas();
        public Form1()
        {
            InitializeComponent();
        }

        private void criarDes_Click(object sender, EventArgs e)
        {
           
            desp.Hora = Convert.ToInt32(txth.Text);
            desp.Segundo = Convert.ToInt32(txtm.Text);
            desp.Minuto = Convert.ToInt32(txts.Text);

            MessageBox.Show("Despertador Criado!");
        }

        private void criarH_Click(object sender, EventArgs e)
        {
           
            hor.Hora = Convert.ToInt32(txth1.Text);
            hor.Segundo = Convert.ToInt32(txtm1.Text);
            hor.Minuto = Convert.ToInt32(txts1.Text);

            MessageBox.Show("Hora Criada!");
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            if ((desp.Hora == hor.Hora) && (desp.Minuto == hor.Minuto) && (desp.Segundo == hor.Segundo))
            {
                txtd.Text = "Despertador tocando!";
            }
            else
            {
                txtd.Text = "Despertador diverge do horário!";
            }
            
                
            
            
        }
    }
}
