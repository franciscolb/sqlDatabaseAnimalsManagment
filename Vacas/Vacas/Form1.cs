using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vacas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Animais_Click(object sender, EventArgs e)
        {
            Animais animais = new Animais();
            animais.Show();
            Hide();
        }

        private void VendaAnimal_Click(object sender, EventArgs e)
        {
            VendaAnimal vendaAnimal = new VendaAnimal();
            vendaAnimal.Show();
            Hide();
        }

        private void VendaLeite_Click(object sender, EventArgs e)
        {
            VendaLeite vendaLeite = new VendaLeite();
            vendaLeite.Show();
            Hide();
        }

        private void CompraAnimal_Click(object sender, EventArgs e)
        {
            CompraAnimal compraAnimal = new CompraAnimal();
            compraAnimal.Show();
            Hide();
        }

        private void Vacinação_Click(object sender, EventArgs e)
        {
           Vacinacao vacinacao = new Vacinacao();
           vacinacao.Show();
            Hide();
        }

        private void HistoricoCompras_Click(object sender, EventArgs e)
        {
            HistoricoCompras compras = new HistoricoCompras();
            compras.Show();
            Hide();
        }

        private void HistoricoVendas_Click(object sender, EventArgs e)
        {
            HistoricoVendas vendas = new HistoricoVendas();
            vendas.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
