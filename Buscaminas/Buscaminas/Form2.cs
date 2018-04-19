using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class Form2 : Form
    {
        public string usuario;
        public int filas, columnas, minas;
        conexion con = new conexion();
        public Form2()
        {
            InitializeComponent();

            ArrayList a = con.cargarDatos();
            textBox1.Text = a[0] + "";
            textBox2.Text = a[1] + "";
            textBox3.Text = a[2] + "";
            textBox4.Text = a[3] + "";
            textBox5.Text = a[4] + "";
        }
        //metodo para validar si los valores son numericos
        private bool EsNumero(string numero)
        {
            try
            {
                int x = Convert.ToInt32(numero);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!EsNumero(boxfilas.Text) || !EsNumero(boxminas.Text))
            {
                MessageBox.Show("Ingrese valores numericos en cantidad y dimensión");
                boxminas.Text = "";
                boxfilas.Text = "";
            }
            if (boxusuario.Text == "" || boxfilas.Text == "" || boxminas.Text == "")
            {
                MessageBox.Show("Faltan Datos");
            }
            else
            {
                usuario = boxusuario.Text;
                filas = Convert.ToInt32(boxfilas.Text);
                columnas = Convert.ToInt32(boxfilas.Text);
                minas = Convert.ToInt32(boxminas.Text);

                if (filas > 25)
                {
                    MessageBox.Show("El tamaño no debe superar 25x25 casillas");
                    boxfilas.Text = "";
                    boxminas.Text = "";
                }
                if (minas >= (filas * filas))
                    MessageBox.Show("Al menos debe haber 1 casilla sin minas");
                else
                {
                    Form1 frm = new Form1(usuario, filas, columnas, minas);
                    this.Hide();
                    frm.Show();
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        
    }
}
