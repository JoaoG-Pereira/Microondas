namespace Microondas.Interfaces
{
    partial class LoginForm
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
            this.CadastroLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.EntrarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CadastroLinkLabel
            // 
            this.CadastroLinkLabel.AutoSize = true;
            this.CadastroLinkLabel.Location = new System.Drawing.Point(104, 127);
            this.CadastroLinkLabel.Name = "CadastroLinkLabel";
            this.CadastroLinkLabel.Size = new System.Drawing.Size(81, 13);
            this.CadastroLinkLabel.TabIndex = 4;
            this.CadastroLinkLabel.TabStop = true;
            this.CadastroLinkLabel.Text = "Criar uma conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // EntrarButton
            // 
            this.EntrarButton.Location = new System.Drawing.Point(103, 148);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(75, 23);
            this.EntrarButton.TabIndex = 9;
            this.EntrarButton.Text = "Entrar";
            this.EntrarButton.UseVisualStyleBackColor = true;
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuário";
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(12, 83);
            this.SenhaTextBox.MaxLength = 255;
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.Size = new System.Drawing.Size(257, 20);
            this.SenhaTextBox.TabIndex = 8;
            this.SenhaTextBox.UseSystemPasswordChar = true;
            this.SenhaTextBox.WordWrap = false;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(12, 32);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(257, 20);
            this.UsuarioTextBox.TabIndex = 7;
            this.UsuarioTextBox.WordWrap = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 192);
            this.Controls.Add(this.CadastroLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EntrarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Name = "LoginForm";
            this.Text = "Entre com sua conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel CadastroLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EntrarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
    }
}