using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List <Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select idusuario,documento,Razon_Social,Correo,Telefono,estado from Usuario ";

                    SqlCommand cdm = new SqlCommand(query, oconexion);
                    cdm.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cdm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                idusuario = Convert.ToInt32(dr["idusuario"]),
                                documento = dr["Documento"].ToString(),
                                Razon_Social = dr["Razon_Social"].ToString(),
                                correo = dr["Correo"].ToString(),
                                clave = dr["Clave"].ToString(),
                                estado = Convert.ToBoolean(dr["Estado"])

                            });

                        }
                    }

                }
                catch (Exception ex){
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
    }
}
