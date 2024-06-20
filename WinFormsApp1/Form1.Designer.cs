namespace WinFormsApp1
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
            numero1Label = new Label();
            numero2Label = new Label();
            numero1TextBox = new TextBox();
            numero2TextBox = new TextBox();
            somarButton = new Button();
            subtrairButton = new Button();
            multiplicarButton = new Button();
            dividirButton = new Button();
            respostaLabel = new Label();
            valorRespostaLabel = new Label();
            SuspendLayout();
            // 
            // numero1Label
            // 
            numero1Label.AutoSize = true;
            numero1Label.Location = new Point(53, 31);
            numero1Label.Name = "numero1Label";
            numero1Label.Size = new Size(67, 17);
            numero1Label.TabIndex = 0;
            numero1Label.Text = "Número 1";
            // 
            // numero2Label
            // 
            numero2Label.AutoSize = true;
            numero2Label.Location = new Point(53, 77);
            numero2Label.Name = "numero2Label";
            numero2Label.Size = new Size(67, 17);
            numero2Label.TabIndex = 1;
            numero2Label.Text = "Número 2";
            // 
            // numero1TextBox
            // 
            numero1TextBox.Location = new Point(137, 28);
            numero1TextBox.Name = "numero1TextBox";
            numero1TextBox.Size = new Size(100, 25);
            numero1TextBox.TabIndex = 2;
            // 
            // numero2TextBox
            // 
            numero2TextBox.Location = new Point(137, 77);
            numero2TextBox.Name = "numero2TextBox";
            numero2TextBox.Size = new Size(100, 25);
            numero2TextBox.TabIndex = 3;
            // 
            // somarButton
            // 
            somarButton.Location = new Point(24, 139);
            somarButton.Name = "somarButton";
            somarButton.Size = new Size(83, 32);
            somarButton.TabIndex = 4;
            somarButton.Text = "Somar";
            somarButton.UseVisualStyleBackColor = true;
            somarButton.Click += somarButton_Click;
            // 
            // subtrairButton
            // 
            subtrairButton.Location = new Point(113, 139);
            subtrairButton.Name = "subtrairButton";
            subtrairButton.Size = new Size(83, 32);
            subtrairButton.TabIndex = 5;
            subtrairButton.Text = "Subtrair";
            subtrairButton.UseVisualStyleBackColor = true;
            subtrairButton.Click += subtrairButton_Click;
            // 
            // multiplicarButton
            // 
            multiplicarButton.Location = new Point(202, 139);
            multiplicarButton.Name = "multiplicarButton";
            multiplicarButton.Size = new Size(83, 32);
            multiplicarButton.TabIndex = 6;
            multiplicarButton.Text = "Multiplicar";
            multiplicarButton.UseVisualStyleBackColor = true;
            multiplicarButton.Click += multiplicarButton_Click;
            // 
            // dividirButton
            // 
            dividirButton.Location = new Point(291, 139);
            dividirButton.Name = "dividirButton";
            dividirButton.Size = new Size(84, 32);
            dividirButton.TabIndex = 7;
            dividirButton.Text = "Dividir";
            dividirButton.UseVisualStyleBackColor = true;
            dividirButton.Click += dividirButton_Click;
            // 
            // respostaLabel
            // 
            respostaLabel.AutoSize = true;
            respostaLabel.Location = new Point(32, 239);
            respostaLabel.Name = "respostaLabel";
            respostaLabel.Size = new Size(65, 17);
            respostaLabel.TabIndex = 8;
            respostaLabel.Text = "Resposta:";
            // 
            // valorRespostaLabel
            // 
            valorRespostaLabel.AutoSize = true;
            valorRespostaLabel.Location = new Point(105, 239);
            valorRespostaLabel.Name = "valorRespostaLabel";
            valorRespostaLabel.Size = new Size(15, 17);
            valorRespostaLabel.TabIndex = 9;
            valorRespostaLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 294);
            Controls.Add(valorRespostaLabel);
            Controls.Add(respostaLabel);
            Controls.Add(dividirButton);
            Controls.Add(multiplicarButton);
            Controls.Add(subtrairButton);
            Controls.Add(somarButton);
            Controls.Add(numero2TextBox);
            Controls.Add(numero1TextBox);
            Controls.Add(numero2Label);
            Controls.Add(numero1Label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numero1Label;
        private Label numero2Label;
        private TextBox numero1TextBox;
        private TextBox numero2TextBox;
        private Button somarButton;
        private Button subtrairButton;
        private Button multiplicarButton;
        private Button dividirButton;
        private Label respostaLabel;
        private Label valorRespostaLabel;
    }
}
