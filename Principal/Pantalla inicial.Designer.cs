namespace Principal
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 60);
            label1.Name = "label1";
            label1.Size = new Size(309, 43);
            label1.TabIndex = 0;
            label1.Text = "Patron de diseño";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 137);
            label2.Name = "label2";
            label2.Size = new Size(513, 25);
            label2.TabIndex = 1;
            label2.Text = "Este patron de diseño contesta unicamente al frond y al backen";
            // 
            // button1
            // 
            button1.Location = new Point(154, 224);
            button1.Name = "button1";
            button1.Size = new Size(166, 47);
            button1.TabIndex = 2;
            button1.Text = "Contabilidad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(501, 224);
            button2.Name = "button2";
            button2.Size = new Size(166, 47);
            button2.TabIndex = 3;
            button2.Text = "Orden de compra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}