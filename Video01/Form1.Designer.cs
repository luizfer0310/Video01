namespace Video01
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
            this.video1 = new System.Windows.Forms.Label();
            this.Proximo = new System.Windows.Forms.Button();
            this.Assunto = new System.Windows.Forms.Label();
            this.fontes = new System.Windows.Forms.Label();
            this.explicar = new System.Windows.Forms.Label();
            this.simplifica = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // video1
            // 
            this.video1.AutoSize = true;
            this.video1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.video1.Location = new System.Drawing.Point(21, 9);
            this.video1.Name = "video1";
            this.video1.Size = new System.Drawing.Size(280, 16);
            this.video1.TabIndex = 0;
            this.video1.Text = "Como se tornar um Mestre nos estudos!";
            // 
            // Proximo
            // 
            this.Proximo.Location = new System.Drawing.Point(124, 268);
            this.Proximo.Name = "Proximo";
            this.Proximo.Size = new System.Drawing.Size(75, 23);
            this.Proximo.TabIndex = 1;
            this.Proximo.Text = "Proximo";
            this.Proximo.UseVisualStyleBackColor = true;
            this.Proximo.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // Assunto
            // 
            this.Assunto.AutoSize = true;
            this.Assunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assunto.ForeColor = System.Drawing.Color.Red;
            this.Assunto.Location = new System.Drawing.Point(21, 43);
            this.Assunto.Name = "Assunto";
            this.Assunto.Size = new System.Drawing.Size(216, 15);
            this.Assunto.TabIndex = 3;
            this.Assunto.Text = "Decidir um tema a ser estudado!";
            // 
            // fontes
            // 
            this.fontes.AutoSize = true;
            this.fontes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontes.ForeColor = System.Drawing.Color.Lime;
            this.fontes.Location = new System.Drawing.Point(21, 75);
            this.fontes.Name = "fontes";
            this.fontes.Size = new System.Drawing.Size(266, 15);
            this.fontes.TabIndex = 4;
            this.fontes.Text = "Procurar as melhores fontes do Assunto!";
            // 
            // explicar
            // 
            this.explicar.AutoSize = true;
            this.explicar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.explicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.explicar.Location = new System.Drawing.Point(21, 103);
            this.explicar.Name = "explicar";
            this.explicar.Size = new System.Drawing.Size(323, 60);
            this.explicar.TabIndex = 5;
            this.explicar.Text = "Estudar o assunto e tentar explicar de forma que \r\nqualquer um posso entender, \r\n" +
    "assim saberá oque é preciso estudar melhor!\r\n\r\n";
            this.explicar.UseMnemonic = false;
            // 
            // simplifica
            // 
            this.simplifica.AutoSize = true;
            this.simplifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simplifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.simplifica.Location = new System.Drawing.Point(21, 172);
            this.simplifica.Name = "simplifica";
            this.simplifica.Size = new System.Drawing.Size(308, 30);
            this.simplifica.TabIndex = 6;
            this.simplifica.Text = "E por ultimo tente simplificar a sua explicação \r\nde forma mais clara e simples!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Video01.Properties.Resources.fim;
            this.pictureBox1.Location = new System.Drawing.Point(110, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(359, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simplifica);
            this.Controls.Add(this.explicar);
            this.Controls.Add(this.fontes);
            this.Controls.Add(this.Assunto);
            this.Controls.Add(this.Proximo);
            this.Controls.Add(this.video1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label video1;
        private System.Windows.Forms.Button Proximo;
        private System.Windows.Forms.Label Assunto;
        private System.Windows.Forms.Label fontes;
        private System.Windows.Forms.Label explicar;
        private System.Windows.Forms.Label simplifica;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

