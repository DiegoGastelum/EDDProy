namespace EDDemo
{
    partial class FormSumarElementos
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
            this.labelOperations2 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.labelResult2 = new System.Windows.Forms.Label();
            this.buttonSumTailRecursive = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelOperations2
            // 
            this.labelOperations2.AutoSize = true;
            this.labelOperations2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelOperations2.Location = new System.Drawing.Point(299, 331);
            this.labelOperations2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperations2.Name = "labelOperations2";
            this.labelOperations2.Size = new System.Drawing.Size(256, 29);
            this.labelOperations2.TabIndex = 10;
            this.labelOperations2.Text = "Total de operaciones:";
            this.labelOperations2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTime2.Location = new System.Drawing.Point(299, 289);
            this.labelTime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(255, 29);
            this.labelTime2.TabIndex = 9;
            this.labelTime2.Text = "Tiempo de ejecución:";
            this.labelTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult2
            // 
            this.labelResult2.AutoSize = true;
            this.labelResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelResult2.Location = new System.Drawing.Point(299, 246);
            this.labelResult2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult2.Name = "labelResult2";
            this.labelResult2.Size = new System.Drawing.Size(188, 29);
            this.labelResult2.TabIndex = 8;
            this.labelResult2.Text = "El resultado es:";
            this.labelResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSumTailRecursive
            // 
            this.buttonSumTailRecursive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSumTailRecursive.Location = new System.Drawing.Point(903, 478);
            this.buttonSumTailRecursive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSumTailRecursive.Name = "buttonSumTailRecursive";
            this.buttonSumTailRecursive.Size = new System.Drawing.Size(148, 62);
            this.buttonSumTailRecursive.TabIndex = 11;
            this.buttonSumTailRecursive.Text = "Calcular";
            this.buttonSumTailRecursive.UseVisualStyleBackColor = true;
            this.buttonSumTailRecursive.Click += new System.EventHandler(this.buttonSumTailRecursive_Click_1);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(471, 193);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(132, 22);
            this.textBoxInput.TabIndex = 12;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1.Location = new System.Drawing.Point(319, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(435, 154);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Inserta todos los elementos del arreglo para sumarlos (solo números y separados p" +
    "or comas).";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormSumarElementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonSumTailRecursive);
            this.Controls.Add(this.labelOperations2);
            this.Controls.Add(this.labelTime2);
            this.Controls.Add(this.labelResult2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSumarElementos";
            this.Text = "Sumar elementos";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOperations2;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label labelResult2;
        private System.Windows.Forms.Button buttonSumTailRecursive;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBox1;
    }
}