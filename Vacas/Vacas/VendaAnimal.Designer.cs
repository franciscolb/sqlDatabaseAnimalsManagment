namespace Vacas
{
    partial class VendaAnimal
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nif = new System.Windows.Forms.TextBox();
            this.localidade = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.adicionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(252, 92);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(176, 20);
            this.nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Localidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email:";
            // 
            // nif
            // 
            this.nif.Location = new System.Drawing.Point(252, 118);
            this.nif.Name = "nif";
            this.nif.Size = new System.Drawing.Size(100, 20);
            this.nif.TabIndex = 9;
            // 
            // localidade
            // 
            this.localidade.Location = new System.Drawing.Point(313, 144);
            this.localidade.Name = "localidade";
            this.localidade.Size = new System.Drawing.Size(137, 20);
            this.localidade.TabIndex = 11;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(265, 196);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 20);
            this.telefone.TabIndex = 12;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(313, 170);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(100, 20);
            this.data.TabIndex = 13;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(252, 222);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(161, 20);
            this.email.TabIndex = 14;
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexo.Location = new System.Drawing.Point(408, 118);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(42, 21);
            this.sexo.TabIndex = 15;
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(210, 269);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 16;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Menu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Registar Venda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Avançar_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(291, 269);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 19;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(372, 269);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 20;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(215, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Registar Comprador";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(344, 257);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(239, 257);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 49;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // VendaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.data);
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
            this.Name = "VendaAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda de Animal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nif;
        private System.Windows.Forms.TextBox localidade;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}