using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EXAMENDIXON
{
    public partial class Form1 : Form
    {
        public GestionCalificador crud = new GestionCalificador();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles (TextBox)
            string nombresI = nombre.Text; // Elimina espacios en blanco al inicio y fin
            string apellidosI = apellido.Text;
            string dniI = dni.Text;
            int notaI;
            string calificacion;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(nombresI))
            {
                MessageBox.Show("Por favor, ingrese el nombre.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(apellidosI))
            {
                MessageBox.Show("Por favor, ingrese los apellidos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(dniI))
            {
                MessageBox.Show("Por favor, ingrese el DNI.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //que sea la cedula 10
            if (dniI.Length != 10 || !dniI.All(char.IsDigit)) 
            {
                MessageBox.Show("El DNI debe contener exactamente 10 dígitos numéricos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(nota.Text, out notaI))
            {
                MessageBox.Show("Por favor, ingresa una nota válida.", "Error");
                return;
            }

            bool dniExistente = crud.DniExiste(dniI);

            if (dniExistente)
            {
                MessageBox.Show("El DNI ya está registrado. No se puede agregar otro registro con el mismo DNI.", "Error");
                return;
            }
            try
            {
                // Crear el calificador usando el CRUD si todas las validaciones pasan
                Calificador nuevaInfo = new Calificador(nombresI, apellidosI, dniI, notaI); 
                crud.CrearCalificador(nombresI, apellidosI, dniI, notaI); 
                MessageBox.Show("Datos agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los TextBox después de registrar (usar los controles TextBox directamente)
                nombre.Clear();
                apellido.Clear();
                dni.Clear();
                nota.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el calificador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
        
        private void lista_Click(object sender, EventArgs e)
            
        {
            listBox1.Items.Clear();
            

            foreach (var info in crud.calificadores)
            {
                listBox1.Items.Add($"|DNI: {info.dni} | Apellidos: {info.apellidos} | Nombres: {info.nombres} | Nota: {info.nota} | Calificación: {info.calificacion}");
            }
        }

        private void aprobado_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var info in crud.calificadores)
            {
                if (info.nota >= 7)
                {
                    listBox1.Items.Add($"-DNI: {info.dni} - Apellidos: {info.apellidos} - Nombres: {info.nombres} - Nota: {info.nota} | Calificación: {info.calificacion}");
                }
            }
        }

        private void suspendido_Click(object sender, EventArgs e)
        {
            listBox1 .Items.Clear();
            foreach(var info in crud.calificadores)
            {
                if(info.nota < 7)
                {
                    listBox1.Items.Add($" - DNI: {info.dni} - Apellidos: {info.apellidos} - Nombres: {info.nombres} - Nota: {info.nota} | Calificación: {info.calificacion}");
                }
            }
        }

        private void candidato_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var info in crud.calificadores)
            {
                if( info.nota == 10)
                {
                    listBox1.Items.Add($" - DNI: {info.dni} - Apellidos: {info.apellidos} - Nombres: {info.nombres} - Nota: {info.nota} | Calificación: {info.calificacion}");
                }
            }
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox y limpiarlos con Trim()
            string dniI = dni.Text.Trim(); // DNI del alumno a modificar
            int nuevaNota;

            // Validar que el DNI no esté vacío
            if (string.IsNullOrEmpty(dniI))
            {
                MessageBox.Show("Por favor, ingrese el DNI del alumno.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el DNI contenga solo números y tenga una longitud de 10
            if (dniI.Length != 10 || !dniI.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe contener exactamente 10 dígitos numéricos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la nueva nota sea un número entero válido (usando el TextBox "notas")
            if (!int.TryParse(nota.Text.Trim(), out nuevaNota)) 
            {
                MessageBox.Show("Por favor, ingrese una nota válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verificar que la nota esté en el rango correcto de 1 a 10
            if (nuevaNota < 1 || nuevaNota > 10)
            {
                MessageBox.Show("La nota debe estar entre 1 a  10.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verificar si el alumno existe antes de modificar
                Calificador calificador = crud.LeerPorDni(dniI);
                if (calificador == null)
                {
                    MessageBox.Show($"No se encontró un alumno con el DNI: {dni}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Modificar la nota usando el método ActualizarCalificador de GestionCalificador
                crud.ActualizarCalificador(dniI, nuevaNota);
                MessageBox.Show("Nota del alumno actualizada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar los TextBox después de modificar
                dni.Clear();
                nota.Clear(); // Ajusta a "nota.Clear()" si usas ese nombre
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            // Obtener el valor del DNI del TextBox y limpiarlo con Trim()
            string dniI = dni.Text.Trim();

            // Validar que el DNI no esté vacío
            if (string.IsNullOrEmpty(dniI))
            {
                MessageBox.Show("Por favor, ingrese el DNI del alumno.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el DNI contenga solo numeros y tenga una longitud de 10
            if (dniI.Length != 10 || !dniI.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe contener exactamente 10 dígitos numéricos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Verificar si el alumno existe antes de eliminar
                Calificador calificador = crud.LeerPorDni(dniI);
                if (calificador == null)
                {
                    MessageBox.Show($"No se encontró un alumno con el DNI: {dni}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eliminar el calificador usando el método EliminarCalificador de GestionCalificador
                crud.EliminarCalificador(dniI);
                MessageBox.Show("Alumno eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar el TextBox después de eliminar
                dni.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el alumno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
