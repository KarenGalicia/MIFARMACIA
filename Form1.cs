using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIFARMACIA.DB;
using MongoDB.Driver;
using System.Net.Http;
using MySqlX.XDevAPI.Relational;

namespace MIFARMACIA
{
    public partial class Form1 : Form
    {
        private MEDI Medica;
        public Form1()
        {
            InitializeComponent();
            Medica = new MEDI();

        }

        private void Button_mostrar_Click(object sender, EventArgs e)
        {
            dataGridViewvermedicamentos.DataSource = Medica.Leerproductos_farmacia();

        }

        private void Buttonprueba_Click(object sender, EventArgs e)
        {
            if (Medica.ProbarConexion())
            {


                MessageBox.Show("SI SE PUDO");


            }
            else
            {
                MessageBox.Show("NEL PASTEl");
            }

        }



        private void Buttonagregar_Click(object sender, EventArgs e)
        {

            try
            {
                int Id = int.Parse(text_Id.Text);

                string Nombre_producto = Text_producto.Text;
                string Tipo_medicamento = Text_Tipodemedicamento.Text;
                string Descripcion = text_Descripción.Text;
                string Categoria = Text_Categoria.Text;
                decimal Precio;

                if (!decimal.TryParse(Text_Precio.Text, out Precio))
                {
                    MessageBox.Show("El formato del precio no es correcto. Por favor, ingrese un valor decimal.");
                    return;
                }

                string Restricciones_venta = Text_Restriccionesdeventa.Text;
                string Marca = text_Marca.Text;
                string Dosis = Text_Dosis.Text;
                string Presentacion = text_Presentacion.Text;
                DateTime Fecha_vencimiento = dateTimePickerFechadevencimiento.Value;
                string Indicaciones = Text_Indicaciones.Text;
                string Contraindicaciones = Text_Contraindicaciones.Text;
                string Efectos_secundarios = Text_Efectossecundarios.Text;
                string Proveedor = tText_Proveedor.Text;
                string Ubicacion_tienda = Text_Ubicaciondeproducto.Text;
                bool Existencia = Check_Existencia.Checked;



                DateTime Fecha_adquisicion = dateTimePicker_Fechadeadquisicion.Value;



                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea crear un nuevo producto?", "Confirmar creación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Producto creado correctamente");

                }
                else
                {
                    MessageBox.Show("Creación cancelada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }



        public void Actualizar(object sender, EventArgs e)

        {



            int Id = int.Parse(text_Id.Text);
            string Nombre_producto = Text_producto.Text;
            string Tipo_medicamento = Text_Tipodemedicamento.Text;
            string Descripcion = text_Descripción.Text;
            string Categoria = Text_Categoria.Text;
            decimal Precio;

            if (!decimal.TryParse(Text_Precio.Text, out Precio))
            {
                MessageBox.Show("El formato del precio no es correcto. Por favor, ingrese un valor decimal.");
                return;
            }

            string Restricciones_venta = Text_Restriccionesdeventa.Text;
            string Marca = text_Marca.Text;
            string Dosis = Text_Dosis.Text;
            string Presentacion = text_Presentacion.Text;
            DateTime Fecha_vencimiento = dateTimePickerFechadevencimiento.Value;
            string Indicaciones = Text_Indicaciones.Text;
            string Contraindicaciones = Text_Contraindicaciones.Text;
            string Efectos_secundarios = Text_Efectossecundarios.Text;
            string Proveedor = tText_Proveedor.Text;
            string Ubicacion_tienda = Text_Ubicaciondeproducto.Text;
            DateTime Fecha_adquisicion = dateTimePicker_Fechadeadquisicion.Value;
            bool Existencia = Check_Existencia.Checked;
            Medica.Actualizar(Id, Nombre_producto, Tipo_medicamento, Descripcion, Categoria, Precio, Restricciones_venta, Marca, Dosis, Presentacion, Fecha_vencimiento, Indicaciones, Contraindicaciones, Efectos_secundarios, Proveedor, Ubicacion_tienda, Fecha_adquisicion, Existencia);
            {
                MessageBox.Show("Producto actualizado correctamente.");
            }

        }


        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(Text_producto.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Text_Tipodemedicamento.Text))
            {
                MessageBox.Show("El tipo de medicamento no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(text_Descripción.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Text_Categoria.Text))
            {
                MessageBox.Show("La categoría no puede estar vacía.");
                return false;
            }

            decimal Precio;
            if (!decimal.TryParse(Text_Precio.Text, out Precio) || Precio <= 0)
            {
                MessageBox.Show("El precio debe ser un valor decimal válido y mayor que 0.");
                return false;
            }

  
            if (dateTimePickerFechadevencimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de vencimiento no puede ser una fecha futura.");
                return false;
            }

            return true;
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
       
            {
                try
                {
                    if (ValidarDatos())
                    {
                        DialogResult result = MessageBox.Show("¿Quieres actualizar este medicamento?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método Actualizar solo si el usuario confirma la actualización
                        Actualizar(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Actualización cancelada.");
                    }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }







