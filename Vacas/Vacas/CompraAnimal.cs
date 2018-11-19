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
    public partial class CompraAnimal : Form
    {
        private int currentPerson;
        private bool add;
        public CompraAnimal()
        {
            InitializeComponent();
            Connect.getSGBDConnection();
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
            Connect.cn.Open();
            SqlCommand cmd = new SqlCommand("EXEC VACAS.VER_VENDEDOR", Connect.cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nif = (int) reader["NIF"];
                pessoa.Name = reader["NOME"].ToString();
                pessoa.Sexo = Convert.ToChar(reader["SEXO"]);
                pessoa.Localidade = reader["LOCALIDADE"].ToString();
                pessoa.Data_nasc = reader["DATA_NASCIMENTO"].ToString();
                pessoa.Tel = (int) reader["TELEFONE"];
                pessoa.Email = reader["EMAIL"].ToString();
                listBox1.Items.Add(pessoa);
                add = false;
            }
            Connect.cn.Close();
            currentPerson = 0;
            listBox1.SelectedIndex = currentPerson;
            showPerson();
            okButton.Visible = false;
            cancel.Visible = false;
            lockFields();
        }

        private void showPerson()
        {
            Pessoa pessoa = new Pessoa();
            pessoa = (Pessoa)listBox1.Items[currentPerson];
            nome.Text = pessoa.Name;
            nif.Text = (pessoa.Nif).ToString();
            if (pessoa.Sexo == 'M')
                sexo.SelectedIndex = 0;
            else
                sexo.SelectedIndex = 1;
            localidade.Text = pessoa.Localidade;
            dataNascimento.Text = pessoa.Data_nasc;
            telefone.Text = (pessoa.Tel).ToString();
            email.Text = pessoa.Email;
        }

        private void pag2_Click(object sender, EventArgs e)
        {
            CompraAnimal2 compraAnimal2 = new CompraAnimal2(nif.Text);
            compraAnimal2.Show();
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                currentPerson = listBox1.SelectedIndex;
                showPerson();
            }
        }

        private void showButtons()
        {
            cancel.Visible = true;
            okButton.Visible = true;
            adicionar.Visible = false;
            editar.Visible = false;
            remover.Visible = false;
        }
        private void hideButtons()
        {
            cancel.Visible = false;
            okButton.Visible = false;
            adicionar.Visible = true;
            editar.Visible = true;
            remover.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showButtons();
            unlockFields();
            add = false;
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            nome.Text = String.Empty;
            nif.Text = String.Empty;
            localidade.Text = String.Empty;
            dataNascimento.Text = String.Empty;
            telefone.Text = String.Empty;
            email.Text = String.Empty;
            showButtons();
            unlockFields();
            add = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            hideButtons();
            lockFields();
            Pessoa p = new Pessoa();
            p.Nif = Convert.ToInt32(nif.Text);
            p.Name = nome.Text;
            p.Localidade = localidade.Text;
            if (sexo.SelectedIndex == 0)
                p.Sexo = 'M';
            else
                p.Sexo = 'F';
            p.Tel = Convert.ToInt32(telefone.Text);
            p.Email = email.Text;
            p.Data_nasc = dataNascimento.Text;

            if (add)
            {
                addVendedor(p);
                listBox1.Items.Add(p);
            }
                

            else
                editVendedor();
        }

        private void editVendedor()
        {
            throw new NotImplementedException();
        }

        private void addVendedor(Pessoa pessoa)
        {
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.ADD_VENDEDOR @nif, @nome, @sexo, @localidade, @data, @telefone, @email ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nif", pessoa.Nif);
            cmd.Parameters.AddWithValue("@nome", pessoa.Name);
            cmd.Parameters.AddWithValue("@sexo", pessoa.Sexo);
            cmd.Parameters.AddWithValue("@localidade", pessoa.Localidade);
            cmd.Parameters.AddWithValue("@data", pessoa.Data_nasc);
            cmd.Parameters.AddWithValue("@telefone", pessoa.Tel);
            cmd.Parameters.AddWithValue("@email", pessoa.Email);
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
                if (rows == 2)
                {
                    MessageBox.Show("Add OK");
                }

                else
                {
                    MessageBox.Show("Add NOT OK");
                }


                Connect.cn.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            hideButtons();
            lockFields();
        }

        private void unlockFields()
        {
            nome.ReadOnly = false;
            nif.ReadOnly = false;
            sexo.Enabled = true;
            localidade.ReadOnly = false;
            dataNascimento.ReadOnly = false;
            telefone.ReadOnly = false;
            email.ReadOnly = false;
        }
        private void lockFields()
        {
            nome.ReadOnly = true;
            nif.ReadOnly = true;
            sexo.Enabled = false;
            localidade.ReadOnly = true;
            dataNascimento.ReadOnly = true;
            telefone.ReadOnly = true;
            email.ReadOnly = true;

        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    removerVendedor(((Pessoa)listBox1.SelectedItem).Nif);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (currentPerson == listBox1.Items.Count)
                    currentPerson = listBox1.Items.Count - 1;
                if (currentPerson == -1)
                {
                    //ClearFields();
                    MessageBox.Show("There are no more vendedores");
                }
                else
                {
                    showPerson();
                }
            }
        }

        private void removerVendedor(int nif)
        {
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.REMOVER_VENDEDOR @nif";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nif", nif);
            cmd.Connection = Connect.cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete pessoa in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                Connect.cn.Close();
            }
        }
    }


}
