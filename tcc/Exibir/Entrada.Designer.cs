namespace tcc.Exibir
{
    partial class Entrada
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
            this.txtExibirSaldo = new System.Windows.Forms.TextBox();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.bntREntrada = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(79, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtExibirSaldo
            // 
            this.txtExibirSaldo.Location = new System.Drawing.Point(141, 63);
            this.txtExibirSaldo.Name = "txtExibirSaldo";
            this.txtExibirSaldo.Size = new System.Drawing.Size(129, 20);
            this.txtExibirSaldo.TabIndex = 1;
            this.txtExibirSaldo.TextChanged += new System.EventHandler(this.txtExibirSaldo_TextChanged);
            // 
            // txtDescrição
            // 
            this.txtDescrição.Location = new System.Drawing.Point(141, 113);
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(129, 20);
            this.txtDescrição.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(36, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(141, 160);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(129, 20);
            this.txtEntrada.TabIndex = 4;
            // 
            // bntREntrada
            // 
            this.bntREntrada.Location = new System.Drawing.Point(141, 207);
            this.bntREntrada.Name = "bntREntrada";
            this.bntREntrada.Size = new System.Drawing.Size(129, 25);
            this.bntREntrada.TabIndex = 7;
            this.bntREntrada.Text = "Registrar Entrada";
            this.bntREntrada.UseVisualStyleBackColor = true;
            this.bntREntrada.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(50, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Novo Saldo";
            // 
            // txtNSaldo
            // 
            this.txtNSaldo.Location = new System.Drawing.Point(141, 270);
            this.txtNSaldo.Name = "txtNSaldo";
            this.txtNSaldo.Size = new System.Drawing.Size(129, 20);
            this.txtNSaldo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(136, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "ENTRADA";
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNSaldo);
            this.Controls.Add(this.bntREntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.txtExibirSaldo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExibirSaldo;
        private System.Windows.Forms.TextBox txtDescrição;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button bntREntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNSaldo;
        private System.Windows.Forms.Label label5;
    }
}