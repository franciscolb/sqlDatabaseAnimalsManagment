namespace Vacas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Animais";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Animais_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Venda de Animais";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.VendaAnimal_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Compra de Animais";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CompraAnimal_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(173, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Venda de Leite";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.VendaLeite_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Vacinação";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Vacinação_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(173, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "Histórico de Vendas";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.HistoricoVendas_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(11, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 44);
            this.button7.TabIndex = 6;
            this.button7.Text = "Histórico de Compras";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.HistoricoCompras_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(173, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(156, 44);
            this.button8.TabIndex = 7;
            this.button8.Text = "Sair";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menú";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}

