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
    public partial class VendaAnimal : Form
    {

        private int currentPerson;
        private bool add;
        private bool addSucess;

        public VendaAnimal()
        {
            InitializeComponent();
            lockFields();
            okButton.Visible = false;
            cancelButton.Visible = false;
            initialize();
            Connect.getSGBDConnection();
        }

        

        private void initialize()
        {
            Connect.verifySGBDConnection();
            SqlCommand cmd = new SqlCommand("EXEC VACAS.VER_COMPRADOR", Connect.cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("reading...");
                Pessoa pessoa = new Pessoa();
                pessoa.Nif = (int)reader["NIF"];
                pessoa.Name = reader["NOME"].ToString();
                pessoa.Sexo = Convert.ToChar(reader["SEXO"]);
                pessoa.Localidade = reader["LOCALIDADE"].ToString();
                pessoa.Data_nasc = reader["DATA_NASCIMENTO"].ToString();
                pessoa.Tel = (int)reader["TELEFONE"];
                pessoa.Email = reader["EMAIL"].ToString();
                listBox1.Items.Add(pessoa);
            }
            Connect.cn.Close();
            currentPerson = 0;
            listBox1.SelectedIndex = currentPerson;
            showPerson();
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
            data.Text = pessoa.Data_nasc;
            telefone.Text = (pessoa.Tel).ToString();
            email.Text = pessoa.Email;
        }
    
        
        private void Menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }

        private void Avançar_Click(object sender, EventArgs e)
        {
            VendaAnimal2 vendaAnimal2 = new VendaAnimal2(nif.Text);
            vendaAnimal2.Show();
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

        private void adicionar_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            
            nome.Text = String.Empty;
            nif.Text = String.Empty;
            localidade.Text = String.Empty;
            email.Text = String.Empty;
            sexo.Text = String.Empty;
            telefone.Text = String.Empty;
            data.Text = String.Empty;
            showButtons();
            unlockFields();
            add = true;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            unlockFields();
            showButtons();
            Pessoa person = (Pessoa)listBox1.Items[currentPerson];
            add = false;
        }

        private void remover_Click(object sender, EventArgs e)
        {
            
             if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    removePessoa(((Pessoa)listBox1.SelectedItem).Nif);
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
                    MessageBox.Show("There are no more vacas");
                }
                else
                {
                    showPerson();
                }
            }
             
        }

        private void removePessoa(int nif)
        {
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.REMOVER_COMPRADOR @nif ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nif", nif);
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

        private void unlockFields()
        {
            nome.ReadOnly = false;
            nif.ReadOnly = false;
            sexo.Enabled = true;
            localidade.ReadOnly = false;
            data.ReadOnly = false;
            telefone.ReadOnly = false;
            email.ReadOnly = false;

        }

        private void lockFields()
        {
            nome.ReadOnly = true;
            nif.ReadOnly = true;
            sexo.Enabled = false;
            localidade.ReadOnly = true;
            data.ReadOnly = true;
            telefone.ReadOnly = true;
            email.ReadOnly = true;
        }

        private void hideButtons()
        {
            okButton.Visible = false;
            cancelButton.Visible = false;
            adicionar.Visible = true;
            editar.Visible = true;
            remover.Visible = true;
        }
        private void showButtons()
        {
            okButton.Visible = true;
            cancelButton.Visible = true;
            adicionar.Visible = false;
            editar.Visible = false;
            remover.Visible = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Name = nome.Text;
            pessoa.Nif = Convert.ToInt32(nif.Text);
            pessoa.Localidade = localidade.Text;
            pessoa.Sexo = Convert.ToChar(sexo.Text);
            pessoa.Data_nasc = data.Text;
            pessoa.Tel = Convert.ToInt32(telefone.Text);
            pessoa.Email = email.Text;

            addPessoa(pessoa);

            listBox1.Items.Add(pessoa);
                   

            hideButtons();
            lockFields();
            listBox1.Enabled = true;

        }

        private void addPessoa(Pessoa pessoa)
        {
            
             int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "EXEC VACAS.ADD_COMPRADOR  @nif, @nome,@sexo, @localidade, @data,@telefone, @email";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", pessoa.Name);
            cmd.Parameters.AddWithValue("@nif",Convert.ToInt32(pessoa.Nif));
            cmd.Parameters.AddWithValue("@localidade", pessoa.Localidade);
            cmd.Parameters.AddWithValue("@data", Convert.ToDateTime(pessoa.Data_nasc));
            cmd.Parameters.AddWithValue("@email", pessoa.Email);
            cmd.Parameters.AddWithValue("@telefone", Convert.ToInt32(pessoa.Tel));
            cmd.Parameters.AddWithValue("@sexo", Convert.ToChar(pessoa.Sexo));
            cmd.Connection = Connect.cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                addSucess = false;
                throw new Exception("Failed to update database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 2)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            hideButtons();
            lockFields();
            listBox1.Enabled = true;
        }
    }
}
