using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacas
{
    public partial class VendaAnimal2 : Form
    {
        public VendaAnimal2()
        {
            InitializeComponent();
            Connect.getSGBDConnection();
        }

        public VendaAnimal2(String nifIn)
        {
            InitializeComponent();
            nif.Text = nifIn;
            Connect.getSGBDConnection();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venda compra = new Venda();
            compra.Nif = nif.Text;
            compra.Montante = montante.Text;
            compra.Data = data.Text;
            compra.Destino = destino.Text;
            compra.NrAnimal = nrAnimal.Text;
            addVenda(compra);
        }

        private void addVenda(Venda venda)
        {
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.ADD_VENDA @numeroAnimal, @vendedor, @montante, @data, @destino";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@numeroAnimal", venda.NrAnimal);
            cmd.Parameters.AddWithValue("@vendedor", venda.Nif);
            cmd.Parameters.AddWithValue("@montante", venda.Montante);
            cmd.Parameters.AddWithValue("@data", venda.Data);
            cmd.Parameters.AddWithValue("@destino", venda.Destino);
            cmd.Connection = Connect.cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 1)
                    MessageBox.Show("Update OK");
                else
                    MessageBox.Show("Update NOT OK");

                Connect.cn.Close();
            }
        }
    }
}
