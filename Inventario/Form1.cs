﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        private Inventario inventario;


        public Form1()
        {
            InitializeComponent();
            inventario = new Inventario();
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            inventario.agregarAlInicio(new Producto(Convert.ToInt32(txtCódigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtPrecio.Text)));
            MessageBox.Show("Producto agregado.");
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            inventario.agregar(new Producto(Convert.ToInt32(txtCódigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtPrecio.Text)));
            MessageBox.Show("Producto agregado.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto producto = inventario.buscarProducto(Convert.ToInt32(txtCódigo.Text));
            if (producto != null)
            {
                txtNombre.Text = producto.nombre;
                txtCantidad.Text = producto.cantidad.ToString();
                txtPrecio.Text = producto.costo.ToString();
            }
            else
                MessageBox.Show("Producto no encontrado.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (inventario.eliminar(Convert.ToInt32(txtCódigo.Text)))
                MessageBox.Show("Producto eliminado.");
            else
                MessageBox.Show("No se pudo eliminar el producto.");
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            if (inventario.eliminarPrimero())
                MessageBox.Show("Producto eliminado.");
            else
                MessageBox.Show("No se pudo eliminar el producto.");
        }

        private void btnEliminarÚltimo_Click(object sender, EventArgs e)
        {
            if (inventario.eliminarÚltimo())
                MessageBox.Show("Producto eliminado.");
            else
                MessageBox.Show("No se pudo eliminar el producto.");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (inventario.insertar(new Producto(Convert.ToInt32(txtCódigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtPrecio.Text)), Convert.ToInt32(txtPos.Text)))
                MessageBox.Show("Producto insertado.");
            else
                MessageBox.Show("No se pudo insertar el producto.");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = "Código" + "\t" + "Nombre" + "\t" + "Cantidad" + "\t" + "Costo" + Environment.NewLine;
            txtReporte.Text += inventario.reporte(false);
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtReporte.Text = "Código" + "\t" + "Nombre" + "\t" + "Cantidad" + "\t" + "Costo" + Environment.NewLine;
            txtReporte.Text += inventario.reporte(true);
        }
    }
}