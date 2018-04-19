using System;
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
    public partial class Form1 : Form
    {
        Random r = new Random();
        int n, respuesta, activado =0;
        int filas;
        int columnas;
        int minas, minasBox;
        public int puntaje = 0, numeros = 0, descubiertos =0;
        int cantidad;
        int[,] m;
        int[] indice;
        string jugador;
        int segundos = 0;
        private conexion con = new conexion();

        public Form1(string usuario, int filas, int columnas, int minas)
        {
            this.jugador = usuario;
            this.filas = filas;
            this.columnas = columnas;
            this.minas = minas;
            this.minasBox=minas;
            m = new int[filas + 2, columnas + 2];
            indice = new int[minas];
            InitializeComponent();
            timer1.Start();
            LlenarIndices(m);
            NumeroEnMatriz(m);
            matriz(m);
            cantidad = ContarNumerosEnMatriz(m);
            textBox2.Text = minasBox + "";

            //dibujarNumero(m);

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

        public int buscar(int[] indice, int n)
        {
            for (int i = 0; i < minas; i++)
            {
                if (indice[i] == n)
                    return 1;
            }
            return 0;
        }

        public void LlenarIndices(int[,] m)
        {
            //llenar matriz con 0
            for (int i = 0; i < filas + 2; i++)
            {
                for (int j = 0; j < columnas + 2; j++)
                {
                    m[i, j] = 0;
                }
            }

            for (int i = 0; i < minas; i++)
            {
                indice[i] = -1;
            }
            //Generar valores alterorios de indice sin repetir
            for (int i = 0; i < minas; i++)
            {

                n = r.Next(0, (filas * columnas) - 1);
                respuesta = buscar(indice, n);
                if (respuesta == 1)
                    i--;
                else
                    indice[i] = n;

            }
            //Insertar bombas = 99
            int cont = 0;
            for (int i = 1; i < filas + 1; i++)
            {
                for (int j = 1; j < columnas + 1; j++)
                {

                    //Buscar el elemento de cont en la lista de indices y si coincide almaceno una bomba en ese lugar
                    for (int k = 0; k < minas; k++)
                    {
                        if (indice[k] == cont)
                            m[i, j] = 99;
                    }
                    //m[i, j] = 99;
                    cont++;


                }
            }

        }

        public void matriz(int[,] m)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    var button = new Button();
                    button.Width = 40;
                    button.Height = 40;
                    button.Text = string.Format("");
                    //button.Text = string.Format(dibujarNumero(m, j + 1, i + 1));
                    
                    button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Click);
                    button.BackColor = Color.FromArgb(255, 250, 240);//blanco 
                    button.Location = new Point(i * 40, j * 40);
                    if (m[j + 1, i + 1] != 0) //Si la casilla no esta vacia, le pongo un color
                        button.BackColor = Color.FromArgb(30, 144, 255);//celeste

                    //button.BackColor = Color.FromArgb(30, 144, 255);//Poner color a los botones
                    this.Controls.Add(button);
                }

            }


        }

        public string dibujarNumero(int[,] m, int i, int j)
        {
            int n = 0;

            if (m[i, j] != 99)
            {
                if (m[i - 1, j] == 99)
                    n++;
                if (m[i - 1, j + 1] == 99)
                    n++;
                if (m[i, j + 1] == 99)
                    n++;
                if (m[i + 1, j + 1] == 99)
                    n++;
                if (m[i + 1, j] == 99)
                    n++;
                if (m[i + 1, j - 1] == 99)
                    n++;
                if (m[i, j - 1] == 99)
                    n++;
                if (m[i - 1, j - 1] == 99)
                    n++;
                if (n == 0)
                    return "";
                return n + "";

            }

            return "";

            /* for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 10; j++)
                 {
                     MessageBox.Show("i= " + i + ", j= " + j + "= " + m[i, j]);
                 }
             }*/
        }

        public void NumeroEnMatriz(int[,] m)
        {
            int n = 0;
            for (int i = 1; i < filas + 1; i++)
            {
                for (int j = 1; j < columnas + 1; j++)
                {
                    if (m[i, j] != 99)
                    {
                        if (m[i - 1, j] == 99)
                            n++;
                        if (m[i - 1, j + 1] == 99)
                            n++;
                        if (m[i, j + 1] == 99)
                            n++;
                        if (m[i + 1, j + 1] == 99)
                            n++;
                        if (m[i + 1, j] == 99)
                            n++;
                        if (m[i + 1, j - 1] == 99)
                            n++;
                        if (m[i, j - 1] == 99)
                            n++;
                        if (m[i - 1, j - 1] == 99)
                            n++;
                        m[i, j] = n;
                        n = 0;
                    }
                }
            }
        }


        public int ContarNumerosEnMatriz(int[,] m)
        {
            for (int i = 1; i < filas + 1; i++)
            {
                for (int j = 1; j < columnas + 1; j++)
                {
                    if (m[i, j] != 99 && m[i, j] != 0)
                        numeros++;
                }
            }
            return numeros;
        }


        private void Button_Click(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (activado == 0)
                {
                    string asd = (sender as Button).Name;

                    int y = (sender as Button).Location.X;
                    int x = (sender as Button).Location.Y;
                    //MessageBox.Show(x + "," + y);

                    //Comparar las coordenadas con las de las bombas, si son iguales dibuja 1 bomba
                    if (m[(x / 40) + 1, (y / 40) + 1] == 99)
                    {
                        (sender as Button).Text = "*";
                        timer1.Stop();
                        string mensaje = "Perdiste " + jugador;
                        Form3 frm = new Form3(mensaje, filas, columnas, minas, jugador);
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {

                        //Toma las coordenadas y las transforma a valores de la matriz asociada, luego si encuentra bombas retorna el numero de bombas cercanas
                        x = (x / 40) + 1;
                        y = (y / 40) + 1;

                        string numero = dibujarNumero(m, x, y);
                        (sender as Button).Text = numero;

                        (sender as Button).BackColor = Color.FromArgb(255, 250, 240); //Poner en blanco el boton presionado

                        
                        if (numero != "")
                        {
                            descubiertos++;
                            if (descubiertos == cantidad)//Comparar si gana
                            {
                                timer1.Stop();
                                string mensaje ="Ganaste "+jugador+" Tiempo: " + segundos;
                                string dificultad = filas+" x "+ columnas;
                                int respuesta = con.AgregarJugador(new jugador(jugador, segundos,dificultad));
                                Form3 frm = new Form3(mensaje,filas, columnas, minas,jugador);
                                this.Hide();
                                frm.Show();

                                
                            }
                        }
                        
                            
                    }

                }

            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if ((sender as Button).Text == "")
                {
                    minasBox--;
                    (sender as Button).Text = "B";
                    if (minasBox >= 0)
                        textBox2.Text = minasBox + "";
                    else
                        minasBox = 0;
                    
                }
                else if ((sender as Button).Text == "B")
                {
                    (sender as Button).Text = "?";
                    
                }
                else if ((sender as Button).Text == "?")
                {
                    minasBox++;
                    (sender as Button).Text = "";
                    if (minasBox <= minas)
                        textBox2.Text = minasBox + "";
                    else
                        minasBox = minas;
                    
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(jugador,filas,columnas,minas);
            this.Hide();
            frm.Show();  

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                textBox1.Text = segundos + "";
                //System.Threading.Thread.Sleep(100);
                segundos++;
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }
       
        
        
    }


}

