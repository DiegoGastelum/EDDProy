namespace WindowsFormsApp1
{
    partial class FormExponente
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
            this.buttonCalculate1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBase = new System.Windows.Forms.TextBox();
            this.textExponent = new System.Windows.Forms.TextBox();
            this.labelOperations1 = new System.Windows.Forms.Label();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelResult1 = new System.Windows.Forms.Label();
            this.Ing1 = new System.Windows.Forms.TextBox();
            this.Ing2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalculate1
            // 
            this.buttonCalculate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCalculate1.Location = new System.Drawing.Point(909, 478);
            this.buttonCalculate1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalculate1.Name = "buttonCalculate1";
            this.buttonCalculate1.Size = new System.Drawing.Size(141, 62);
            this.buttonCalculate1.TabIndex = 0;
            this.buttonCalculate1.Text = "Calcular";
            this.buttonCalculate1.UseVisualStyleBackColor = true;
            this.buttonCalculate1.Click += new System.EventHandler(this.buttonCalculate1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(275, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(549, 118);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Ingresa un número y un exponente para calcularlo.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBase
            // 
            this.textBase.Location = new System.Drawing.Point(472, 203);
            this.textBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBase.Name = "textBase";
            this.textBase.Size = new System.Drawing.Size(132, 22);
            this.textBase.TabIndex = 2;
            // 
            // textExponent
            // 
            this.textExponent.Location = new System.Drawing.Point(472, 263);
            this.textExponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textExponent.Name = "textExponent";
            this.textExponent.Size = new System.Drawing.Size(132, 22);
            this.textExponent.TabIndex = 3;
            this.textExponent.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelOperations1
            // 
            this.labelOperations1.AutoSize = true;
            this.labelOperations1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelOperations1.Location = new System.Drawing.Point(289, 388);
            this.labelOperations1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperations1.Name = "labelOperations1";
            this.labelOperations1.Size = new System.Drawing.Size(256, 29);
            this.labelOperations1.TabIndex = 7;
            this.labelOperations1.Text = "Total de operaciones:";
            this.labelOperations1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTime1.Location = new System.Drawing.Point(289, 346);
            this.labelTime1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(255, 29);
            this.labelTime1.TabIndex = 6;
            this.labelTime1.Text = "Tiempo de ejecución:";
            this.labelTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult1
            // 
            this.labelResult1.AutoSize = true;
            this.labelResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelResult1.Location = new System.Drawing.Point(289, 303);
            this.labelResult1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult1.Name = "labelResult1";
            this.labelResult1.Size = new System.Drawing.Size(188, 29);
            this.labelResult1.TabIndex = 5;
            this.labelResult1.Text = "El resultado es:";
            this.labelResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ing1
            // 
            this.Ing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ing1.Location = new System.Drawing.Point(441, 167);
            this.Ing1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ing1.Name = "Ing1";
            this.Ing1.ReadOnly = true;
            this.Ing1.Size = new System.Drawing.Size(204, 26);
            this.Ing1.TabIndex = 8;
            this.Ing1.Text = "Ingresa el número";
            this.Ing1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ing1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Ing2
            // 
            this.Ing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ing2.Location = new System.Drawing.Point(441, 231);
            this.Ing2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ing2.Name = "Ing2";
            this.Ing2.ReadOnly = true;
            this.Ing2.Size = new System.Drawing.Size(204, 26);
            this.Ing2.TabIndex = 9;
            this.Ing2.Text = "Ingresa el exponente";
            this.Ing2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormExponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Ing2);
            this.Controls.Add(this.Ing1);
            this.Controls.Add(this.labelOperations1);
            this.Controls.Add(this.labelTime1);
            this.Controls.Add(this.labelResult1);
            this.Controls.Add(this.textExponent);
            this.Controls.Add(this.textBase);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCalculate1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormExponente";
            this.Text = "Exponente";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.TextBox textExponent;
        private System.Windows.Forms.Label labelOperations1;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelResult1;
        private System.Windows.Forms.TextBox Ing1;
        private System.Windows.Forms.TextBox Ing2;
    }
}