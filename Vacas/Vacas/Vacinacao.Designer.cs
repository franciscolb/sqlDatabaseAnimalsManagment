namespace Vacas
{
    partial class Vacinacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.local = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.nome_vacina = new System.Windows.Forms.TextBox();
            this.nr_veterinario = new System.Windows.Forms.TextBox();
            this.nr_animal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.remover = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.menu_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 277);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(296, 210);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(130, 20);
            this.local.TabIndex = 67;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(296, 184);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(130, 20);
            this.data.TabIndex = 66;
            // 
            // nome_vacina
            // 
            this.nome_vacina.Location = new System.Drawing.Point(296, 158);
            this.nome_vacina.Name = "nome_vacina";
            this.nome_vacina.Size = new System.Drawing.Size(130, 20);
            this.nome_vacina.TabIndex = 65;
            // 
            // nr_veterinario
            // 
            this.nr_veterinario.Location = new System.Drawing.Point(296, 132);
            this.nr_veterinario.Name = "nr_veterinario";
            this.nr_veterinario.Size = new System.Drawing.Size(130, 20);
            this.nr_veterinario.TabIndex = 64;
            // 
            // nr_animal
            // 
            this.nr_animal.Location = new System.Drawing.Point(296, 106);
            this.nr_animal.Name = "nr_animal";
            this.nr_animal.Size = new System.Drawing.Size(130, 20);
            this.nr_animal.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Local:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nome da Vacina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Número do Veterinário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Número do Animal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(173, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 68;
            this.label8.Text = "Registo da Vacinação";
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(341, 282);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 71;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(260, 282);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 70;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(179, 282);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 69;
            this.adicionar.Text = "Adicionar Comprador";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(215, 253);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(75, 23);
            this.buttonok.TabIndex = 72;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.Location = new System.Drawing.Point(312, 253);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(75, 23);
            this.buttoncancelar.TabIndex = 73;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = true;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Nome";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Nr Animal";
            // 
            // Vacinacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.local);
            this.Controls.Add(this.data);
            this.Controls.Add(this.nome_vacina);
            this.Controls.Add(this.nr_veterinario);
            this.Controls.Add(this.nr_animal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Vacinacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacinação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox nome_vacina;
        private System.Windows.Forms.TextBox nr_veterinario;
        private System.Windows.Forms.TextBox nr_animal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}