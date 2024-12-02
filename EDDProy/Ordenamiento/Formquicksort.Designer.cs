namespace QuickSortApp
{
    partial class Formquicksort
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
            this.lblArregloOrdenado = new System.Windows.Forms.Label();
            this.lblArregloOriginal = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtArregloManual = new System.Windows.Forms.TextBox();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArregloOrdenado
            // 
            this.lblArregloOrdenado.AutoSize = true;
            this.lblArregloOrdenado.Location = new System.Drawing.Point(132, 195);
            this.lblArregloOrdenado.Name = "lblArregloOrdenado";
            this.lblArregloOrdenado.Size = new System.Drawing.Size(16, 16);
            this.lblArregloOrdenado.TabIndex = 0;
            this.lblArregloOrdenado.Text = "...";
            // 
            // lblArregloOriginal
            // 
            this.lblArregloOriginal.AutoSize = true;
            this.lblArregloOriginal.Location = new System.Drawing.Point(132, 166);
            this.lblArregloOriginal.Name = "lblArregloOriginal";
            this.lblArregloOriginal.Size = new System.Drawing.Size(16, 16);
            this.lblArregloOriginal.TabIndex = 1;
            this.lblArregloOriginal.Text = "...";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(378, 321);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(183, 73);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Aleatorio";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(567, 321);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(183, 73);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(302, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 40);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Quicksort";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArregloManual
            // 
            this.txtArregloManual.Location = new System.Drawing.Point(150, 131);
            this.txtArregloManual.Name = "txtArregloManual";
            this.txtArregloManual.Size = new System.Drawing.Size(555, 22);
            this.txtArregloManual.TabIndex = 5;
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(23, 195);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(118, 16);
            this.lblOrdenado.TabIndex = 6;
            this.lblOrdenado.Text = "Arreglo Ordenado:";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(23, 166);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(103, 16);
            this.lblOriginal.TabIndex = 7;
            this.lblOriginal.Text = "Arreglo Original:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingresa el arreglo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(23, 378);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(137, 16);
            this.lbltime.TabIndex = 9;
            this.lbltime.Text = "Tiempo de ejecución:";
            // 
            // Formquicksort
            // 
            this.ClientSize = new System.Drawing.Size(762, 424);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.txtArregloManual);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblArregloOriginal);
            this.Controls.Add(this.lblArregloOrdenado);
            this.Name = "Formquicksort";
            this.Text = "Quicksort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArregloOrdenado;
        private System.Windows.Forms.Label lblArregloOriginal;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtArregloManual;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltime;
    }
}