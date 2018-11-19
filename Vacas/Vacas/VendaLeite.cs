using System;
using System.Collections;
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
    public partial class VendaLeite : Form
    {
        private bool addSucess;
        public VendaLeite()
        {
            InitializeComponent();
            initialize();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }


        
        private void initialize()
        {
            Connect.verifySGBDConnection();
            SqlCommand cmd = new SqlCommand("EXEC VACAS.VER_PRODUCAO_LEITE", Connect.cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                producaoLeite prod = new producaoLeite();
                prod.Produtor = reader["PRODUTOR"].ToString();
                prod.ProducaoManha = reader["PRODUCAO_MANHA"].ToString();
                prod.ProducaoTarde = reader["PRODUCAO_TARDE"].ToString();
                prod.Data = reader["DATA_PRODUCAO"].ToString();
                prod.Preco = reader["PRECO"].ToString();
                prod.Fabrica = reader["NOME"].ToString();
                fabrica.Text = prod.Fabrica;
                precoLeite.Text = prod.Preco;
                listBox1.Items.Add(prod);
            }
            reader.Close();
            Connect.verifySGBDConnection();
            cmd = new SqlCommand("SELECT VACAS.RENDIMENTO_LEITE()", Connect.cn);
            rendimentoLeite.Text =  cmd.ExecuteScalar().ToString();
            Connect.cn.Close();
            
        }

        private void addProducaoLeite(producaoLeite prod)
        {
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.ADD_PRODUCAO_LEITE @numeroProdutor, @producaoManha, @producaoTarde, @data";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@producaoManha", prod.ProducaoManha);
            cmd.Parameters.AddWithValue("@producaoTarde", prod.ProducaoTarde);
            cmd.Parameters.AddWithValue("@data", prod.Data);
            cmd.Parameters.AddWithValue("@numeroProdutor", 1);
            cmd.Connection = Connect.cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("404 NOT FOUND");
                addSucess = false;
                throw new Exception("Failed to update database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 1)
                {
                    MessageBox.Show("Add OK");
                    addSucess = true;
                }

                else
                {
                    MessageBox.Show("Add NOT OK");
                    addSucess = false;
                }


                Connect.cn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            producaoLeite prod = new producaoLeite();
            prod.ProducaoManha = manha.Text;
            prod.ProducaoTarde = tarde.Text;
            prod.Data = data.Text;

            addProducaoLeite(prod);
            if (addSucess)
            {
                listBox1.Items.Add(prod);
                initialize();
            }
                
        }

     
    }
}
