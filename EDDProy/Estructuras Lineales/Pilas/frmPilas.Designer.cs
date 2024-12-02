
namespace EDDemo
{
    partial class frmPilas
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
            this.textBoxMostrarPila = new System.Windows.Forms.TextBox();
            this.textBoxInsertar = new System.Windows.Forms.TextBox();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnInsertar = new System.Windows.Forms.Button();
            this.bttnVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMostrarPila
            // 
            this.textBoxMostrarPila.Location = new System.Drawing.Point(281, 106);
            this.textBoxMostrarPila.Name = "textBoxMostrarPila";
            this.textBoxMostrarPila.Size = new System.Drawing.Size(100, 22);
            this.textBoxMostrarPila.TabIndex = 0;
            // 
            // textBoxInsertar
            // 
            this.textBoxInsertar.Location = new System.Drawing.Point(144, 106);
            this.textBoxInsertar.Name = "textBoxInsertar";
            this.textBoxInsertar.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertar.TabIndex = 1;
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(225, 134);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttnEliminar.TabIndex = 2;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnInsertar
            // 
            this.bttnInsertar.Location = new System.Drawing.Point(144, 134);
            this.bttnInsertar.Name = "bttnInsertar";
            this.bttnInsertar.Size = new System.Drawing.Size(75, 23);
            this.bttnInsertar.TabIndex = 3;
            this.bttnInsertar.Text = "Insertar";
            this.bttnInsertar.UseVisualStyleBackColor = true;
            this.bttnInsertar.Click += new System.EventHandler(this.bttnInsertar_Click);
            // 
            // bttnVaciar
            // 
            this.bttnVaciar.Location = new System.Drawing.Point(306, 134);
            this.bttnVaciar.Name = "bttnVaciar";
            this.bttnVaciar.Size = new System.Drawing.Size(75, 23);
            this.bttnVaciar.TabIndex = 4;
            this.bttnVaciar.Text = "Vaciar";
            this.bttnVaciar.UseVisualStyleBackColor = true;
            this.bttnVaciar.Click += new System.EventHandler(this.bttnVaciar_Click);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 288);
            this.Controls.Add(this.bttnVaciar);
            this.Controls.Add(this.bttnInsertar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.textBoxInsertar);
            this.Controls.Add(this.textBoxMostrarPila);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPilas";
            this.Text = "Pilas";
            this.Load += new System.EventHandler(this.frmPilas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMostrarPila;
        private System.Windows.Forms.TextBox textBoxInsertar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnInsertar;
        private System.Windows.Forms.Button bttnVaciar;
    }
}