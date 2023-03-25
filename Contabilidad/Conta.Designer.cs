namespace Contabilidad
{
    partial class Conta
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
            NombreConta = new TextBox();
            DepartamentoConta = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 60);
            label1.Name = "label1";
            label1.Size = new Size(235, 43);
            label1.TabIndex = 0;
            label1.Text = "Contabilidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 143);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 208);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 2;
            label3.Text = "Departamento";
            // 
            // NombreConta
            // 
            NombreConta.Location = new Point(192, 133);
            NombreConta.Name = "NombreConta";
            NombreConta.Size = new Size(480, 31);
            NombreConta.TabIndex = 3;
            // 
            // DepartamentoConta
            // 
            DepartamentoConta.Location = new Point(192, 202);
            DepartamentoConta.Name = "DepartamentoConta";
            DepartamentoConta.Size = new Size(480, 31);
            DepartamentoConta.TabIndex = 4;
            DepartamentoConta.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(280, 295);
            button1.Name = "button1";
            button1.Size = new Size(200, 75);
            button1.TabIndex = 5;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Conta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(DepartamentoConta);
            Controls.Add(NombreConta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Conta";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NombreConta;
        private TextBox DepartamentoConta;
        private Button button1;
    }
}