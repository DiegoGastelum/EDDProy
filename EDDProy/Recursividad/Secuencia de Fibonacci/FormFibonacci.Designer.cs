namespace EDDemo
{
    partial class FormFibonacci
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelOperations3 = new System.Windows.Forms.Label();
            this.labelTime3 = new System.Windows.Forms.Label();
            this.labelResult3 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(893, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOperations3
            // 
            this.labelOperations3.AutoSize = true;
            this.labelOperations3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelOperations3.Location = new System.Drawing.Point(296, 326);
            this.labelOperations3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperations3.Name = "labelOperations3";
            this.labelOperations3.Size = new System.Drawing.Size(256, 29);
            this.labelOperations3.TabIndex = 13;
            this.labelOperations3.Text = "Total de operaciones:";
            this.labelOperations3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime3
            // 
            this.labelTime3.AutoSize = true;
            this.labelTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTime3.Location = new System.Drawing.Point(296, 284);
            this.labelTime3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime3.Name = "labelTime3";
            this.labelTime3.Size = new System.Drawing.Size(255, 29);
            this.labelTime3.TabIndex = 12;
            this.labelTime3.Text = "Tiempo de ejecución:";
            this.labelTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult3
            // 
            this.labelResult3.AutoSize = true;
            this.labelResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelResult3.Location = new System.Drawing.Point(296, 241);
            this.labelResult3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult3.Name = "labelResult3";
            this.labelResult3.Size = new System.Drawing.Size(188, 29);
            this.labelResult3.TabIndex = 11;
            this.labelResult3.Text = "El resultado es:";
            this.labelResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(467, 198);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(132, 22);
            this.textBoxNumero.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(327, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(408, 150);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Ingresa un número para calcular la serie de Fibonacci";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelOperations3);
            this.Controls.Add(this.labelTime3);
            this.Controls.Add(this.labelResult3);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFibonacci";
            this.Text = "Secuencia de Fibonacci";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOperations3;
        private System.Windows.Forms.Label labelTime3;
        private System.Windows.Forms.Label labelResult3;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBox1;
    }
}