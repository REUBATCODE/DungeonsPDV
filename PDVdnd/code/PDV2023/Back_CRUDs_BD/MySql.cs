using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_CRUDs_BD
{
    public class MySql : CRUDs_BD
    {
        /// <summary>
        /// variables de conexion y acceso a la BD
        /// </summary>
        MySqlConnection con;
        MySqlCommand comando;
        MySqlDataReader dr;
        public MySql(string host, string us, string pwd, string bd, string puerto = "3306")
        {
            //vamos a inicializar los valores de conexión
            this.connectionString = $"Server={host}; Port={puerto}; Database={bd}; Uid={us}";
            con = new MySqlConnection(connectionString);
        }
        public override bool insertar(string tabla, List<string> campos, List<ValoresAInsertar> valores)
        {
            //definir var de resultado
            bool resultado = false;
            //programar el esqueleto de ejecutar una accion de query en BD.
            try
            {
                //abrir una conexión
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                //se concatenan todos los campos
                string camposConcat = "";
                foreach (var campo in campos)
                {
                    camposConcat += campo + ",";
                }
                //Quitar la coma****
                camposConcat = camposConcat.Remove(camposConcat.Length - 1);
                string valsConcat = "";
                //Concatenamos los valores
                foreach (ValoresAInsertar valor in valores)
                {
                    if(valor.llevaApostrofes)
                    {
                        valsConcat += "'" + valor + "',";
                    }
                    else
                    {
                        valsConcat += valor + ",";
                    }
                }
                //definir el query en el MysqlCommand
                comando = new MySqlCommand($"INSERT INTO {tabla} ({camposConcat}) VALUES({valsConcat})");
                //relacionar el command con la conexión
                comando.Connection = con;
                //ejecutar el query****
                int res = comando.ExecuteNonQuery();
                //validar que se ejecutó correctamente
                if (res == 1)
                    resultado = true;
                else
                {
                    resultado = false;
                    this.msgError = "No se registró";
                }
            }
            catch (MySqlException mex)
            {
                //tronó la conexión o el insert
                this.msgError = "No se pudo insertar el nuevo registro a la Base de Datos." + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "No se pudo insertar el nuevo registro por error de Windows" + ex.Message;
            }
            finally
            {
                //cerrar la conexión
                if(con.State == System.Data.ConnectionState.Open) con.Close();
            }
            return resultado;
        }

        public override bool modificar(string tabla, List<string> campos, List<ValoresAInsertar> valores, int id)
        {
            bool resultado = false;
            try
            {
                //abrir conexion
                if (con.State == System.Data.ConnectionState.Closed) 
                    con.Open();
                string camposConcat = "";
                //definir el command
                for (int i = 0; i < campos.Count; i++)
                {
                    //concatenar un nombreDeCampo = valor (con sus '')
                    camposConcat += campos[i] + "=" + (valores[i].llevaApostrofes ?
                        "'" + valores[i].valor + "'," : valores[i].valor + ",");

                    //if (valores[i].llevaApostrofes)
                    //    camposConcat += campos[i] + "=" + "'" + valores[i].valor + "',";
                    //else
                    //    camposConcat += campos[i] + "=" + valores[i].valor + ",";
                }
                camposConcat = camposConcat.Remove(camposConcat.Length - 1);
                comando = new MySqlCommand($"UPDATE {tabla} SET {camposConcat} WHERE id={id}");
                //asociar la conexion al command
                comando.Connection = con;
                //ejecutar el command
                int res = comando.ExecuteNonQuery();
                //validar el command
                if (res == 1)
                    resultado = true;
                else
                    resultado = false;
            }
            catch (MySqlException mex)
            {
                this.msgError = "No se pudo modificar el registro por problema de conexión" + mex.Message;
            }
            catch(Exception ex)
            {
                this.msgError = "No se pudo modificar por problemas de Windows." + ex.Message;
            }
            finally
            {
                if(con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public override bool borrar(string tabla, int id)
        {
            //DELETE FROM tabla WHERE 
            bool resultado = false;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                comando = new MySqlCommand($"DELETE FROM {tabla} WHERE id={id}");
                comando.Connection = con;
                int res = comando.ExecuteNonQuery();
                if (res == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "No se pudo borrar el registro por error de base de datos." + mex.Message;
            }
            finally
            {
                if(con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
         
        }

        public override object consulta(string tabla)
        {
            List<object[]> resultado = new List<object[]>();
            //hacer el bloque trycatch.
            try
            {
                //validar conexion
                if(con.State==System.Data.ConnectionState.Closed)
                    con.Open();
                //establecer el query---> select * from table
                comando = new MySqlCommand($"SELECT * FROM {tabla}");
                comando.Connection = con;
                //ejecutar el query
                dr = comando.ExecuteReader();
                //validar el resultado de la query
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        object[] registro = new object[dr.FieldCount];
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            registro[i] = dr.GetValue(i);
                        }
                        //lo cargamos el registro
                        resultado.Add(registro);
                    }
                }
                else
                {
                    this.msgError = $"No existen registros en la tabla {tabla}";
                    resultado = new List<object[]>();
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "No se pudo hacer la consulta en el servidor." + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "No se pudo hacer la consulta por fallo de Windows." + ex.Message;
            }
            finally
            {
                if(con.State==System.Data.ConnectionState.Open) con.Close();
            }
            
            return resultado;
        }

        public override List<object[]> consulta(string tabla, string criterioBusqueda)
        {
            List<object[]> resultado = new List<object[]>();
            //hacer el bloque trycatch.
            try
            {
                //validar conexion
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                //establecer el query---> select * from table
                comando = new MySqlCommand($"SELECT * FROM {tabla} WHERE {criterioBusqueda}");
                //ejecutar el query
                dr = comando.ExecuteReader();
                //validar el resultado de la query
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        object[] registro = new object[dr.FieldCount];
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            registro[i] = dr.GetValue(i);
                        }
                        //lo cargamos el registro
                        resultado.Add(registro);
                    }
                }
                else
                {
                    this.msgError = $"No existen registros en la tabla {tabla}";
                    resultado = new List<object[]>();
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "No se pudo hacer la consulta en el servidor." + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "No se pudo hacer la consulta por fallo de Windows." + ex.Message;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }

            return resultado;
        }
    }
}
