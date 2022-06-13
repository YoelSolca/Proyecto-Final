using CRUDNETBBDD.Models;
using System.Data;
using System.Data.SqlClient;

namespace CRUDNETBBDD.Datos
{
    public class PedidoDatos
    {
        public List<ModelPedido> ListarPedidos()
        {
            var oListaPedido = new List<ModelPedido>();
            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadena()))
            {
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand("ListarPedidos", conexion);
                sqlCommand.CommandType = CommandType.StoredProcedure;


                using (var dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oListaPedido.Add(new ModelPedido()
                        {
                            id = Convert.ToInt32(dr["id"]),
                            cCliente = Convert.ToInt32(dr["cCliente"]),
                            fechaPedido = Convert.ToDateTime(dr["fechaPedido"]),
                            formadePago = dr["formadePago"].ToString(),
                            cArticulo = Convert.ToInt32(dr["cArticulo"]),
                            modelArticulo = new ModelArticulo(),
                            modelCliente = new ModelCliente()
                        });
                    }

                }
                return oListaPedido;
            }
        }

        public ModelPedido ObtenerPedido(int id)
        {

            var oPedido = new ModelPedido();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadena()))
            {
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand("ObtenerPedido", conexion);
                sqlCommand.Parameters.AddWithValue("idPedido", id);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                using (var dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oPedido.id = Convert.ToInt32(dr["id"]);
                        oPedido.cCliente = Convert.ToInt32(dr["cCliente"]);
                        oPedido.fechaPedido = Convert.ToDateTime(dr["fechaPedido"]);
                        oPedido.formadePago = dr["formadePago"].ToString();
                        oPedido.cArticulo = Convert.ToInt32(dr["cArticulo"]);
                    }
                }
            }
            return oPedido;

        }

        public bool CrearPedido(ModelPedido modelPedido)
        {
            bool respuesta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();

                    SqlCommand sqlCommand = new SqlCommand("CrearPedido", conexion);

                    sqlCommand.Parameters.AddWithValue("cCliente", modelPedido.cCliente);
                    sqlCommand.Parameters.AddWithValue("fechaPedido", modelPedido.fechaPedido);
                    sqlCommand.Parameters.AddWithValue("formadePago", modelPedido.formadePago);
                    sqlCommand.Parameters.AddWithValue("cArticulo", modelPedido.cArticulo);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();

                }

                respuesta = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }


        public bool EditarPedido(ModelPedido modelPedido)
        {
            bool respuesta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();

                    SqlCommand sqlCommand = new SqlCommand("EditarPedido", conexion);


                    sqlCommand.Parameters.AddWithValue("cCliente", modelPedido.cCliente);
                    sqlCommand.Parameters.AddWithValue("fechaPedido", modelPedido.fechaPedido);
                    sqlCommand.Parameters.AddWithValue("formadePago", modelPedido.formadePago);
                    sqlCommand.Parameters.AddWithValue("cArticulo", modelPedido.cArticulo);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();

                }


                respuesta = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

        public bool EliminarPedido(int id)
        {
            bool respuesta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();

                    SqlCommand sqlCommand = new SqlCommand("EliminarPedido", conexion);

                    sqlCommand.Parameters.AddWithValue("id", id);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                }
                respuesta = true;
            }
            catch (Exception ex)
            {

                string error = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }


        public List<ModelPedido> ListarPedidosCliente(int id)
        {
            var oListaPedido = new List<ModelPedido>();
            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadena()))
            {
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand("ObtenerPedidosCliente", conexion);
                sqlCommand.Parameters.AddWithValue("id", id);
                sqlCommand.CommandType = CommandType.StoredProcedure;


                using (var dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oListaPedido.Add(new ModelPedido()
                        {
                            id = Convert.ToInt32(dr["id"]),
                            cCliente = Convert.ToInt32(dr["cCliente"]),
                            fechaPedido = Convert.ToDateTime(dr["fechaPedido"]),
                            formadePago = dr["formadePago"].ToString(),
                            cArticulo = Convert.ToInt32(dr["cArticulo"]),
                            modelArticulo = new ModelArticulo()   
                        });

                    }

                }
                return oListaPedido;
            }
        }

        public bool EliminarClientePedido(int id)
        {
            bool respuesta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();

                    SqlCommand sqlCommand = new SqlCommand("EliminarClientePedido", conexion);

                    sqlCommand.Parameters.AddWithValue("id", id);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                }
                respuesta = true;
            }
            catch (Exception ex)
            {

                string error = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

    }
}
