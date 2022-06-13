using CRUDNETBBDD.Models;
using System.Data;
using System.Data.SqlClient;

namespace CRUDNETBBDD.Datos
{
    public class ProductoDatos
    {

        public List<ModelArticulo> ListarArticulo()
        {
            var oListaArticulo = new List<ModelArticulo>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadena()))
            {
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand("ListarArticulos", conexion);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                using (var dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oListaArticulo.Add(new ModelArticulo(){
                            id = Convert.ToInt32(dr["id"]),
                            seccion = dr["seccion"].ToString(),
                            nombreArticulo = dr["nombreArticulo"].ToString(),
                            precio = Convert.ToDouble(dr["precio"]),
                            fecha = Convert.ToDateTime(dr["fecha"]),
                            paisOrigen = dr["paisOrigen"].ToString()
                        });
                    }
                }

                return oListaArticulo;
            }
        }
    
        public ModelArticulo ObtenerArticulo(int id)
        {

            var oArticulo = new ModelArticulo();
            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadena()))
            {
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand("ObtenerArticulo", conexion);
                sqlCommand.Parameters.AddWithValue("IdArticulo", id);
                sqlCommand.CommandType = CommandType.StoredProcedure;


                using (var dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oArticulo.id = Convert.ToInt32(dr["id"]);
                        oArticulo.seccion = dr["seccion"].ToString();
                        oArticulo.nombreArticulo = dr["nombreArticulo"].ToString();
                        oArticulo.precio = Convert.ToDouble(dr["precio"]);
                        oArticulo.fecha = Convert.ToDateTime(dr["fecha"]);
                        oArticulo.paisOrigen = dr["paisOrigen"].ToString();
                    }
                }

                return oArticulo;
            }

        }


        public bool CrearArticulo(ModelArticulo modelArticulo) 
        {
            bool respuesta;

            try
            {
                var cn =  new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();

                    SqlCommand sqlCommand = new SqlCommand("CrearArticulo", conexion);

                    sqlCommand.Parameters.AddWithValue("seccion", modelArticulo.seccion);
                    sqlCommand.Parameters.AddWithValue("nombreArticulo", modelArticulo.nombreArticulo);
                    sqlCommand.Parameters.AddWithValue("precio", modelArticulo.precio);
                    sqlCommand.Parameters.AddWithValue("fecha", modelArticulo.fecha);
                    sqlCommand.Parameters.AddWithValue("paisOrigen", modelArticulo.paisOrigen);


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

        public bool EditarArticulo(ModelArticulo modelArticulo)
        {
            bool respuesta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand("EditarArticulo", conexion);
                    
                    sqlCommand.Parameters.AddWithValue("id", modelArticulo.id);
                    sqlCommand.Parameters.AddWithValue("seccion", modelArticulo.seccion);
                    sqlCommand.Parameters.AddWithValue("nombreArticulo", modelArticulo.nombreArticulo);
                    sqlCommand.Parameters.AddWithValue("precio", modelArticulo.precio);
                    sqlCommand.Parameters.AddWithValue("fecha", modelArticulo.fecha);
                    sqlCommand.Parameters.AddWithValue("paisOrigen", modelArticulo.paisOrigen);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                }

                respuesta = true;

            }
            catch (Exception ex)
            {
                string errot = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }
    
        public bool EliminarArticulo(int id)
        {
            bool respuesta;

            try
            {

                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {

                    conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand("EliminarArticulo", conexion);
                    
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


        public List<ModelArticulo> ListarArticulosCliente(int id)
        {
            var oListaArticulo = new List<ModelArticulo>();
            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadena()))
            {
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand("ObtenerArticuloCliente", conexion);
                sqlCommand.Parameters.AddWithValue("id", id);
                sqlCommand.CommandType = CommandType.StoredProcedure;


                using (var dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oListaArticulo.Add(new ModelArticulo()
                        {
                            id = Convert.ToInt32(dr["id"]),
                            seccion = dr["seccion"].ToString(),
                            nombreArticulo = dr["nombreArticulo"].ToString(),
                            precio = Convert.ToDouble(dr["precio"]),
                            fecha = Convert.ToDateTime(dr["fecha"]),
                            paisOrigen = dr["paisOrigen"].ToString()
                        });
                    }

                }

                }
                return oListaArticulo;
            }
        }
    }
