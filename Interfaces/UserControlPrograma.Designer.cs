namespace Microondas
{
    partial class UserControlPrograma
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.TempoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AlimentoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InstrucoesTextBox = new System.Windows.Forms.TextBox();
            this.PotenciaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ButtonIniciar = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Enabled = false;
            this.NomeTextBox.Location = new System.Drawing.Point(65, 12);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(216, 20);
            this.NomeTextBox.TabIndex = 1;
            // 
            // TempoMaskedTextBox
            // 
            this.TempoMaskedTextBox.Enabled = false;
            this.TempoMaskedTextBox.Location = new System.Drawing.Point(65, 78);
            this.TempoMaskedTextBox.Mask = "00:00";
            this.TempoMaskedTextBox.Name = "TempoMaskedTextBox";
            this.TempoMaskedTextBox.Size = new System.Drawing.Size(37, 20);
            this.TempoMaskedTextBox.TabIndex = 3;
            // 
            // AlimentoTextBox
            // 
            this.AlimentoTextBox.Enabled = false;
            this.AlimentoTextBox.Location = new System.Drawing.Point(65, 45);
            this.AlimentoTextBox.Name = "AlimentoTextBox";
            this.AlimentoTextBox.Size = new System.Drawing.Size(216, 20);
            this.AlimentoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Potência";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Instruções";
            // 
            // InstrucoesTextBox
            // 
            this.InstrucoesTextBox.Enabled = false;
            this.InstrucoesTextBox.Location = new System.Drawing.Point(65, 111);
            this.InstrucoesTextBox.Multiline = true;
            this.InstrucoesTextBox.Name = "InstrucoesTextBox";
            this.InstrucoesTextBox.Size = new System.Drawing.Size(216, 38);
            this.InstrucoesTextBox.TabIndex = 5;
            // 
            // PotenciaMaskedTextBox
            // 
            this.PotenciaMaskedTextBox.Enabled = false;
            this.PotenciaMaskedTextBox.Location = new System.Drawing.Point(180, 78);
            this.PotenciaMaskedTextBox.Mask = "00 kW";
            this.PotenciaMaskedTextBox.Name = "PotenciaMaskedTextBox";
            this.PotenciaMaskedTextBox.Size = new System.Drawing.Size(45, 20);
            this.PotenciaMaskedTextBox.TabIndex = 4;
            // 
            // ButtonIniciar
            // 
            this.ButtonIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonIniciar.Image = global::Microondas.Properties.Resources.iniciar;
            this.ButtonIniciar.Location = new System.Drawing.Point(295, 17);
            this.ButtonIniciar.Name = "ButtonIniciar";
            this.ButtonIniciar.Size = new System.Drawing.Size(27, 25);
            this.ButtonIniciar.TabIndex = 9;
            this.ButtonIniciar.UseVisualStyleBackColor = true;
            this.ButtonIniciar.Click += new System.EventHandler(this.ButtonIniciar_Click);
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcluirButton.Image = global::Microondas.Properties.Resources.deletar;
            this.ExcluirButton.Location = new System.Drawing.Point(295, 114);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(27, 26);
            this.ExcluirButton.TabIndex = 8;
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // SalvarButton
            // 
            this.SalvarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvarButton.Image = global::Microondas.Properties.Resources.salvar;
            this.SalvarButton.Location = new System.Drawing.Point(295, 88);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(27, 27);
            this.SalvarButton.TabIndex = 7;
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarButton.Image = global::Microondas.Properties.Resources.editar;
            this.EditarButton.Location = new System.Drawing.Point(295, 64);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(27, 25);
            this.EditarButton.TabIndex = 6;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // UserControlPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.ButtonIniciar);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.PotenciaMaskedTextBox);
            this.Controls.Add(this.InstrucoesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlimentoTextBox);
            this.Controls.Add(this.TempoMaskedTextBox);
            this.Controls.Add(this.NomeTextBox);
            this.Name = "UserControlPrograma";
            this.Size = new System.Drawing.Size(327, 161);
            this.Load += new System.EventHandler(this.UserControlPrograma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.MaskedTextBox TempoMaskedTextBox;
        private System.Windows.Forms.TextBox AlimentoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InstrucoesTextBox;
        private System.Windows.Forms.MaskedTextBox PotenciaMaskedTextBox;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Button ButtonIniciar;
    }
}
