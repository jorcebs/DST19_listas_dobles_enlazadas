﻿namespace Inventario
{
    partial class Form1
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
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarFinal = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnReporteInverso = new System.Windows.Forms.Button();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnEliminarÚltimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(73, 12);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(133, 22);
            this.txtCódigo.TabIndex = 0;
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(212, 10);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(315, 140);
            this.txtReporte.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(83, 68);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(68, 96);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio:";
            // 
            // btnAgregarFinal
            // 
            this.btnAgregarFinal.AutoSize = true;
            this.btnAgregarFinal.Location = new System.Drawing.Point(15, 156);
            this.btnAgregarFinal.Name = "btnAgregarFinal";
            this.btnAgregarFinal.Size = new System.Drawing.Size(108, 26);
            this.btnAgregarFinal.TabIndex = 6;
            this.btnAgregarFinal.Text = "Agregar al final";
            this.btnAgregarFinal.UseVisualStyleBackColor = true;
            this.btnAgregarFinal.Click += new System.EventHandler(this.btnAgregarFinal_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Location = new System.Drawing.Point(129, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 26);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(136, 124);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 26);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.AutoSize = true;
            this.btnInsertar.Location = new System.Drawing.Point(126, 188);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(80, 26);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Posición:";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(82, 190);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(38, 22);
            this.txtPos.TabIndex = 8;
            // 
            // btnReporte
            // 
            this.btnReporte.AutoSize = true;
            this.btnReporte.Location = new System.Drawing.Point(212, 188);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(153, 26);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.AutoSize = true;
            this.btnAgregarInicio.Location = new System.Drawing.Point(15, 124);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(115, 26);
            this.btnAgregarInicio.TabIndex = 4;
            this.btnAgregarInicio.Text = "Agregar al inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnReporteInverso
            // 
            this.btnReporteInverso.AutoSize = true;
            this.btnReporteInverso.Location = new System.Drawing.Point(371, 188);
            this.btnReporteInverso.Name = "btnReporteInverso";
            this.btnReporteInverso.Size = new System.Drawing.Size(156, 26);
            this.btnReporteInverso.TabIndex = 15;
            this.btnReporteInverso.Text = "Reporte inverso";
            this.btnReporteInverso.UseVisualStyleBackColor = true;
            this.btnReporteInverso.Click += new System.EventHandler(this.btnReporteInverso_Click);
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.AutoSize = true;
            this.btnEliminarPrimero.Location = new System.Drawing.Point(212, 156);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(153, 26);
            this.btnEliminarPrimero.TabIndex = 16;
            this.btnEliminarPrimero.Text = "Eliminar primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // btnEliminarÚltimo
            // 
            this.btnEliminarÚltimo.AutoSize = true;
            this.btnEliminarÚltimo.Location = new System.Drawing.Point(371, 156);
            this.btnEliminarÚltimo.Name = "btnEliminarÚltimo";
            this.btnEliminarÚltimo.Size = new System.Drawing.Size(156, 26);
            this.btnEliminarÚltimo.TabIndex = 17;
            this.btnEliminarÚltimo.Text = "Eliminar último";
            this.btnEliminarÚltimo.UseVisualStyleBackColor = true;
            this.btnEliminarÚltimo.Click += new System.EventHandler(this.btnEliminarÚltimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 223);
            this.Controls.Add(this.btnEliminarÚltimo);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.btnReporteInverso);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.txtCódigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Control de inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarFinal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnReporteInverso;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnEliminarÚltimo;
    }
}

