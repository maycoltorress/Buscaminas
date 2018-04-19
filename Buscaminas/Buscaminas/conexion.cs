using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using System.Collections;
using System.Windows.Forms;

namespace Buscaminas
{
    class conexion
    { 
        private MySqlConnection conexionbd;
        private string servidor;
        private string baseDato;
        private string usuario;
        private string clave;

        public conexion()
        {
            iniciaBaseDato();

        }

        private void iniciaBaseDato()
        {
            string cadenaConexion;
            servidor = "localhost";
            baseDato = "buscaminas";
            usuario = "root";
            clave = "123456";
            cadenaConexion = "SERVER=" + servidor + ";DATABASE=" + baseDato + ";UID=" + usuario + ";PASSWORD=" + clave;
            conexionbd = new MySqlConnection(cadenaConexion);

        }
        public bool AbrirConexion()
        {
            try
            {//Si la conexion esta cerrada, la abre
                if (conexionbd != null && conexionbd.State == ConnectionState.Closed)
                    conexionbd.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Imposible conectarse al Servidor");
                        break;

                    case 1045:
                        MessageBox.Show("Datos Incorrectos");
                        break;
                }
                return false;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexionbd.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

       /* public bool Login(string usuario, string clave)
        {
            bool valido = false;
            string query = "SELECT nickname FROM login WHERE nickname='" + usuario + "'AND clave='" + clave + "'";
            if (AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexionbd);
                var respuesta = cmd.ExecuteReader();//reader significa que retorna algo
                if (!respuesta.HasRows)
                {
                    respuesta.Close();
                    CerrarConexion();
                }
                else
                {
                    valido = true;
                }
                respuesta.Close();
                CerrarConexion();
            }
            return valido;

        }*/

        public int AgregarJugador(jugador c)
        {
            string query = "INSERT INTO login values('" + c.verJugador() + "','" + c.verPuntaje() + "','" + c.verDificultad() + "');";

                if (AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexionbd);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Cliente Agregado");
                    CerrarConexion();
                }
                return 0;
        }

        public ArrayList cargarDatos()
        {
            ArrayList a = new ArrayList();
            string query = "SELECT * from login ORDER BY puntaje";
            if (AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexionbd);
                var respuesta = cmd.ExecuteReader();
                if (!respuesta.HasRows)
                {
                    respuesta.Close();
                    CerrarConexion();
                    return null;
                }
                while (respuesta.Read())
                {
                    a.Add(respuesta.GetString("jugador") + "       Tiempo =  " + respuesta.GetString("puntaje") + "        " + respuesta.GetString("dificultad"));
                }
                respuesta.Close();
                CerrarConexion();
                return a;
            }
            else
            {
                return null;
            }
        }
        
    }
}
