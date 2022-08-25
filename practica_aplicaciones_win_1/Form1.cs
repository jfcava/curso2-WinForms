using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_aplicaciones_win_1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau...");
        }

        
        
        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Mostramos un Mensaje con MessageBox.Show.
            //MessageBox.Show("Se disparo el evento Click", "Atención");

            // Al dispararse el evento Click, se cambie el color del Formulario. 
            //this.BackColor = Color.PapayaWhip;

            // En el evento Click del botón creado anteriormente, cancelamos las líneas de código
            // anteriores y colocamos el código para cambiar el color de fondo del TextBox
            // (Propiedad BackColor) si el TextBox se encuentra vació.

            if(txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }else
            {
                // Toma el color original del control-
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            }
        }


        // Manejar el evento Click del Formulario. Determinar que botón del Mouse se pulso.
        private void frmInicio_Click(object sender, EventArgs e)
        {
            MouseEventArgs evento = (MouseEventArgs)e;

            if(evento.Button == MouseButtons.Left)
            {
                MessageBox.Show("Apretaste el click izquierdo!");
            }else if(evento.Button == MouseButtons.Right)
            {
                MessageBox.Show("Apretaste el click derecho!");
            }else
            {
                MessageBox.Show("Apretaste el click del medio!");
            }
        }

        // Manejar el evento MouseMove del Control Label. En la ventana de eventos elijo
        // MouseMove.
        // Cambiamos el color de la propiedad BackColor.

        private void frmInicio_MouseMove(object sender, MouseEventArgs e)
        {
            lblTitulo.BackColor = Color.BlueViolet;

            // Cambiar el estilo del cursor al dispararse los eventos MouseMove y MouseLeave.    
            lblTitulo.Cursor = Cursors.Hand;
        }

        // Al dispararse el evento MouseLeave, se restablezca el color de fondo de la etiqueta. 
        private void lblTitulo_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.BackColor = System.Drawing.SystemColors.Window;
            // Cambiar el estilo del cursor al dispararse los eventos MouseMove y MouseLeave.           
            lblTitulo.Cursor = Cursors.Arrow;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtMultiline_Leave(object sender, EventArgs e)
        {
            // Manejar el evento Leave del nuevo Control TextBox. Para mostrar cuantos
            // caracteres se ingresaron una vez que el control pierde el foco.
            MessageBox.Show("Tiene " + txtMultiline.Text.Length + " Caracteres");
        }
    }
}
