namespace WindowsFormsApp1
{
    partial class FormHanoi
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
            this.textBoxDisks = new System.Windows.Forms.TextBox();
            this.labelOperations3 = new System.Windows.Forms.Label();
            this.labelTime3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(873, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDisks
            // 
            this.textBoxDisks.Location = new System.Drawing.Point(436, 151);
            this.textBoxDisks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDisks.Name = "textBoxDisks";
            this.textBoxDisks.Size = new System.Drawing.Size(132, 22);
            this.textBoxDisks.TabIndex = 1;
            // 
            // labelOperations3
            // 
            this.labelOperations3.AutoSize = true;
            this.labelOperations3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelOperations3.Location = new System.Drawing.Point(201, 393);
            this.labelOperations3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperations3.Name = "labelOperations3";
            this.labelOperations3.Size = new System.Drawing.Size(256, 29);
            this.labelOperations3.TabIndex = 15;
            this.labelOperations3.Text = "Total de operaciones:";
            this.labelOperations3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime3
            // 
            this.labelTime3.AutoSize = true;
            this.labelTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTime3.Location = new System.Drawing.Point(201, 347);
            this.labelTime3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime3.Name = "labelTime3";
            this.labelTime3.Size = new System.Drawing.Size(255, 29);
            this.labelTime3.TabIndex = 14;
            this.labelTime3.Text = "Tiempo de ejecución:";
            this.labelTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(397, 196);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(204, 132);
            this.textBoxResult.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(299, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(428, 114);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Ingresa el número de discos.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelOperations3);
            this.Controls.Add(this.labelTime3);
            this.Controls.Add(this.textBoxDisks);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHanoi";
            this.Text = "Torre de Hanoi";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDisks;
        private System.Windows.Forms.Label labelOperations3;
        private System.Windows.Forms.Label labelTime3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBox1;
    }
}