namespace Vacas
{
    partial class Animais
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nrAnimal = new System.Windows.Forms.TextBox();
            this.progenitorMasc = new System.Windows.Forms.TextBox();
            this.progenitorFem = new System.Windows.Forms.TextBox();
            this.vacinacao = new System.Windows.Forms.TextBox();
            this.nrProdutor = new System.Windows.Forms.TextBox();
            this.analises = new System.Windows.Forms.TextBox();
            this.dataNasc = new System.Windows.Forms.TextBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.tipoAnimal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.raca = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tipoVaca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.editCancel = new System.Windows.Forms.Button();
            this.editOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // listBox1
            // 
            this.listBox1.FormatString = "dd";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 303);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(307, 76);
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Size = new System.Drawing.Size(205, 20);
            this.nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nr do Animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nr Progenitor Masc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vacinação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Estado de Análises:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nr Produtor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nr Progenitor Fem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data de Nascimento:";
            // 
            // nrAnimal
            // 
            this.nrAnimal.Location = new System.Drawing.Point(307, 102);
            this.nrAnimal.Name = "nrAnimal";
            this.nrAnimal.ReadOnly = true;
            this.nrAnimal.Size = new System.Drawing.Size(69, 20);
            this.nrAnimal.TabIndex = 10;
            // 
            // progenitorMasc
            // 
            this.progenitorMasc.Location = new System.Drawing.Point(307, 128);
            this.progenitorMasc.Name = "progenitorMasc";
            this.progenitorMasc.ReadOnly = true;
            this.progenitorMasc.Size = new System.Drawing.Size(69, 20);
            this.progenitorMasc.TabIndex = 11;
            // 
            // progenitorFem
            // 
            this.progenitorFem.Location = new System.Drawing.Point(308, 154);
            this.progenitorFem.Name = "progenitorFem";
            this.progenitorFem.ReadOnly = true;
            this.progenitorFem.Size = new System.Drawing.Size(69, 20);
            this.progenitorFem.TabIndex = 12;
            // 
            // vacinacao
            // 
            this.vacinacao.Location = new System.Drawing.Point(307, 207);
            this.vacinacao.Name = "vacinacao";
            this.vacinacao.ReadOnly = true;
            this.vacinacao.Size = new System.Drawing.Size(104, 20);
            this.vacinacao.TabIndex = 13;
            // 
            // nrProdutor
            // 
            this.nrProdutor.Location = new System.Drawing.Point(456, 102);
            this.nrProdutor.Name = "nrProdutor";
            this.nrProdutor.ReadOnly = true;
            this.nrProdutor.Size = new System.Drawing.Size(56, 20);
            this.nrProdutor.TabIndex = 14;
            // 
            // analises
            // 
            this.analises.Location = new System.Drawing.Point(307, 233);
            this.analises.Name = "analises";
            this.analises.ReadOnly = true;
            this.analises.Size = new System.Drawing.Size(104, 20);
            this.analises.TabIndex = 15;
            // 
            // dataNasc
            // 
            this.dataNasc.Location = new System.Drawing.Point(308, 181);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ReadOnly = true;
            this.dataNasc.Size = new System.Drawing.Size(204, 20);
            this.dataNasc.TabIndex = 16;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(239, 326);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 17;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(320, 326);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 18;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(401, 326);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(75, 23);
            this.Remover.TabIndex = 19;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(12, 5);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 23);
            this.menu.TabIndex = 20;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // tipoAnimal
            // 
            this.tipoAnimal.Enabled = false;
            this.tipoAnimal.FormattingEnabled = true;
            this.tipoAnimal.Items.AddRange(new object[] {
            "Vaca",
            "Boi"});
            this.tipoAnimal.Location = new System.Drawing.Point(307, 44);
            this.tipoAnimal.Name = "tipoAnimal";
            this.tipoAnimal.Size = new System.Drawing.Size(113, 21);
            this.tipoAnimal.TabIndex = 21;
            this.tipoAnimal.SelectedIndexChanged += new System.EventHandler(this.tipoAnimal_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tipo de Animal: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Raça:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Preço:";
            // 
            // raca
            // 
            this.raca.Location = new System.Drawing.Point(437, 155);
            this.raca.Name = "raca";
            this.raca.ReadOnly = true;
            this.raca.Size = new System.Drawing.Size(75, 20);
            this.raca.TabIndex = 25;
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(437, 128);
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Size = new System.Drawing.Size(75, 20);
            this.preco.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tipo de Vaca:";
            // 
            // tipoVaca
            // 
            this.tipoVaca.Location = new System.Drawing.Point(308, 259);
            this.tipoVaca.Name = "tipoVaca";
            this.tipoVaca.ReadOnly = true;
            this.tipoVaca.Size = new System.Drawing.Size(104, 20);
            this.tipoVaca.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Número Animal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(107, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Nome";
            // 
            // editCancel
            // 
            this.editCancel.Location = new System.Drawing.Point(262, 286);
            this.editCancel.Name = "editCancel";
            this.editCancel.Size = new System.Drawing.Size(75, 23);
            this.editCancel.TabIndex = 31;
            this.editCancel.Text = "Cancel";
            this.editCancel.UseVisualStyleBackColor = true;
            this.editCancel.Click += new System.EventHandler(this.editCancel_Click);
            // 
            // editOk
            // 
            this.editOk.Location = new System.Drawing.Point(399, 286);
            this.editOk.Name = "editOk";
            this.editOk.Size = new System.Drawing.Size(75, 23);
            this.editOk.TabIndex = 32;
            this.editOk.Text = "OK";
            this.editOk.UseVisualStyleBackColor = true;
            this.editOk.Click += new System.EventHandler(this.editOk_Click);
            // 
            // Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.editOk);
            this.Controls.Add(this.editCancel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tipoVaca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.raca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tipoAnimal);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.dataNasc);
            this.Controls.Add(this.analises);
            this.Controls.Add(this.nrProdutor);
            this.Controls.Add(this.vacinacao);
            this.Controls.Add(this.progenitorFem);
            this.Controls.Add(this.progenitorMasc);
            this.Controls.Add(this.nrAnimal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nrAnimal;
        private System.Windows.Forms.TextBox progenitorMasc;
        private System.Windows.Forms.TextBox progenitorFem;
        private System.Windows.Forms.TextBox vacinacao;
        private System.Windows.Forms.TextBox nrProdutor;
        private System.Windows.Forms.TextBox analises;
        private System.Windows.Forms.TextBox dataNasc;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.ComboBox tipoAnimal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox raca;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tipoVaca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button editCancel;
        private System.Windows.Forms.Button editOk;
    }
}