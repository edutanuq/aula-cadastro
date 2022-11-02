namespace AulaCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBnome = new System.Windows.Forms.TextBox();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(310, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(323, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBnome
            // 
            this.txtBnome.Location = new System.Drawing.Point(46, 304);
            this.txtBnome.Name = "txtBnome";
            this.txtBnome.Size = new System.Drawing.Size(589, 20);
            this.txtBnome.TabIndex = 2;
            this.txtBnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(46, 357);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(589, 20);
            this.txtBid.TabIndex = 3;
            this.txtBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cadastrarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cadastrarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cadastrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cadastrarBtn.Location = new System.Drawing.Point(46, 408);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(589, 36);
            this.cadastrarBtn.TabIndex = 4;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = false;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AulaCadastro.Properties.Resources._7f7f2882899755a705a2953b6fcfc263;
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.txtBnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBnome;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

