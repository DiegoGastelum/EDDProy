namespace EDDEMO
{
    partial class FormColas
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
            this.btnInsertar1 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnVaciar1 = new System.Windows.Forms.Button();
            this.textBoxMostrarPila1 = new System.Windows.Forms.TextBox();
            this.textBoxInsertar1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInsertar1
            // 
            this.btnInsertar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnInsertar1.Location = new System.Drawing.Point(96, 290);
            this.btnInsertar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertar1.Name = "btnInsertar1";
            this.btnInsertar1.Size = new System.Drawing.Size(267, 87);
            this.btnInsertar1.TabIndex = 1;
            this.btnInsertar1.Text = "Insertar";
            this.btnInsertar1.UseVisualStyleBackColor = false;
            this.btnInsertar1.Click += new System.EventHandler(this.btnInsertar1_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEliminar1.Location = new System.Drawing.Point(400, 290);
            this.btnEliminar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(267, 87);
            this.btnEliminar1.TabIndex = 2;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = false;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnVaciar1
            // 
            this.btnVaciar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVaciar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnVaciar1.Location = new System.Drawing.Point(704, 290);
            this.btnVaciar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVaciar1.Name = "btnVaciar1";
            this.btnVaciar1.Size = new System.Drawing.Size(267, 87);
            this.btnVaciar1.TabIndex = 3;
            this.btnVaciar1.Text = "Vaciar";
            this.btnVaciar1.UseVisualStyleBackColor = false;
            this.btnVaciar1.Click += new System.EventHandler(this.btnVaciar1_Click);
            // 
            // textBoxMostrarPila1
            // 
            this.textBoxMostrarPila1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMostrarPila1.Location = new System.Drawing.Point(563, 223);
            this.textBoxMostrarPila1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMostrarPila1.Name = "textBoxMostrarPila1";
            this.textBoxMostrarPila1.ReadOnly = true;
            this.textBoxMostrarPila1.Size = new System.Drawing.Size(272, 30);
            this.textBoxMostrarPila1.TabIndex = 4;
            this.textBoxMostrarPila1.TextChanged += new System.EventHandler(this.textBoxMostrarPila1_TextChanged);
            // 
            // textBoxInsertar1
            // 
            this.textBoxInsertar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxInsertar1.Location = new System.Drawing.Point(244, 223);
            this.textBoxInsertar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInsertar1.Name = "textBoxInsertar1";
            this.textBoxInsertar1.Size = new System.Drawing.Size(272, 30);
            this.textBoxInsertar1.TabIndex = 5;
            this.textBoxInsertar1.TextChanged += new System.EventHandler(this.textBoxInsertar1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(479, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 55);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Cola";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(312, 187);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 29);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Elemento";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox3.Location = new System.Drawing.Point(636, 187);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 29);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Cola";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FormColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxInsertar1);
            this.Controls.Add(this.textBoxMostrarPila1);
            this.Controls.Add(this.btnVaciar1);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnInsertar1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormColas";
            this.Text = "Colas";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnVaciar1;
        private System.Windows.Forms.TextBox textBoxMostrarPila1;
        private System.Windows.Forms.TextBox textBoxInsertar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}