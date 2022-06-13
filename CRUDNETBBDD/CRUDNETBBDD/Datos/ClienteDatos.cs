using CRUDNETBBDD.Models;
using System.Data.SqlClient;
using System.Data;


namespace CRUDNETBBDD.Datos
{
    public class ClienteDatos
    {
        //Read
        public List<ModelCliente> ListarClientes()
        {
            var oLista = new List<ModelCliente>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadena()))
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("Listar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                using(var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        oLista.Add(new ModelCliente(){
                        id = Convert.ToInt32 (dr["id"]),
                        nombre = dr["nombre"].ToString(),
                        poblacion = dr["poblacion"].ToString(),
                        direccion = dr["direccion"].ToString(),
                        telefono = dr["telefono"].ToString()
                        });
                }
            }

            return oLista;
        } 
          
        //Read by id
            public ModelCliente ObtenerCliente(int id)
            {

                var oCliente = new ModelCliente();
            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadena()))
            {
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand("Obtener", conexion);
                sqlCommand.Parameters.AddWithValue("IdCliente", id); //Recibiendo el parametro
                sqlCommand.CommandType = CommandType.StoredProcedure;


                using (var dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oCliente.id = Convert.ToInt32(dr["id"]);
                        oCliente.nombre = dr["nombre"].ToString();
                        oCliente.poblacion = dr["poblacion"].ToString();
                        oCliente.direccion = dr["direccion"].ToString();
                        oCliente.telefono = dr["telefono"].ToString();
                    }
                }
            } 

                return oCliente;
            }


        //Create
        public bool CrearCliente(ModelCliente oCliente)
        {
            bool respuesta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();

                    SqlCommand sqlCommand = new SqlCommand("Guardar", conexion);

                    sqlCommand.Parameters.AddWithValue("nombre", oCliente.nombre);
                    sqlCommand.Parameters.AddWithValue("direccion", oCliente.direccion);
                    sqlCommand.Parameters.AddWithValue("poblacion", oCliente.poblacion);
                    sqlCommand.Parameters.AddWithValue("telefono", oCliente.telefono);
                    
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.ExecuteNonQuery();
                }
                respuesta = true;

            }catch (Exception ex)
            {
                string error = ex.Message;
                respuesta = false;
            }

            return respuesta;

        }


        //Update
        public bool EditarCliente(ModelCliente oCliente)
        {
            bool respuesta;

            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Editar", conexion);

                    cmd.Parameters.AddWithValue("id", oCliente.id);
                    cmd.Parameters.AddWithValue("nombre", oCliente.nombre);
                    cmd.Parameters.AddWithValue("poblacion", oCliente.poblacion);
                    cmd.Parameters.AddWithValue("direccion", oCliente.direccion);
                    cmd.Parameters.AddWithValue("telefono", oCliente.telefono);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
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


        //Delete
        public bool EliminarCliente(int id)
        {
            bool respuesta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadena()))
                {
                    conexion.Open();
                    SqlCommand command = new SqlCommand("Eliminar", conexion);

                    command.Parameters.AddWithValue("id", id);

                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
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
