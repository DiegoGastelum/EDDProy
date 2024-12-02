namespace EDDemo
{
    partial class FormBusqBinaria
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
            this.labelOperations4 = new System.Windows.Forms.Label();
            this.labelTime4 = new System.Windows.Forms.Label();
            this.labelResult4 = new System.Windows.Forms.Label();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(887, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encontrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOperations4
            // 
            this.labelOperations4.AutoSize = true;
            this.labelOperations4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelOperations4.Location = new System.Drawing.Point(296, 345);
            this.labelOperations4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperations4.Name = "labelOperations4";
            this.labelOperations4.Size = new System.Drawing.Size(256, 29);
            this.labelOperations4.TabIndex = 16;
            this.labelOperations4.Text = "Total de operaciones:";
            this.labelOperations4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime4
            // 
            this.labelTime4.AutoSize = true;
            this.labelTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTime4.Location = new System.Drawing.Point(296, 303);
            this.labelTime4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime4.Name = "labelTime4";
            this.labelTime4.Size = new System.Drawing.Size(255, 29);
            this.labelTime4.TabIndex = 15;
            this.labelTime4.Text = "Tiempo de ejecución:";
            this.labelTime4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult4
            // 
            this.labelResult4.AutoSize = true;
            this.labelResult4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelResult4.Location = new System.Drawing.Point(296, 260);
            this.labelResult4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult4.Name = "labelResult4";
            this.labelResult4.Size = new System.Drawing.Size(188, 29);
            this.labelResult4.TabIndex = 14;
            this.labelResult4.Text = "El resultado es:";
            this.labelResult4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Location = new System.Drawing.Point(431, 214);
            this.textBoxSearchValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(132, 22);
            this.textBoxSearchValue.TabIndex = 17;
            this.textBoxSearchValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxArray
            // 
            this.textBoxArray.Location = new System.Drawing.Point(431, 182);
            this.textBoxArray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(132, 22);
            this.textBoxArray.TabIndex = 18;
            this.textBoxArray.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(325, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(357, 147);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Ingresa un arreglo y luego el número a encontrar.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // FormBusqBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.textBoxSearchValue);
            this.Controls.Add(this.labelOperations4);
            this.Controls.Add(this.labelTime4);
            this.Controls.Add(this.labelResult4);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBusqBinaria";
            this.Text = "Búsqueda Binaria";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOperations4;
        private System.Windows.Forms.Label labelTime4;
        private System.Windows.Forms.Label labelResult4;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.TextBox textBoxArray;
        private System.Windows.Forms.TextBox textBox1;
    }
}