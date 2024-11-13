
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnPodar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.btnEliminarIzquierdo = new System.Windows.Forms.Button();
            this.btnEliminarDerecho = new System.Windows.Forms.Button();
            this.lblRecorridoPostOrden1 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHojas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNodos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArbolLleno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArbolCompleto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRecorridoNiveles = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(57, 19);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 31);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(8, 284);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ReadOnly = true;
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(677, 330);
            this.txtArbol.TabIndex = 2;
            // 
            // btnPodar
            // 
            this.btnPodar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPodar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPodar.Location = new System.Drawing.Point(593, 231);
            this.btnPodar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(83, 29);
            this.btnPodar.TabIndex = 1;
            this.btnPodar.Text = "Podar";
            this.btnPodar.UseVisualStyleBackColor = false;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(593, 198);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(83, 29);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(237, 20);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(83, 28);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(8, 26);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(42, 16);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(138, 59);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 42);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(54, 66);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(80, 28);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.ValueChanged += new System.EventHandler(this.txtNodos_ValueChanged);
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(7, 167);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(0, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(100, 23);
            this.lblRecorridoPostOrden.TabIndex = 18;
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(22, 137);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(57, 16);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(11, 106);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(91, 137);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(16, 16);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "...";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(91, 106);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(16, 16);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "...";
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(337, 21);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(83, 27);
            this.bttnBuscar.TabIndex = 15;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // btnEliminarIzquierdo
            // 
            this.btnEliminarIzquierdo.Location = new System.Drawing.Point(437, 21);
            this.btnEliminarIzquierdo.Name = "btnEliminarIzquierdo";
            this.btnEliminarIzquierdo.Size = new System.Drawing.Size(109, 47);
            this.btnEliminarIzquierdo.TabIndex = 16;
            this.btnEliminarIzquierdo.Text = "Eliminar (Predecesor)";
            this.btnEliminarIzquierdo.UseVisualStyleBackColor = true;
            this.btnEliminarIzquierdo.Click += new System.EventHandler(this.btnEliminarPredecesor_Click);
            // 
            // btnEliminarDerecho
            // 
            this.btnEliminarDerecho.Location = new System.Drawing.Point(552, 21);
            this.btnEliminarDerecho.Name = "btnEliminarDerecho";
            this.btnEliminarDerecho.Size = new System.Drawing.Size(121, 47);
            this.btnEliminarDerecho.TabIndex = 17;
            this.btnEliminarDerecho.Text = "Eliminar (Sucesor)";
            this.btnEliminarDerecho.UseVisualStyleBackColor = true;
            this.btnEliminarDerecho.Click += new System.EventHandler(this.btnEliminarSucesor_Click);
            // 
            // lblRecorridoPostOrden1
            // 
            this.lblRecorridoPostOrden1.AutoSize = true;
            this.lblRecorridoPostOrden1.Location = new System.Drawing.Point(91, 167);
            this.lblRecorridoPostOrden1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden1.Name = "lblRecorridoPostOrden1";
            this.lblRecorridoPostOrden1.Size = new System.Drawing.Size(16, 16);
            this.lblRecorridoPostOrden1.TabIndex = 19;
            this.lblRecorridoPostOrden1.Text = "...";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(233, 223);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(16, 16);
            this.lblAltura.TabIndex = 20;
            this.lblAltura.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Altura:";
            // 
            // lblHojas
            // 
            this.lblHojas.AutoSize = true;
            this.lblHojas.Location = new System.Drawing.Point(131, 251);
            this.lblHojas.Name = "lblHojas";
            this.lblHojas.Size = new System.Drawing.Size(16, 16);
            this.lblHojas.TabIndex = 22;
            this.lblHojas.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cantidad de hojas:";
            // 
            // lblNodos
            // 
            this.lblNodos.AutoSize = true;
            this.lblNodos.Location = new System.Drawing.Point(91, 223);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(16, 16);
            this.lblNodos.TabIndex = 24;
            this.lblNodos.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nodos:";
            // 
            // lblArbolLleno
            // 
            this.lblArbolLleno.AutoSize = true;
            this.lblArbolLleno.Location = new System.Drawing.Point(437, 251);
            this.lblArbolLleno.Name = "lblArbolLleno";
            this.lblArbolLleno.Size = new System.Drawing.Size(16, 16);
            this.lblArbolLleno.TabIndex = 26;
            this.lblArbolLleno.Text = "...";
            this.lblArbolLleno.Click += new System.EventHandler(this.lblArbolLleno_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "¿Está lleno?";
            // 
            // lblArbolCompleto
            // 
            this.lblArbolCompleto.AutoSize = true;
            this.lblArbolCompleto.Location = new System.Drawing.Point(437, 223);
            this.lblArbolCompleto.Name = "lblArbolCompleto";
            this.lblArbolCompleto.Size = new System.Drawing.Size(16, 16);
            this.lblArbolCompleto.TabIndex = 28;
            this.lblArbolCompleto.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "¿Está completo?";
            // 
            // lblRecorridoNiveles
            // 
            this.lblRecorridoNiveles.AutoSize = true;
            this.lblRecorridoNiveles.Location = new System.Drawing.Point(91, 198);
            this.lblRecorridoNiveles.Name = "lblRecorridoNiveles";
            this.lblRecorridoNiveles.Size = new System.Drawing.Size(16, 16);
            this.lblRecorridoNiveles.TabIndex = 30;
            this.lblRecorridoNiveles.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Por Niveles:";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 620);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRecorridoNiveles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblArbolCompleto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblArbolLleno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHojas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblRecorridoPostOrden1);
            this.Controls.Add(this.btnEliminarDerecho);
            this.Controls.Add(this.btnEliminarIzquierdo);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = " ...";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button btnEliminarIzquierdo;
        private System.Windows.Forms.Button btnEliminarDerecho;
        private System.Windows.Forms.Label lblRecorridoPostOrden1;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHojas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArbolLleno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArbolCompleto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRecorridoNiveles;
        private System.Windows.Forms.Label label6;
    }
}