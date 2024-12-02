namespace EDDEMO
{
    partial class FormListDoble
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
            this.textBoxListaDoble = new System.Windows.Forms.TextBox();
            this.buttonInsertarPos1 = new System.Windows.Forms.Button();
            this.buttonElimUlt1 = new System.Windows.Forms.Button();
            this.buttonBus1 = new System.Windows.Forms.Button();
            this.buttonElimPos1 = new System.Windows.Forms.Button();
            this.buttonElimPrim1 = new System.Windows.Forms.Button();
            this.buttonVaciarLista1 = new System.Windows.Forms.Button();
            this.buttonAgregar1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxBuscar1 = new System.Windows.Forms.TextBox();
            this.textBoxPosicion1 = new System.Windows.Forms.TextBox();
            this.textBoxLista1 = new System.Windows.Forms.TextBox();
            this.textBoxElemento1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxListaDoble
            // 
            this.textBoxListaDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxListaDoble.Location = new System.Drawing.Point(404, 54);
            this.textBoxListaDoble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxListaDoble.Name = "textBoxListaDoble";
            this.textBoxListaDoble.ReadOnly = true;
            this.textBoxListaDoble.Size = new System.Drawing.Size(259, 55);
            this.textBoxListaDoble.TabIndex = 14;
            this.textBoxListaDoble.Text = "Lista Doble";
            this.textBoxListaDoble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxListaDoble.TextChanged += new System.EventHandler(this.textBoxListaDoble_TextChanged);
            // 
            // buttonInsertarPos1
            // 
            this.buttonInsertarPos1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsertarPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonInsertarPos1.Location = new System.Drawing.Point(644, 204);
            this.buttonInsertarPos1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInsertarPos1.Name = "buttonInsertarPos1";
            this.buttonInsertarPos1.Size = new System.Drawing.Size(192, 54);
            this.buttonInsertarPos1.TabIndex = 35;
            this.buttonInsertarPos1.Text = "Insertar en Posición";
            this.buttonInsertarPos1.UseVisualStyleBackColor = false;
            this.buttonInsertarPos1.Click += new System.EventHandler(this.buttonInsertarPos1_Click);
            // 
            // buttonElimUlt1
            // 
            this.buttonElimUlt1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonElimUlt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonElimUlt1.Location = new System.Drawing.Point(437, 265);
            this.buttonElimUlt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonElimUlt1.Name = "buttonElimUlt1";
            this.buttonElimUlt1.Size = new System.Drawing.Size(192, 54);
            this.buttonElimUlt1.TabIndex = 34;
            this.buttonElimUlt1.Text = "Eliminar Último";
            this.buttonElimUlt1.UseVisualStyleBackColor = false;
            this.buttonElimUlt1.Click += new System.EventHandler(this.buttonElimUlt1_Click_1);
            // 
            // buttonBus1
            // 
            this.buttonBus1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBus1.Location = new System.Drawing.Point(844, 202);
            this.buttonBus1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBus1.Name = "buttonBus1";
            this.buttonBus1.Size = new System.Drawing.Size(192, 54);
            this.buttonBus1.TabIndex = 33;
            this.buttonBus1.Text = "Buscar";
            this.buttonBus1.UseVisualStyleBackColor = false;
            this.buttonBus1.Click += new System.EventHandler(this.buttonBus1_Click);
            // 
            // buttonElimPos1
            // 
            this.buttonElimPos1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonElimPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonElimPos1.Location = new System.Drawing.Point(644, 266);
            this.buttonElimPos1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonElimPos1.Name = "buttonElimPos1";
            this.buttonElimPos1.Size = new System.Drawing.Size(192, 54);
            this.buttonElimPos1.TabIndex = 32;
            this.buttonElimPos1.Text = "Eliminar en Posición";
            this.buttonElimPos1.UseVisualStyleBackColor = false;
            this.buttonElimPos1.Click += new System.EventHandler(this.buttonElimPos1_Click_1);
            // 
            // buttonElimPrim1
            // 
            this.buttonElimPrim1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonElimPrim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonElimPrim1.Location = new System.Drawing.Point(437, 203);
            this.buttonElimPrim1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonElimPrim1.Name = "buttonElimPrim1";
            this.buttonElimPrim1.Size = new System.Drawing.Size(192, 54);
            this.buttonElimPrim1.TabIndex = 31;
            this.buttonElimPrim1.Text = "Eliminar Primero";
            this.buttonElimPrim1.UseVisualStyleBackColor = false;
            this.buttonElimPrim1.Click += new System.EventHandler(this.buttonElimPrim1_Click);
            // 
            // buttonVaciarLista1
            // 
            this.buttonVaciarLista1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVaciarLista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonVaciarLista1.Location = new System.Drawing.Point(237, 203);
            this.buttonVaciarLista1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVaciarLista1.Name = "buttonVaciarLista1";
            this.buttonVaciarLista1.Size = new System.Drawing.Size(192, 54);
            this.buttonVaciarLista1.TabIndex = 30;
            this.buttonVaciarLista1.Text = "Vaciar Lista";
            this.buttonVaciarLista1.UseVisualStyleBackColor = false;
            this.buttonVaciarLista1.Click += new System.EventHandler(this.buttonVaciarLista1_Click_1);
            // 
            // buttonAgregar1
            // 
            this.buttonAgregar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAgregar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAgregar1.Location = new System.Drawing.Point(37, 203);
            this.buttonAgregar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAgregar1.Name = "buttonAgregar1";
            this.buttonAgregar1.Size = new System.Drawing.Size(192, 54);
            this.buttonAgregar1.TabIndex = 29;
            this.buttonAgregar1.Text = "Insertar";
            this.buttonAgregar1.UseVisualStyleBackColor = false;
            this.buttonAgregar1.Click += new System.EventHandler(this.buttonAgregar1_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox4.Location = new System.Drawing.Point(879, 127);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 29);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "Buscar";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox3.Location = new System.Drawing.Point(685, 127);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 29);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "Posición";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(275, 128);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 29);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "Lista";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(72, 128);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 29);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Elemento";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBuscar1
            // 
            this.textBoxBuscar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar1.Location = new System.Drawing.Point(844, 162);
            this.textBoxBuscar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBuscar1.Name = "textBoxBuscar1";
            this.textBoxBuscar1.Size = new System.Drawing.Size(191, 30);
            this.textBoxBuscar1.TabIndex = 24;
            // 
            // textBoxPosicion1
            // 
            this.textBoxPosicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPosicion1.Location = new System.Drawing.Point(644, 162);
            this.textBoxPosicion1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPosicion1.Name = "textBoxPosicion1";
            this.textBoxPosicion1.Size = new System.Drawing.Size(191, 30);
            this.textBoxPosicion1.TabIndex = 23;
            // 
            // textBoxLista1
            // 
            this.textBoxLista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLista1.Location = new System.Drawing.Point(237, 164);
            this.textBoxLista1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLista1.Name = "textBoxLista1";
            this.textBoxLista1.ReadOnly = true;
            this.textBoxLista1.Size = new System.Drawing.Size(191, 30);
            this.textBoxLista1.TabIndex = 22;
            // 
            // textBoxElemento1
            // 
            this.textBoxElemento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxElemento1.Location = new System.Drawing.Point(37, 164);
            this.textBoxElemento1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxElemento1.Name = "textBoxElemento1";
            this.textBoxElemento1.Size = new System.Drawing.Size(191, 30);
            this.textBoxElemento1.TabIndex = 21;
            // 
            // FormListDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonInsertarPos1);
            this.Controls.Add(this.buttonElimUlt1);
            this.Controls.Add(this.buttonBus1);
            this.Controls.Add(this.buttonElimPos1);
            this.Controls.Add(this.buttonElimPrim1);
            this.Controls.Add(this.buttonVaciarLista1);
            this.Controls.Add(this.buttonAgregar1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxBuscar1);
            this.Controls.Add(this.textBoxPosicion1);
            this.Controls.Add(this.textBoxLista1);
            this.Controls.Add(this.textBoxElemento1);
            this.Controls.Add(this.textBoxListaDoble);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormListDoble";
            this.Text = "Lista Doble";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxListaDoble;
        private System.Windows.Forms.Button buttonInsertarPos1;
        private System.Windows.Forms.Button buttonElimUlt1;
        private System.Windows.Forms.Button buttonBus1;
        private System.Windows.Forms.Button buttonElimPos1;
        private System.Windows.Forms.Button buttonElimPrim1;
        private System.Windows.Forms.Button buttonVaciarLista1;
        private System.Windows.Forms.Button buttonAgregar1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxBuscar1;
        private System.Windows.Forms.TextBox textBoxPosicion1;
        private System.Windows.Forms.TextBox textBoxLista1;
        private System.Windows.Forms.TextBox textBoxElemento1;
    }
}