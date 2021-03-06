﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class Conexion
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public Conexion()
        {
            con = new SqlConnection("Data Source=APACHEW-PC;Initial Catalog=MoviesCyR;Integrated Security=True");
            cmd = new SqlCommand();
        }

        public bool Ejecutar(String comando)
        {
            bool retorno = false;

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                retorno = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }

        public DataTable getDatos(String ComandoSql)
        {

            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ComandoSql;

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        public object ObtenerValor(String ComandoSql)
        {
            object retorno = null;

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ComandoSql;
                retorno = cmd.ExecuteScalar();
                retorno = true;
                
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                con.Close();
            }

            return retorno;

        }
    }
}
