namespace tcc.Exibir
{
    partial class menuadm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuadm));
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonSaida = new System.Windows.Forms.ToolStripButton();
            this.ButtonEntrada = new System.Windows.Forms.ToolStripButton();
            this.ButtonCadastro = new System.Windows.Forms.ToolStripButton();
            this.txtExibirSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Atualizar Saldo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSaida,
            this.ButtonEntrada,
            this.ButtonCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(316, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonSaida
            // 
            this.ButtonSaida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSaida.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSaida.Image")));
            this.ButtonSaida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSaida.Name = "ButtonSaida";
            this.ButtonSaida.Size = new System.Drawing.Size(24, 24);
            this.ButtonSaida.Text = "ButtonSaida";
            this.ButtonSaida.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ButtonEntrada
            // 
            this.ButtonEntrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonEntrada.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEntrada.Image")));
            this.ButtonEntrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonEntrada.Name = "ButtonEntrada";
            this.ButtonEntrada.Size = new System.Drawing.Size(24, 24);
            this.ButtonEntrada.Text = "ButtonEntrada";
            this.ButtonEntrada.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ButtonCadastro
            // 
            this.ButtonCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonCadastro.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCadastro.Image")));
            this.ButtonCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCadastro.Name = "ButtonCadastro";
            this.ButtonCadastro.Size = new System.Drawing.Size(24, 24);
            this.ButtonCadastro.Text = "ButtonCadastro";
            this.ButtonCadastro.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // txtExibirSaldo
            // 
            this.txtExibirSaldo.Location = new System.Drawing.Point(128, 135);
            this.txtExibirSaldo.Name = "txtExibirSaldo";
            this.txtExibirSaldo.Size = new System.Drawing.Size(136, 20);
            this.txtExibirSaldo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(146, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Saldo";
            // 
            // menuadm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExibirSaldo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Name = "menuadm";
            this.Text = "menuadm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonSaida;
        private System.Windows.Forms.ToolStripButton ButtonEntrada;
        private System.Windows.Forms.ToolStripButton ButtonCadastro;
        private System.Windows.Forms.TextBox txtExibirSaldo;
        private System.Windows.Forms.Label label1;
    }
}