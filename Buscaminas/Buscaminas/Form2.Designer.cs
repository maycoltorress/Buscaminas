﻿namespace Buscaminas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.boxusuario = new System.Windows.Forms.TextBox();
            this.boxfilas = new System.Windows.Forms.TextBox();
            this.boxminas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxusuario
            // 
            this.boxusuario.BackColor = System.Drawing.SystemColors.Menu;
            this.boxusuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.boxusuario.Location = new System.Drawing.Point(119, 31);
            this.boxusuario.Name = "boxusuario";
            this.boxusuario.Size = new System.Drawing.Size(205, 20);
            this.boxusuario.TabIndex = 0;
            // 
            // boxfilas
            // 
            this.boxfilas.BackColor = System.Drawing.SystemColors.Menu;
            this.boxfilas.ForeColor = System.Drawing.Color.DarkBlue;
            this.boxfilas.Location = new System.Drawing.Point(119, 70);
            this.boxfilas.Name = "boxfilas";
            this.boxfilas.Size = new System.Drawing.Size(91, 20);
            this.boxfilas.TabIndex = 1;
            // 
            // boxminas
            // 
            this.boxminas.BackColor = System.Drawing.SystemColors.Menu;
            this.boxminas.ForeColor = System.Drawing.Color.DarkBlue;
            this.boxminas.Location = new System.Drawing.Point(119, 111);
            this.boxminas.Name = "boxminas";
            this.boxminas.Size = new System.Drawing.Size(91, 20);
            this.boxminas.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(119, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dimensión Matriz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de Minas";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.ForeColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(459, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.ForeColor = System.Drawing.Color.Cyan;
            this.textBox2.Location = new System.Drawing.Point(459, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox3.ForeColor = System.Drawing.Color.Cyan;
            this.textBox3.Location = new System.Drawing.Point(459, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox4.ForeColor = System.Drawing.Color.Cyan;
            this.textBox4.Location = new System.Drawing.Point(459, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(190, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(459, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jugador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(523, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(579, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dificultad";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox5.ForeColor = System.Drawing.Color.Cyan;
            this.textBox5.Location = new System.Drawing.Point(459, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(190, 20);
            this.textBox5.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(745, 278);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxminas);
            this.Controls.Add(this.boxfilas);
            this.Controls.Add(this.boxusuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxusuario;
        private System.Windows.Forms.TextBox boxfilas;
        private System.Windows.Forms.TextBox boxminas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
    }
}