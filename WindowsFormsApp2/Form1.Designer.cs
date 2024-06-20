namespace WindowsFormsApp2
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
            this.tabuadaLabel = new System.Windows.Forms.Label();
            this.tabuadaTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tabuadaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tabuadaLabel
            // 
            this.tabuadaLabel.AutoSize = true;
            this.tabuadaLabel.Location = new System.Drawing.Point(59, 49);
            this.tabuadaLabel.Name = "tabuadaLabel";
            this.tabuadaLabel.Size = new System.Drawing.Size(134, 13);
            this.tabuadaLabel.TabIndex = 0;
            this.tabuadaLabel.Text = "Digite a tabuada desejada:";
            // 
            // tabuadaTextBox
            // 
            this.tabuadaTextBox.Location = new System.Drawing.Point(199, 46);
            this.tabuadaTextBox.Name = "tabuadaTextBox";
            this.tabuadaTextBox.Size = new System.Drawing.Size(35, 20);
            this.tabuadaTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(254, 44);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(47, 22);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tabuadaListBox
            // 
            this.tabuadaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabuadaListBox.FormattingEnabled = true;
            this.tabuadaListBox.ItemHeight = 16;
            this.tabuadaListBox.Location = new System.Drawing.Point(118, 87);
            this.tabuadaListBox.Name = "tabuadaListBox";
            this.tabuadaListBox.Size = new System.Drawing.Size(142, 228);
            this.tabuadaListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 371);
            this.Controls.Add(this.tabuadaListBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tabuadaTextBox);
            this.Controls.Add(this.tabuadaLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tabuadaLabel;
        private System.Windows.Forms.TextBox tabuadaTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox tabuadaListBox;
    }
}

