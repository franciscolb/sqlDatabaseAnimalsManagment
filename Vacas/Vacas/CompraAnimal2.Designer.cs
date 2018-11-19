namespace Vacas
{
    partial class CompraAnimal2
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
            this.nrAnimal = new System.Windows.Forms.TextBox();
            this.destino = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.montante = new System.Windows.Forms.TextBox();
            this.nif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.menu_Click);
            // 
            // nrAnimal
            // 
            this.nrAnimal.Location = new System.Drawing.Point(237, 190);
            this.nrAnimal.Name = "nrAnimal";
            this.nrAnimal.Size = new System.Drawing.Size(130, 20);
            this.nrAnimal.TabIndex = 29;
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(237, 164);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(130, 20);
            this.destino.TabIndex = 28;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(237, 138);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(130, 20);
            this.data.TabIndex = 27;
            // 
            // montante
            // 
            this.montante.Location = new System.Drawing.Point(237, 112);
            this.montante.Name = "montante";
            this.montante.Size = new System.Drawing.Size(130, 20);
            this.montante.TabIndex = 26;
            // 
            // nif
            // 
            this.nif.Location = new System.Drawing.Point(237, 86);
            this.nif.Name = "nif";
            this.nif.Size = new System.Drawing.Size(130, 20);
            this.nif.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nr Animal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Montante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "NIF:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompraAnimal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nrAnimal);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.data);
            this.Controls.Add(this.montante);
            this.Controls.Add(this.nif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompraAnimal2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompraAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nrAnimal;
        private System.Windows.Forms.TextBox destino;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox montante;
        private System.Windows.Forms.TextBox nif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}