using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace GestionCalificaciones
{
    public partial class Form1 : Form
    {   //lista de alumnos
        private List<alumno> alumnos = new List<alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void agg_Click(object sender, EventArgs e)
        {
            string dni = dn.Text;
            string nombre = nom.Text;
            string apellido = ape.Text;
            if (!int.TryParse(notas.Text, out int nota))
            {
                MessageBox.Show("Ingrese una nota válida.");
                return;
            }
            //creamos si el alumno tiene ya un dni registrado
            if (alumnos.Any(a => a.dn =dni ))
            {
                MessageBox.Show("El alumno con este DNI ya existe D:");
                return;
            }

            alumno nuevoAlumno = new alumno(nombre, apellido, dni, nota);
            alumnos.Add(nuevoAlumno);
            cali.Text = nuevoAlumno.calificacion; 
            MessageBox.Show("Alumno agregado correctamente.");
        }

        private void btnAprobados_Click(object sender, EventArgs e)
        {// si es mauor a 7 aprueba
            var aprobados = alumnos.Where(a => a.nota >=7).ToList();
            MostrarLista(alumnos.Where(a => a.nota >=7).ToList(), "Alumnos Aprobados");
        }

        private void btnSuspendidos_Click(object sender, EventArgs e)
        {   //si es menor a 6.99
            var suspendidos = alumnos.Where(a => a.nota < 6.99).ToList();
            MostrarLista(alumnos.Where(a => a.nota < 6.99).ToList(), "Alumnos Suspendidos");
        }
        //si no hay alumnos en los campos
        private void MostrarLista(List<alumno> lista, string titulo)
        {
            string mensaje = lista.Count > 0 ? string.Join("\n", lista) : "No hay alumnos alumnos en esta seccion.";
            MessageBox.Show(mensaje, titulo);
        }
    }
}

