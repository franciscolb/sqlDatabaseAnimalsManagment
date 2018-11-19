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
    public partial class HistoricoCompras : Form
    {
        //private SqlConnection cn;
        private int currentCompra;

        public HistoricoCompras()
        {
            InitializeComponent();
           // this.cn = Connect.getSGBDConnection();
            initialize();
            lockFields();
            
        }

        private void initialize()
        {
            Connect.verifySGBDConnection();
            SqlCommand cmd = new SqlCommand("EXEC VACAS.VER_COMPRAS", Connect.cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Compra c = new Compra();
                c.Nr_compra = reader["NR_COMPRA"].ToString();
                c.Nif = reader["VENDEDOR"].ToString();
                c.NrAnimal = reader["NR_ANIMAL"].ToString();
                c.Montante = reader["MONTANTE"].ToString();
                c.Data = reader["DATA"].ToString();
                c.Destino = reader["DESTINO"].ToString();
                listBox1.Items.Add(c);
            }
            currentCompra = 0;
            listBox1.SelectedIndex = currentCompra;
            showCompra();
            Connect.cn.Close();
            okButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void showCompra()
        {
            Compra compra = new Compra();
            compra = (Compra)listBox1.Items[currentCompra];

            
            nif.Text = compra.Nif;
            montante.Text = compra.Montante;
            data.Text = compra.Data;
            destino.Text = compra.Destino;
            nrAnimal.Text = compra.NrAnimal;
        }

       
        private void Menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                currentCompra = listBox1.SelectedIndex;
                showCompra();
            }
        }

        private void unlockFields()
        {
            nrAnimal.ReadOnly = false;
            nif.ReadOnly = false;
            montante.ReadOnly = false;
            data.ReadOnly = false;
            destino.ReadOnly = false;
        }

        private void lockFields()
        {
            nrAnimal.ReadOnly = true;
            nif.ReadOnly = true;
            montante.ReadOnly = true;
            data.ReadOnly = true;
            destino.ReadOnly = true;
        }

        private void hideButtons()
        {
            okButton.Visible = false;
            cancelButton.Visible = false;
            editButton.Visible = true;
            removeButton.Visible = true;
        }
        private void showButtons()
        {
            okButton.Visible = true;
            cancelButton.Visible = true;
            editButton.Visible = false;
            removeButton.Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            unlockFields();
            showButtons();
            Compra compra = (Compra)listBox1.Items[currentCompra];
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            Compra compra1 = new Compra();
            compra1 = (Compra)listBox1.Items[currentCompra];
            compra.Nif = nif.Text;
            compra.NrAnimal = nrAnimal.Text;
            compra.Montante = montante.Text;
            compra.Destino = destino.Text;
            compra.Data = data.Text;
            compra.Nr_compra = compra1.Nr_compra;
            edit_compra(compra);
            listBox1.Items[currentCompra] = compra;


            hideButtons();
            lockFields();
            listBox1.Enabled = true;


        }

        private void edit_compra(Compra compra)
        {
            
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "EXEC VACAS.EDITAR_COMPRA @nr_compra, @nr_animal, @vendedor, @montante , @data , @destino  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nr_compra", Convert.ToInt16(compra.Nr_compra));
            cmd.Parameters.AddWithValue("@nr_animal", Convert.ToInt16(compra.NrAnimal));
            cmd.Parameters.AddWithValue("@vendedor", Convert.ToInt32(compra.Nif));
            cmd.Parameters.AddWithValue("@montante", Convert.ToDecimal(compra.Montante));
            cmd.Parameters.AddWithValue("@data", Convert.ToDateTime(compra.Data));
            cmd.Parameters.AddWithValue("@destino", compra.Destino);
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            hideButtons();
            lockFields();
            listBox1.Enabled = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    removeCompra(((Compra)listBox1.SelectedItem).Nr_compra);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (currentCompra == listBox1.Items.Count)
                    currentCompra = listBox1.Items.Count - 1;
                if (currentCompra == -1)
                {
                    //ClearFields();
                    MessageBox.Show("There are no more vacinas");
                }
                else
                {
                    showCompra();
                }
                listBox1.SelectedIndex = currentCompra - 1;
            }
        }

        private void removeCompra(string nr_compra)
        {
            
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "EXEC VACAS.REMOVER_COMPRA @nr_compra ";
            cmd.Parameters.Clear();
            
            cmd.Parameters.AddWithValue("@nr_compra",nr_compra );
            cmd.Connection = Connect.cn;
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete vaca in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                Connect.cn.Close();
            }

        }

       
    }
}
