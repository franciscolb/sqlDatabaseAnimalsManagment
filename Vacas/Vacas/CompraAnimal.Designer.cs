namespace Vacas
{
    partial class CompraAnimal
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
            this.button2 = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.email = new System.Windows.Forms.TextBox();
            this.dataNascimento = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.localidade = new System.Windows.Forms.TextBox();
            this.nif = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.remover = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.menu_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(207, 268);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 34;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexo.Location = new System.Drawing.Point(402, 115);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(42, 21);
            this.sexo.TabIndex = 33;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(246, 219);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(161, 20);
            this.email.TabIndex = 32;
            // 
            // dataNascimento
            // 
            this.dataNascimento.Location = new System.Drawing.Point(307, 167);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(100, 20);
            this.dataNascimento.TabIndex = 31;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(259, 193);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 20);
            this.telefone.TabIndex = 30;
            // 
            // localidade
            // 
            this.localidade.Location = new System.Drawing.Point(307, 141);
            this.localidade.Name = "localidade";
            this.localidade.Size = new System.Drawing.Size(137, 20);
            this.localidade.TabIndex = 29;
            // 
            // nif
            // 
            this.nif.Location = new System.Drawing.Point(246, 115);
            this.nif.Name = "nif";
            this.nif.Size = new System.Drawing.Size(100, 20);
            this.nif.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Localidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "NIF:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(246, 89);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(176, 20);
            this.nome.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 290);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(213, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Registar Vendedor";
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(369, 268);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 39;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(288, 268);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 38;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Registar Compra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.pag2_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(246, 259);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 40;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(347, 259);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 41;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CompraAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.localidade);
            this.Controls.Add(this.nif);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "CompraAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Compra de Animal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox dataNascimento;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox localidade;
        private System.Windows.Forms.TextBox nif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancel;
    }
}