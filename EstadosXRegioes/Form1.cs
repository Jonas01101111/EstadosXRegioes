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
            if (texto == "Amazonas" || texto == "Acre" || texto == "Rondônia" || texto == "Amapá" || texto == "Pará" || texto == "Tocantins" || texto == "Roraima")
            {
                cbxNorte.Items.Add(cbxGeral.SelectedItem);
                cbxGeral.Items.Remove(cbxGeral.SelectedItem);
                TotalGeral.Text = cbxGeral.Items.Count.ToString();
                TotalNorte.Text = cbxGeral.Items.Count.ToString();
            }
            
            //nordeste
            if (texto == "Maranhão" || texto == "Piauí" || texto == "Bahia" || texto == "Pernambuco" || texto == "Ceará" || texto == "Rio Grande do Norte" || texto == "Alagoas" || texto == "Sergipe" || texto == "Paraíba")
            {
                cbxNordeste.Items.Add(cbxGeral.SelectedItem);
                cbxGeral.Items.Remove(cbxGeral.SelectedItem);
                TotalGeral.Text = cbxGeral.Items.Count.ToString();
                TotalNordeste.Text = cbxGeral.Items.Count.ToString();
            }
           
            //sudeste
            if (texto == "São Paulo" || texto == "Rio de Janeiro" || texto == "Minas Gerais" || texto == "Espirito Santo")
            {
                cbxSudeste.Items.Add(cbxGeral.SelectedItem);
                cbxGeral.Items.Remove(cbxGeral.SelectedItem);
                TotalGeral.Text = cbxGeral.Items.Count.ToString();
                TotalSudeste.Text = cbxGeral.Items.Count.ToString();
            }
            
            //centro-oeste
            if (texto == "Mato Grosso" || texto == "Mato Grosso do Sul" || texto == "Goiás" || texto == "Distrito Federal")
            {
                cbxCentroOeste.Items.Add(cbxGeral.SelectedItem);
                cbxGeral.Items.Remove(cbxGeral.SelectedItem);
                TotalGeral.Text = cbxGeral.Items.Count.ToString();
                TotalCentroOeste.Text = cbxGeral.Items.Count.ToString();
            }
            
            //sul
            if (texto == "Paraná" || texto == "Santa Catarina" || texto == "Rio Grande do Sul")
            {
                cbxSul.Items.Add(cbxGeral.SelectedItem);
                cbxGeral.Items.Remove(cbxGeral.SelectedItem);
                TotalGeral.Text = cbxGeral.Items.Count.ToString();
                TotalSul.Text = cbxGeral.Items.Count.ToString();
            }


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
