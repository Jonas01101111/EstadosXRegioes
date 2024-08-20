using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosXRegioes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RemoverGeral_Click(object sender, EventArgs e)
        {
            string texto = cbxGeral.SelectedItem.ToString();


            //norte
            //nordeste
            //sudeste
            if (texto == "São Paulo" || texto == "Rio de Janeiro" || texto == "Minas Gerais" || texto == "Rio de Janeiro")
            {

            }
            //centro-oeste
            //sudeste
            //sul

            
        }

        private void RemoverNorte_Click(object sender, EventArgs e)
        {

        }

        private void RemoverNordeste_Click(object sender, EventArgs e)
        {

        }

        private void RemoverCentroOeste_Click(object sender, EventArgs e)
        {

        }

        private void RemoverSudeste_Click(object sender, EventArgs e)
        {

        }

        private void RemoverSul_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TotalGeral.Text = cbxGeral.Items.Count.ToString();
        }
    }
}
