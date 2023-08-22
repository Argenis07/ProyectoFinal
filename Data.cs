using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public class Data
    {
        private string _connectionString;

        public Data(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable ConsultaOrden()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "EXEC Consulta_Orden";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public List<Product> DetalleOrden(int orderID)
        {
            List<Product> detalle = new List<Product>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string procedureName = "Detalle_Orden";
                using (SqlCommand cmd = new SqlCommand(procedureName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product producto = new Product();
                            producto.Nro = Convert.ToInt32(reader["Nro"]);
                            producto.Producto = reader["Producto"].ToString();
                            producto.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                            producto.Precio = Convert.ToDecimal(reader["Precio"]);
                            producto.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                            detalle.Add(producto);
                        }
                    }
                }
            }

            return detalle;
        }

        public List<Product> Lista_Productos()
        {
            List<Product> productos = new List<Product>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string procedureName = "Lista_Productos";
                using (SqlCommand cmd = new SqlCommand(procedureName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product producto = new Product();
                            producto.IdProducto = Convert.ToInt32(reader["ProductID"]);
                            producto.Producto = reader["ProductName"].ToString();
                            productos.Add(producto);
                        }
                    }
                }
            }

            return productos;
        }

        public void Agregar_Producto(int orderID, int productID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string procedureName = "Agregar_Producto";
                using (SqlCommand cmd = new SqlCommand(procedureName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
