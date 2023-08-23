namespace Visualizador_de_Imagem
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
            this.imagensListBox = new System.Windows.Forms.ListBox();
            this.favListBox = new System.Windows.Forms.ListBox();
            this.addFav = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeFav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagensListBox
            // 
            this.imagensListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagensListBox.FormattingEnabled = true;
            this.imagensListBox.Location = new System.Drawing.Point(43, 12);
            this.imagensListBox.Name = "imagensListBox";
            this.imagensListBox.Size = new System.Drawing.Size(804, 134);
            this.imagensListBox.TabIndex = 0;
            this.imagensListBox.SelectedIndexChanged += new System.EventHandler(this.imagensListBox_SelectedIndexChanged);
            // 
            // favListBox
            // 
            this.favListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favListBox.FormattingEnabled = true;
            this.favListBox.Location = new System.Drawing.Point(43, 200);
            this.favListBox.Name = "favListBox";
            this.favListBox.Size = new System.Drawing.Size(804, 95);
            this.favListBox.TabIndex = 1;
            // 
            // addFav
            // 
            this.addFav.Location = new System.Drawing.Point(498, 161);
            this.addFav.Name = "addFav";
            this.addFav.Size = new System.Drawing.Size(137, 23);
            this.addFav.TabIndex = 2;
            this.addFav.Text = "Add Fav";
            this.addFav.UseVisualStyleBackColor = true;
            this.addFav.Click += new System.EventHandler(this.addFav_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(43, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 264);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // removeFav
            // 
            this.removeFav.Location = new System.Drawing.Point(210, 161);
            this.removeFav.Name = "removeFav";
            this.removeFav.Size = new System.Drawing.Size(137, 23);
            this.removeFav.TabIndex = 4;
            this.removeFav.Text = "Remove Fav";
            this.removeFav.UseVisualStyleBackColor = true;
            this.removeFav.Click += new System.EventHandler(this.removeFav_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 625);
            this.Controls.Add(this.removeFav);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addFav);
            this.Controls.Add(this.favListBox);
            this.Controls.Add(this.imagensListBox);
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox imagensListBox;
        private System.Windows.Forms.ListBox favListBox;
        private System.Windows.Forms.Button addFav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button removeFav;
    }
}

