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
    public partial class Vacinacao : Form
    {
       // private SqlConnection cn;
        private int currentVacinacao;
        private bool add;
        private bool addSucess;

        public Vacinacao()
        {

            InitializeComponent();
            buttonok.Visible = false;
            buttoncancelar.Visible = false;
           // this.cn = Connect.getSGBDConnection();
            initialize();

        }

        private void initialize()
        {
            Connect.verifySGBDConnection();
            SqlCommand cmd = new SqlCommand("EXEC VACAS.VER_VACINACAO", Connect.cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RegistoVacinacao R = new RegistoVacinacao();
                //A.produtor = reader["PRODUTOR"].ToString();
                R.NrVacina = reader["NR_VACINA"].ToString();
                R.NrAnimal = reader["NR_ANIMAL"].ToString();
                R.NrVeterinario = reader["NR_VETERINARIO"].ToString();
                R.Nome = reader["NOME"].ToString();
                R.Data = reader["DATA"].ToString();
                R.Local = reader["LOCAL"].ToString();
                listBox1.Items.Add(R);

            }
            currentVacinacao = 0;
            listBox1.SelectedIndex = currentVacinacao;
            showVacinacao();
            lockFields();
            Connect.cn.Close();
        }

        private void showVacinacao()
        {
            RegistoVacinacao vacinacao = new RegistoVacinacao();
            vacinacao = (RegistoVacinacao)listBox1.Items[currentVacinacao];
            
            nr_animal.Text = vacinacao.NrAnimal;
            nr_veterinario.Text = vacinacao.NrVeterinario;
            nome_vacina.Text = vacinacao.Nome;
            data.Text = vacinacao.Data;
            local.Text = vacinacao.Local;
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
                currentVacinacao = listBox1.SelectedIndex;
                showVacinacao();
            }
        }

        private void add_vacinacao(RegistoVacinacao registo)
        {

            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.ADD_VACINACAO  @nr_animal, @nr_veterinario, @nome, @data,@local";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@nr_veterinario", Convert.ToInt16(registo.NrVeterinario));
            cmd.Parameters.AddWithValue("@nr_animal", Convert.ToInt16(registo.NrAnimal));
            cmd.Parameters.AddWithValue("@nome", registo.Nome);
            cmd.Parameters.AddWithValue("@data", registo.Data);
            cmd.Parameters.AddWithValue("@local", registo.Local);
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

        private void adicionar_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            nr_animal.Text = String.Empty;
            nr_veterinario.Text = String.Empty;
            nome_vacina.Text = String.Empty;
            data.Text = String.Empty;
            local.Text = String.Empty;
            showButtons();
            unlockFields();
            add = true;
            
        }

        private void unlockFields()
        {
            nr_animal.ReadOnly = false;
            nr_veterinario.ReadOnly = false;
            nome_vacina.ReadOnly = false;
            data.ReadOnly = false;
            local.ReadOnly = false;
        }

        private void showButtons()
        {
            buttoncancelar.Visible = true;
            buttonok.Visible = true;
            adicionar.Visible = false;
            editar.Visible = false;
            remover.Visible = false;
        }

        private void lockFields()
        {
            nome_vacina.ReadOnly = true;
            nr_animal.ReadOnly = true;
            nr_veterinario.ReadOnly = true;
            data.ReadOnly = true;
            local.ReadOnly = true;
            
        }

        private void hideButtons()
        {
            buttoncancelar.Visible = false;
            buttonok.Visible = false;
            adicionar.Visible = true;
            editar.Visible = true;
            remover.Visible = true;
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            RegistoVacinacao registo = new RegistoVacinacao();
            
            registo.NrAnimal = nr_animal.Text;
            registo.NrVeterinario = nr_veterinario.Text;
            registo.Nome = nome_vacina.Text;
            registo.Data = data.Text;
            registo.Local = local.Text;



            
            if (add)
            {
                add_vacinacao(registo);
                if(addSucess)
                    listBox1.Items.Add(registo);
            }
            else
            {
                RegistoVacinacao vacinacao = new RegistoVacinacao();
                vacinacao = (RegistoVacinacao)listBox1.Items[currentVacinacao];
                registo.NrVacina = vacinacao.NrVacina;
                edit_vacinacao(registo);
                listBox1.Items[currentVacinacao] = registo;
            }
                
            hideButtons();
            lockFields();
            listBox1.Enabled = true;
            
            
        }

        private void edit_vacinacao(RegistoVacinacao registo)
        {
            
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.EDITAR_VACINACAO @nr_vacina, @nr_animal, @nr_veterinario, @nome, @data, @local";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@nr_vacina", Convert.ToInt16(registo.NrVacina));
            cmd.Parameters.AddWithValue("@nr_veterinario", Convert.ToInt16(registo.NrVeterinario));
            cmd.Parameters.AddWithValue("@nr_animal", Convert.ToInt16(registo.NrAnimal));
            cmd.Parameters.AddWithValue("@nome", registo.Nome);
            cmd.Parameters.AddWithValue("@data", Convert.ToDateTime(registo.Data));
            cmd.Parameters.AddWithValue("@local", registo.Local);
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

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            hideButtons();
            lockFields();
            listBox1.Enabled = true;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            unlockFields();
            showButtons();
            RegistoVacinacao animal = (RegistoVacinacao)listBox1.Items[currentVacinacao];
            add = false;
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                   removeVaca(((RegistoVacinacao)listBox1.SelectedItem).NrVacina, ((RegistoVacinacao)listBox1.SelectedItem).NrAnimal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (currentVacinacao == listBox1.Items.Count)
                    currentVacinacao = listBox1.Items.Count - 1;
                if (currentVacinacao == -1)
                {
                    //ClearFields();
                    MessageBox.Show("There are no more vacinas");
                }
                else
                {
                    showVacinacao();
                }
                listBox1.SelectedIndex = currentVacinacao-1;
            }
        }

        private void removeVaca(String nr_vacina, String nr_animal)
        {
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.REMOVER_VACINACAO @nr_vacina, @nr_animal ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nr_vacina", nr_vacina);
            cmd.Parameters.AddWithValue("@nr_animal", nr_animal);
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
