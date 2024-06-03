using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System.Net.Http;
using System.Collections;


namespace MIFARMACIA.DB
{
    internal class MEDI
    {
        private string connectionString = "Server=localhost;Database=farmaciadb;Uid=root;Pwd=123Pk2..";
   
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public DataTable Leerproductos_farmacia()
        {
            DataTable productos_farmacia = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM productos_farmacia";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(productos_farmacia);
                    }
                }
            }
            return productos_farmacia;

        }
        public int Generar_producto(string Nombre_producto, string Tipo_medicamento, string Descripcion, string Categoria, decimal Precio, string Restricciones_venta, string Marca, string Dosis, string Presentacion, DateTime Fecha_vencimiento, string Indicaciones, string Contraindicaciones, string Efectos_secundarios, string Proveedor, string Ubicacion_tienda, DateTime Fecha_adquisicion, bool Existencia)
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    {
                        string query = "INSERT INTO productos_farmacia (Nombre_producto, Tipo_medicamento, Descripcion, Categoria, Precio, Restricciones_venta, Marca, Dosis, Presentacion, Fecha_vencimiento, Indicaciones, Contraindicaciones, Efectos_secundarios, Proveedor, Ubicacion_tienda, Fecha_adquisicion, Existencia) " +
                           "VALUES (@Nombre_producto, @Tipo_medicamento, @Descripcion, @Categoria, @Precio, @Restricciones_venta, @Marca, @Dosis, @Presentacion, @Fecha_vencimiento, @Indicaciones, @Contraindicaciones, @Efectos_secundarios, @Proveedor, @Ubicacion_tienda, @Fecha_adquisicion, @Existencia)";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        {
                            command.Parameters.AddWithValue("@Nombre_producto", Nombre_producto);
                            command.Parameters.AddWithValue("@Tipo_medicamento", Tipo_medicamento);
                            command.Parameters.AddWithValue("@Descripcion", Descripcion);
                            command.Parameters.AddWithValue("@Categoria", Categoria);
                            command.Parameters.AddWithValue("@Precio", Precio);
                            command.Parameters.AddWithValue("@Restricciones_venta", Restricciones_venta);
                            command.Parameters.AddWithValue("@Marca", Marca);
                            command.Parameters.AddWithValue("@Dosis", Dosis);
                            command.Parameters.AddWithValue("@Presentacion", Presentacion);
                            command.Parameters.AddWithValue("@Fecha_vencimiento", Fecha_vencimiento);
                            command.Parameters.AddWithValue("@Indicaciones", Indicaciones);
                            command.Parameters.AddWithValue("@Contraindicaciones", Contraindicaciones);
                            command.Parameters.AddWithValue("@Efectos_secundarios", Efectos_secundarios);
                            command.Parameters.AddWithValue("@Proveedor", Proveedor);
                            command.Parameters.AddWithValue("@Ubicacion_tienda", Ubicacion_tienda);
                            command.Parameters.AddWithValue("@Fecha_adquisicion", Fecha_adquisicion);
                            command.Parameters.AddWithValue("@Existencia", Existencia);

                            return command.ExecuteNonQuery();
                        }


                    }
                }
            }



            catch (MySqlException ex)
            {

                Console.WriteLine($"Error de MySQL: {ex.Message}");

                return -1;
            }



        }


        public void Actualizar(int Id, string Nombre_producto, string Tipo_medicamento, string Descripcion, string Categoria, decimal Precio, string Restricciones_venta, string Marca, string Dosis, string Presentacion, DateTime Fecha_vencimiento, string Indicaciones, string Contraindicaciones, string Efectos_secundarios, string Proveedor, string Ubicacion_tienda, DateTime Fecha_adquisicion, bool Existencia)
        {
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    

                string query = "UPDATE productos_farmacia SET Nombre_producto =@Nombre_producto, Tipo_medicamento = @Tipo_medicamento, Descripcion = @Descripcion, Categoria = @Categoria, Precio = @Precio, Restricciones_venta = @Restricciones_venta, Marca = @Marca, Dosis = @Dosis, Presentacion = @Presentacion, Fecha_vencimiento = @Fecha_vencimiento, Indicaciones = @Indicaciones, Contraindicaciones = @Contraindicaciones, Efectos_secundarios = @Efectos_secundarios, Proveedor = @Proveedor, Ubicacion_tienda = @Ubicacion_tienda, Fecha_adquisicion = @Fecha_adquisicion,  Existencia = @Existencia  WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Nombre_producto", Nombre_producto);
                        command.Parameters.AddWithValue("@Tipo_medicamento", Tipo_medicamento);
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.Parameters.AddWithValue("@Categoria", Categoria);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Restricciones_venta", Restricciones_venta);
                        command.Parameters.AddWithValue("@Marca", Marca);
                        command.Parameters.AddWithValue("@Dosis", Dosis);
                        command.Parameters.AddWithValue("@Presentacion", Presentacion);
                        command.Parameters.AddWithValue("@Fecha_vencimiento", Fecha_vencimiento);
                        command.Parameters.AddWithValue("@Indicaciones", Indicaciones);
                        command.Parameters.AddWithValue("@Contraindicaciones", Contraindicaciones);
                        command.Parameters.AddWithValue("@Efectos_secundarios", Efectos_secundarios);
                        command.Parameters.AddWithValue("@Proveedor", Proveedor);
                        command.Parameters.AddWithValue("@Ubicacion_tienda", Ubicacion_tienda);
                        command.Parameters.AddWithValue("@Fecha_adquisicion", Fecha_adquisicion);
                        command.Parameters.AddWithValue("@Existencia", Existencia);
                        command.ExecuteNonQuery();
                    }

                }
            }
        }
            public void Eliminar(int Id)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM productos_farmacia WHERE Id = @Id";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

    }

    

            