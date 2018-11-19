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
    public partial class HistoricoVendas : Form
    {
        private int currentVenda;

        public HistoricoVendas()
        {
            InitializeComponent();
            initialize();
            lockFields();

        }

        private void initialize()
        {
            Connect.verifySGBDConnection();
            SqlCommand cmd = new SqlCommand("EXEC VACAS.VER_VENDAS", Connect.cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Venda c = new Venda();
                c.Nr_venda = reader["NR_VENDA"].ToString();
                c.Nif = reader["COMPRADOR"].ToString();
                c.NrAnimal = reader["NR_ANIMAL"].ToString();
                c.Montante = reader["MONTANTE"].ToString();
                c.Data = reader["DATA"].ToString();
                c.Destino = reader["DESTINO"].ToString();
                listBox1.Items.Add(c);
            }
            currentVenda = 0;
            listBox1.SelectedIndex = currentVenda;
            showVenda();
            Connect.cn.Close();
            okButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void showVenda()
        {
            Venda venda = new Venda();
            venda = (Venda)listBox1.Items[currentVenda];


            nif.Text = venda.Nif;
            montante.Text = venda.Montante;
            data.Text = venda.Data;
            destino.Text = venda.Destino;
            nr_animal.Text = venda.NrAnimal;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                currentVenda = listBox1.SelectedIndex;
                showVenda();
            }
        }

        private void lockFields()
        {
            nr_animal.ReadOnly = true;
            nif.ReadOnly = true;
            montante.ReadOnly = true;
            data.ReadOnly = true;
            destino.ReadOnly = true;
        }

        private void unlockFields()
        {
            nr_animal.ReadOnly = false;
            nif.ReadOnly = false;
            montante.ReadOnly = false;
            data.ReadOnly = false;
            destino.ReadOnly = false;
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
            Venda venda = (Venda)listBox1.Items[currentVenda];

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            Venda venda1 = (Venda)listBox1.Items[currentVenda];
            venda.Nif = nif.Text;
            venda.NrAnimal = nr_animal.Text;
            venda.Montante = montante.Text;
            venda.Destino = destino.Text;
            venda.Data = data.Text;
            venda.Nr_venda = venda1.Nr_venda;

            edit_venda(venda);
            listBox1.Items[currentVenda] = venda;


            hideButtons();
            lockFields();
            listBox1.Enabled = true;


        }

        private void edit_venda(Venda venda)
        {
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.EDITAR_VENDA @nr_venda, @nr_animal, @vendedor, @montante , @data , @destino  ";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@nr_venda", Convert.ToInt16(venda.Nr_venda));
            cmd.Parameters.AddWithValue("@nr_animal", Convert.ToInt16(venda.NrAnimal));
            cmd.Parameters.AddWithValue("@vendedor", Convert.ToInt64(venda.Nif));
            cmd.Parameters.AddWithValue("@montante", Convert.ToDecimal(venda.Montante));
            cmd.Parameters.AddWithValue("@data", Convert.ToDateTime(venda.Data));
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
                    removeVenda(((Venda)listBox1.SelectedItem).Nr_venda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (currentVenda == listBox1.Items.Count)
                    currentVenda = listBox1.Items.Count - 1;
                if (currentVenda == -1)
                {
                    //ClearFields();
                    MessageBox.Show("There are no more vacinas");
                }
                else
                {
                    showVenda();
                }
                listBox1.SelectedIndex = currentVenda - 1;
            }
        }

        private void removeVenda(string nr_venda)
        {
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.REMOVER_VENDA @nr_venda ";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@nr_venda", nr_venda);
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
