using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion2_Tarea
{
    public partial class form1 : Form
    {

        public form1()
        {
            
            InitializeComponent();
            
        }

        // Definicion de variables //

        public int mes;
        public int dia;
        public int año;
        public string mesFinal;

        // Posibles errores de usuarios //

        const string ERROR_FECHA = "La fecha ingresada no es valida";

        // Validacion para que solo se admitan numeros en los textboxs //

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        // le suma un dia a la fecha ingresada teniendo en cuenta los cambios de mes y/o año para luego ingresarlo en la label //

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            mes = int.Parse(txtMes.Text);
            dia = int.Parse(txtDia.Text);
            año = int.Parse(txtAño.Text);
            mesFinal = "";
            bool i = true;

            if (mes == 1 && 1 <= dia && dia <= 30)
            {
                mesFinal = "Enero";
                dia = dia + 1;
            }
            else if ( mes == 1 && dia == 31)
            {
                mesFinal = "Febrero";
                dia = 1;
            }
            else if (mes == 2 && 1 <= dia && dia <= 27)
            {
                mesFinal = "Febrero";
                dia = dia + 1;
            }
            else if (mes == 2 && dia == 28)
            {
                mesFinal = "Marzo";
                dia = 1;
            }
            else if (mes == 3 && 1 <= dia && dia <= 30)
            {
                mesFinal = "Marzo";
                dia = dia + 1;
            }
            else if (mes == 3 && dia == 31)
            {
                mesFinal = "Abril";
                dia = 1;
            }
            else if (mes == 4 && 1 <= dia && dia <= 29)
            {
                mesFinal = "Abril";
                dia = dia + 1;
            }
            else if (mes == 4 && dia == 30)
            {
                mesFinal = "Mayo";
                dia = 1;
            }
            else if (mes == 5 && 1 <= dia && dia <= 30)
            {
                mesFinal = "Mayo";
                dia = dia + 1;
            }
            else if (mes == 5 && dia == 31)
            {
                mesFinal = "Junio";
                dia = 1;
            }
            else if (mes == 6 && 1 <= dia && dia <= 29)
            {
                mesFinal = "Junio";
                dia = dia + 1;
            }
            else if (mes == 6 && dia == 30)
            {
                mesFinal = "Julio";
                dia = 1;
            }
            else if (mes == 7 && 1 <= dia && dia <= 30)
            {
                mesFinal = "Julio";
                dia = dia + 1;
            }
            else if (mes == 7 && dia == 31)
            {
                mesFinal = "Agosto";
                dia = 1;
            }
            else if (mes == 8 && 1 <= dia && dia <= 30)
            {
                mesFinal = "Agosto";
                dia = dia + 1;
            }
            else if (mes == 8 && dia == 31)
            {
                mesFinal = "Septiembre";
                dia = 1;
            }
            else if (mes == 9 && 1 <= dia && dia <= 29)
            {
                mesFinal = "Septiembre";
                dia = dia + 1;
            }
            else if (mes == 9 && dia == 30)
            {
                mesFinal = "Octubre";
                dia = 1;
            }
            else if (mes == 10 && 1 <= dia && dia <= 30)
            {
                mesFinal = "octubre";
                dia = dia + 1;
            }
            else if (mes == 10 && dia == 31)
            {
                mesFinal = "Noviembre";
                dia = 1;
            }
            else if (mes == 11 && 1 <= dia && dia <= 29)
            {
                mesFinal = "noviembre";
                dia = dia + 1;
            }
            else if (mes == 11 && dia == 30)
            {
                mesFinal = "Diciembre";
                dia = 1;
            }
            else if (mes == 12 && 1 <= dia && dia <= 30)
            {
                mesFinal = "diciembre";
                dia = dia + 1;
            }
            else if (mes == 12 && dia == 31)
            {
                mesFinal = "Enero";
                dia = 1;
                año = año + 1;
            }
            else
            {
                MessageBox.Show(this, ERROR_FECHA, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = false;
            }

            

            if (i == true)
            {
                lblFecha.Text = Convert.ToString(dia) + " de " + mesFinal + " de " + año;
            } 
        }
    }
}
