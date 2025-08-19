namespace Jokenpo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.lblPedra = new System.Windows.Forms.Label();
            this.lblPapel = new System.Windows.Forms.Label();
            this.lblTesoura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(261, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Escolha sua opção: ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(91, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(297, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // picResultado
            // 
            this.picResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResultado.Location = new System.Drawing.Point(503, 293);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(150, 150);
            this.picResultado.TabIndex = 3;
            this.picResultado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(135, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Você";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(258, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "VS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(356, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "PC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(469, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblresultado.Location = new System.Drawing.Point(574, 409);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(21, 24);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "?";
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedra.BackgroundImage")));
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPedra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedra.Location = new System.Drawing.Point(91, 109);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(150, 150);
            this.btnPedra.TabIndex = 9;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPapel.BackgroundImage")));
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPapel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Location = new System.Drawing.Point(297, 109);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(150, 150);
            this.btnPapel.TabIndex = 10;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTesoura.BackgroundImage")));
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTesoura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesoura.Location = new System.Drawing.Point(503, 109);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(150, 150);
            this.btnTesoura.TabIndex = 11;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // lblPedra
            // 
            this.lblPedra.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedra.ForeColor = System.Drawing.Color.Black;
            this.lblPedra.Location = new System.Drawing.Point(120, 62);
            this.lblPedra.Name = "lblPedra";
            this.lblPedra.Size = new System.Drawing.Size(101, 44);
            this.lblPedra.TabIndex = 12;
            this.lblPedra.Text = "Pedra";
            this.lblPedra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPapel
            // 
            this.lblPapel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPapel.ForeColor = System.Drawing.Color.Black;
            this.lblPapel.Location = new System.Drawing.Point(319, 62);
            this.lblPapel.Name = "lblPapel";
            this.lblPapel.Size = new System.Drawing.Size(101, 44);
            this.lblPapel.TabIndex = 13;
            this.lblPapel.Text = "Papel";
            this.lblPapel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTesoura
            // 
            this.lblTesoura.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesoura.ForeColor = System.Drawing.Color.Black;
            this.lblTesoura.Location = new System.Drawing.Point(531, 62);
            this.lblTesoura.Name = "lblTesoura";
            this.lblTesoura.Size = new System.Drawing.Size(101, 44);
            this.lblTesoura.TabIndex = 14;
            this.lblTesoura.Text = "Tesoura";
            this.lblTesoura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(744, 518);
            this.Controls.Add(this.lblTesoura);
            this.Controls.Add(this.lblPapel);
            this.Controls.Add(this.lblPedra);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picResultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpô";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Label lblPedra;
        private System.Windows.Forms.Label lblPapel;
        private System.Windows.Forms.Label lblTesoura;
    }
}

