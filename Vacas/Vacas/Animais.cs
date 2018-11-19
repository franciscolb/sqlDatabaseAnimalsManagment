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
    public partial class Animais : Form
    {
        private int currentAnimal;
        private bool add;
        private bool addSucess;
        public Animais()
        {
            InitializeComponent();
            editOk.Visible = false;
            editCancel.Visible = false;
            initialize();

        }

        private void initialize()
        {
            Connect.verifySGBDConnection();
            SqlCommand cmd = new SqlCommand("EXEC VACAS.VERBOIS", Connect.cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tipoAnimal.SelectedIndex = 0;
                Animal A = new Animal();
                A.produtor = reader["PRODUTOR"].ToString();
                A.nrAnimal = reader["NR_ANIMAL"].ToString();
                A.progenitorMasc = reader["PROGENITOR_MASC"].ToString();
                A.progenitorFem = reader["PROGENITOR_FEM"].ToString();
                A.estadoVacinacao = reader["ESTADO_VACINA"].ToString();
                A.estadoAnalises = reader["ESTADO_ANÁLISES"].ToString();
                A.nome = reader["NOME"].ToString();
                A.dataNasc = reader["DATA_NASCIMENTO"].ToString();
                A.Raca = reader["RACA"].ToString();
                A.Preco = reader["PRECO"].ToString();
                A.Vaca = false;
                listBox1.Items.Add(A);
            }
            Connect.cn.Close();
            Connect.cn.Open();
            cmd = new SqlCommand("EXEC VACAS.VERVACAS", Connect.cn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Animal A = new Animal();
                A.produtor = reader["PRODUTOR"].ToString();
                A.nrAnimal = reader["NR_ANIMAL"].ToString();
                A.progenitorMasc = reader["PROGENITOR_MASC"].ToString();
                A.progenitorFem = reader["PROGENITOR_FEM"].ToString();
                A.estadoVacinacao = reader["ESTADO_VACINA"].ToString();
                A.estadoAnalises = reader["ESTADO_ANÁLISES"].ToString();
                A.nome = reader["NOME"].ToString();
                A.dataNasc = reader["DATA_NASCIMENTO"].ToString();
                A.Raca = reader["RACA"].ToString();
                A.TipoVaca = reader["TIPO_VACA"].ToString();
                A.Preco = reader["PRECO"].ToString();
                A.Vaca = true;
                listBox1.Items.Add(A);
            }
            currentAnimal = 0;
            listBox1.SelectedIndex = currentAnimal;
            showAnimal();
            Connect.cn.Close();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }


        private void showAnimal()
        {
            Animal animal = new Animal();
            animal = (Animal)listBox1.Items[currentAnimal];
            nome.Text = animal.nome;
            nrAnimal.Text = animal.nrAnimal;
            progenitorMasc.Text = animal.progenitorMasc;
            progenitorFem.Text = animal.progenitorFem;
            nrProdutor.Text = animal.produtor;
            dataNasc.Text = animal.dataNasc;
            analises.Text = animal.estadoAnalises;
            vacinacao.Text = animal.estadoVacinacao;
            raca.Text = animal.Raca;
            preco.Text = animal.Preco.ToString();
            if (animal.Vaca)
            {
                tipoAnimal.SelectedIndex = 0;
                tipoVaca.Text = animal.TipoVaca;
                tipoVaca.Visible = true;
                label12.Visible = true;
            }
            else
            {
                tipoAnimal.SelectedIndex = 1;
                tipoVaca.Visible = false;
                label12.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                currentAnimal = listBox1.SelectedIndex;
                showAnimal();
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {

            unlockFields();
            showButtons();
            Animal animal = (Animal)listBox1.Items[currentAnimal];
            if (animal.Vaca)
            {
                tipoVaca.ReadOnly = false;
            }

            add = false;
        }

        private void editOk_Click(object sender, EventArgs e)
        {
                

            Animal animal = new Animal();
            animal.nrAnimal = nrAnimal.Text;
            animal.nome = nome.Text;
            animal.produtor = nrProdutor.Text;
            animal.Vaca = tipoAnimal.SelectedIndex == 0;
            animal.progenitorMasc = progenitorMasc.Text;
            animal.progenitorFem = progenitorFem.Text;
            animal.Preco = preco.Text;
            animal.Raca = raca.Text;
            animal.dataNasc = dataNasc.Text;
            animal.estadoVacinacao = vacinacao.Text;
            animal.estadoAnalises = analises.Text;
            animal.TipoVaca = tipoVaca.Text;

            if (add)
            {
                if (tipoAnimal.SelectedIndex == 0)
                    addVaca(animal);
                else
                    addBoi(animal);
                if(addSucess)
                    listBox1.Items.Add(animal);
            }
            else
            {
                editVaca(animal);
                listBox1.Items[currentAnimal] = animal;
            }
                
            hideButtons();
            lockFields();
            listBox1.Enabled = true;
            tipoAnimal.Enabled = false;
        }

        private void editCancel_Click(object sender, EventArgs e)
        {
            hideButtons();
            lockFields();
            tipoAnimal.Enabled = false;
            listBox1.Enabled = true;
        }


        public void editVaca(Animal animal)
        {
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.EDITAR_VACA @numeroAnimal, @nome, @produtor, @progenitorMasc, @progenitorFem, @preco, @raca, @dataNasc, @estadoVacina, @analises, @tipoVaca";
            cmd.Parameters.Clear();
            if(preco.Text != String.Empty)
                cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(animal.Preco));
            else
                cmd.Parameters.AddWithValue("@preco", DBNull.Value);
            cmd.Parameters.AddWithValue("@produtor", Convert.ToInt16(animal.produtor));
            cmd.Parameters.AddWithValue("@nome", animal.nome);
            cmd.Parameters.AddWithValue("@progenitorMasc", Convert.ToInt16(animal.progenitorMasc));
            cmd.Parameters.AddWithValue("@progenitorFem", Convert.ToInt16(animal.progenitorFem));
            cmd.Parameters.AddWithValue("@raca", animal.Raca);
            cmd.Parameters.AddWithValue("@dataNasc", animal.dataNasc);
            cmd.Parameters.AddWithValue("@tipoVaca", animal.TipoVaca);
            cmd.Parameters.AddWithValue("@estadoVacina", animal.estadoVacinacao);
            cmd.Parameters.AddWithValue("@analises", animal.estadoAnalises);
            cmd.Parameters.AddWithValue("@numeroAnimal", Convert.ToInt16(animal.nrAnimal));
            cmd.Connection = Connect.cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar à base de dados.");
                throw new Exception("Failed to update database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 2)
                    MessageBox.Show("Update OK");
                else
                    MessageBox.Show("Update NOT OK");

                Connect.cn.Close();
            }
           
        }

        public void addVaca(Animal animal)
        {
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "EXEC VACAS.ADD_VACA @numeroAnimal, @nome, @produtor, @progenitorMasc, @progenitorFem, @preco, @raca, @dataNasc, @estadoVacina, @analises, @tipoVaca ";
             cmd.Parameters.Clear();
            if(preco.Text != String.Empty)
                cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(animal.Preco));
            else
                cmd.Parameters.AddWithValue("@preco", DBNull.Value);
            cmd.Parameters.AddWithValue("@produtor", Convert.ToInt16(animal.produtor));
            cmd.Parameters.AddWithValue("@nome", animal.nome);
            cmd.Parameters.AddWithValue("@progenitorMasc", Convert.ToInt16(animal.progenitorMasc));
            cmd.Parameters.AddWithValue("@progenitorFem", Convert.ToInt16(animal.progenitorFem));
            cmd.Parameters.AddWithValue("@raca", animal.Raca);
            cmd.Parameters.AddWithValue("@dataNasc", animal.dataNasc);
            cmd.Parameters.AddWithValue("@tipoVaca", animal.TipoVaca);
            cmd.Parameters.AddWithValue("@estadoVacina", animal.estadoVacinacao);
            cmd.Parameters.AddWithValue("@analises", animal.estadoAnalises);
            cmd.Parameters.AddWithValue("@numeroAnimal", Convert.ToInt16(animal.nrAnimal));
            cmd.Connection = Connect.cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("404 NOT FOUND");
                addSucess = false;
                //throw new Exception("Failed to update database. \n ERROR MESSAGE: \n" + ex.Message);
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

        public void addBoi(Animal animal)
        {
            int rows = 0;
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.ADD_BOI @numeroAnimal, @nome, @produtor, @progenitorMasc, @progenitorFem, @preco, @raca, @dataNasc, @estadoVacina, @analises ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@preco", animal.Preco);
            cmd.Parameters.AddWithValue("@produtor", animal.produtor);
            cmd.Parameters.AddWithValue("@nome", animal.nome);
            cmd.Parameters.AddWithValue("@progenitorMasc", animal.progenitorMasc);
            cmd.Parameters.AddWithValue("@progenitorFem", animal.progenitorFem);
            cmd.Parameters.AddWithValue("@raca", animal.Raca);
            cmd.Parameters.AddWithValue("@dataNasc", animal.dataNasc);
            cmd.Parameters.AddWithValue("@estadoVacina", animal.estadoVacinacao);
            cmd.Parameters.AddWithValue("@analises", animal.estadoAnalises);
            cmd.Parameters.AddWithValue("@numeroAnimal", Convert.ToInt16(animal.nrAnimal));
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

        public void removeVaca(String nrAnimal)
        {
            if (!Connect.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EXEC VACAS.REMOVE_VACA @nrAnimal ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nrAnimal", nrAnimal);
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
            nrAnimal.ReadOnly = false;
            nrProdutor.ReadOnly = false;
            progenitorFem.ReadOnly = false;
            progenitorMasc.ReadOnly = false;
            preco.ReadOnly = false;
            raca.ReadOnly = false;
            dataNasc.ReadOnly = false;
            vacinacao.ReadOnly = false;
            analises.ReadOnly = false;
            tipoVaca.ReadOnly = false;
        }
        private void lockFields()
        {
            nome.ReadOnly = true;
            nrAnimal.ReadOnly = true;
            nrProdutor.ReadOnly = true;
            progenitorFem.ReadOnly = true;
            progenitorMasc.ReadOnly = true;
            preco.ReadOnly = true;
            raca.ReadOnly = true;
            dataNasc.ReadOnly = true;
            vacinacao.ReadOnly = true;
            analises.ReadOnly = true;
            tipoVaca.ReadOnly = true;
           
        }

        private void showButtons()
        {
            editCancel.Visible = true;
            editOk.Visible = true;
            Adicionar.Visible = false;
            Editar.Visible = false;
            Remover.Visible = false;
        }
        private void hideButtons()
        {
            editCancel.Visible = false;
            editOk.Visible = false;
            Adicionar.Visible = true;
            Editar.Visible = true;
            Remover.Visible = true;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            tipoAnimal.Enabled = true;
            nome.Text = String.Empty;
            nrAnimal.Text = String.Empty;
            progenitorMasc.Text = String.Empty;
            progenitorFem.Text = String.Empty;
            nrProdutor.Text = String.Empty;
            dataNasc.Text = String.Empty;
            analises.Text = String.Empty;
            vacinacao.Text = String.Empty;
            raca.Text = String.Empty;
            preco.Text = String.Empty;
            showButtons();
            unlockFields();
            add = true;
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    removeVaca(((Animal)listBox1.SelectedItem).nrAnimal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (currentAnimal == listBox1.Items.Count)
                    currentAnimal = listBox1.Items.Count - 1;
                if (currentAnimal == -1)
                {
                    //ClearFields();
                    MessageBox.Show("There are no more vacas");
                }
                else
                {
                    showAnimal();
                }
            }
        }

        private void tipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoAnimal.SelectedIndex == 0)
            {
                tipoVaca.Visible = true;
                label12.Visible = true;
            }
            else
            {
                tipoVaca.Visible = false;
                label12.Visible = true;
            }
          
        }
    }
}
