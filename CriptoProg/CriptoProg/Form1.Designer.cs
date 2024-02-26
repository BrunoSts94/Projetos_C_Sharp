namespace CriptoProg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnCriptografa = new Button();
            btnDescriptografa = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCopiaCriptografia = new Button();
            btnCopiaDescriptografia = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(20, 71);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(571, 45);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(20, 242);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(571, 81);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnCriptografa
            // 
            btnCriptografa.BackColor = Color.SlateGray;
            btnCriptografa.FlatStyle = FlatStyle.Popup;
            btnCriptografa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriptografa.Location = new Point(185, 122);
            btnCriptografa.Margin = new Padding(3, 2, 3, 2);
            btnCriptografa.Name = "btnCriptografa";
            btnCriptografa.Size = new Size(329, 47);
            btnCriptografa.TabIndex = 2;
            btnCriptografa.Text = "CRIPTOGRAFAR";
            btnCriptografa.UseVisualStyleBackColor = false;
            btnCriptografa.Click += btnCriptografa_Click;
            // 
            // btnDescriptografa
            // 
            btnDescriptografa.BackColor = Color.SlateGray;
            btnDescriptografa.FlatStyle = FlatStyle.Popup;
            btnDescriptografa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDescriptografa.Location = new Point(185, 328);
            btnDescriptografa.Margin = new Padding(3, 2, 3, 2);
            btnDescriptografa.Name = "btnDescriptografa";
            btnDescriptografa.Size = new Size(329, 47);
            btnDescriptografa.TabIndex = 3;
            btnDescriptografa.Text = "DESCRIPTOGRAFAR";
            btnDescriptografa.UseVisualStyleBackColor = false;
            btnDescriptografa.Click += btnDescriptografa_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.SlateGray;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(130, 391);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(431, 52);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "LIMPAR DADOS";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 48);
            label1.Name = "label1";
            label1.Size = new Size(299, 20);
            label1.TabIndex = 5;
            label1.Text = "INSIRA OS DADOS PARA CRIPTOGRAFAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(176, 218);
            label2.Name = "label2";
            label2.Size = new Size(326, 20);
            label2.TabIndex = 6;
            label2.Text = "INSIRA OS DADOS PARA DESCRIPTOGRAFAR";
            // 
            // btnCopiaCriptografia
            // 
            btnCopiaCriptografia.BackColor = Color.SlateGray;
            btnCopiaCriptografia.FlatAppearance.BorderColor = Color.White;
            btnCopiaCriptografia.FlatStyle = FlatStyle.Popup;
            btnCopiaCriptografia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopiaCriptografia.Location = new Point(607, 70);
            btnCopiaCriptografia.Margin = new Padding(3, 2, 3, 2);
            btnCopiaCriptografia.Name = "btnCopiaCriptografia";
            btnCopiaCriptografia.Size = new Size(82, 46);
            btnCopiaCriptografia.TabIndex = 7;
            btnCopiaCriptografia.Text = "COPIAR";
            btnCopiaCriptografia.UseVisualStyleBackColor = false;
            btnCopiaCriptografia.Click += btnCopiaCriptografia_Click;
            // 
            // btnCopiaDescriptografia
            // 
            btnCopiaDescriptografia.BackColor = Color.SlateGray;
            btnCopiaDescriptografia.FlatAppearance.BorderColor = Color.White;
            btnCopiaDescriptografia.FlatStyle = FlatStyle.Popup;
            btnCopiaDescriptografia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopiaDescriptografia.Location = new Point(607, 244);
            btnCopiaDescriptografia.Margin = new Padding(3, 2, 3, 2);
            btnCopiaDescriptografia.Name = "btnCopiaDescriptografia";
            btnCopiaDescriptografia.Size = new Size(82, 78);
            btnCopiaDescriptografia.TabIndex = 8;
            btnCopiaDescriptografia.Text = "COPIAR";
            btnCopiaDescriptografia.UseVisualStyleBackColor = false;
            btnCopiaDescriptografia.Click += btnCopiaDescriptografia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(700, 460);
            Controls.Add(btnCopiaDescriptografia);
            Controls.Add(btnCopiaCriptografia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnDescriptografa);
            Controls.Add(btnCriptografa);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Ferramenta de Criptografia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCriptografa;
        private Button btnDescriptografa;
        private Button btnLimpar;
        private Label label1;
        private Label label2;
        private Button btnCopiaCriptografia;
        private Button btnCopiaDescriptografia;
    }
}