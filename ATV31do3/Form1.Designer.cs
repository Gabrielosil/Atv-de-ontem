namespace ATV31do3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtIdade = new TextBox();
            txtSenha = new TextBox();
            txtConfirmar = new TextBox();
            checkBox1 = new CheckBox();
            btnEnviar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 105);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Idade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 152);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 198);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 4;
            label5.Text = "Confirmar Senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(136, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 58);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(136, 98);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(125, 27);
            txtIdade.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(136, 149);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 8;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(136, 195);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(125, 27);
            txtConfirmar.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(303, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Termos de Uso";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(188, 244);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 11;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(88, 244);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Clear";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 306);
            Controls.Add(btnLimpar);
            Controls.Add(btnEnviar);
            Controls.Add(checkBox1);
            Controls.Add(txtConfirmar);
            Controls.Add(txtSenha);
            Controls.Add(txtIdade);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtIdade;
        private TextBox txtSenha;
        private TextBox txtConfirmar;
        private CheckBox checkBox1;
        private Button btnEnviar;
        private Button btnLimpar;
    }
}
