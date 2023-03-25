namespace OC
{
    partial class OrdendeCompra
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
            NombreOc = new TextBox();
            DepartamentoOc = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(245, 54);
            label1.Name = "label1";
            label1.Size = new Size(298, 41);
            label1.TabIndex = 0;
            label1.Text = "Orden de compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 156);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 216);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 2;
            label3.Text = "Departamento";
            // 
            // NombreOc
            // 
            NombreOc.Location = new Point(180, 146);
            NombreOc.Name = "NombreOc";
            NombreOc.Size = new Size(504, 31);
            NombreOc.TabIndex = 3;
            NombreOc.TextChanged += NombreOc_TextChanged;
            // 
            // DepartamentoOc
            // 
            DepartamentoOc.Location = new Point(180, 210);
            DepartamentoOc.Name = "DepartamentoOc";
            DepartamentoOc.Size = new Size(504, 31);
            DepartamentoOc.TabIndex = 4;
            DepartamentoOc.TextChanged += DepartamentoOc_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(268, 300);
            button1.Name = "button1";
            button1.Size = new Size(241, 101);
            button1.TabIndex = 5;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OrdendeCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(DepartamentoOc);
            Controls.Add(NombreOc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrdendeCompra";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NombreOc;
        private TextBox DepartamentoOc;
        private Button button1;
    }
}