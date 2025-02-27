namespace GestionCalificaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gestor = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.notas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.ape = new System.Windows.Forms.TextBox();
            this.dn = new System.Windows.Forms.TextBox();
            this.nota = new System.Windows.Forms.TextBox();
            this.cali = new System.Windows.Forms.TextBox();
            this.agg = new System.Windows.Forms.Button();
            this.btnAprobados_Clic = new System.Windows.Forms.Button();
            this.btnSuspendidos_Clic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gestor
            // 
            this.gestor.AutoSize = true;
            this.gestor.Location = new System.Drawing.Point(105, 29);
            this.gestor.Name = "gestor";
            this.gestor.Size = new System.Drawing.Size(125, 13);
            this.gestor.TabIndex = 0;
            this.gestor.Text = "Gestion de calificaciones";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(40, 75);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(42, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "nombre";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(39, 126);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(43, 13);
            this.apellido.TabIndex = 2;
            this.apellido.Text = "apellido";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(40, 178);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(26, 13);
            this.dni.TabIndex = 3;
            this.dni.Text = "DNI";
            // 
            // notas
            // 
            this.notas.AutoSize = true;
            this.notas.Location = new System.Drawing.Point(40, 240);
            this.notas.Name = "notas";
            this.notas.Size = new System.Drawing.Size(33, 13);
            this.notas.TabIndex = 4;
            this.notas.Text = "notas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "calificacion";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(99, 75);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 6;
            // 
            // ape
            // 
            this.ape.Location = new System.Drawing.Point(108, 123);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(100, 20);
            this.ape.TabIndex = 7;
            // 
            // dn
            // 
            this.dn.Location = new System.Drawing.Point(99, 175);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(100, 20);
            this.dn.TabIndex = 8;
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(108, 237);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(100, 20);
            this.nota.TabIndex = 9;
            // 
            // cali
            // 
            this.cali.Location = new System.Drawing.Point(108, 296);
            this.cali.Name = "cali";
            this.cali.Size = new System.Drawing.Size(100, 20);
            this.cali.TabIndex = 10;
            // 
            // agg
            // 
            this.agg.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.agg.Location = new System.Drawing.Point(99, 348);
            this.agg.Name = "agg";
            this.agg.Size = new System.Drawing.Size(75, 23);
            this.agg.TabIndex = 11;
            this.agg.Text = "agregar";
            this.agg.UseVisualStyleBackColor = true;
            // 
            // btnAprobados_Clic
            // 
            this.btnAprobados_Clic.Location = new System.Drawing.Point(254, 239);
            this.btnAprobados_Clic.Name = "btnAprobados_Clic";
            this.btnAprobados_Clic.Size = new System.Drawing.Size(78, 29);
            this.btnAprobados_Clic.TabIndex = 12;
            this.btnAprobados_Clic.Text = "aprobados";
            this.btnAprobados_Clic.UseVisualStyleBackColor = true;
            // 
            // btnSuspendidos_Clic
            // 
            this.btnSuspendidos_Clic.Location = new System.Drawing.Point(257, 296);
            this.btnSuspendidos_Clic.Name = "btnSuspendidos_Clic";
            this.btnSuspendidos_Clic.Size = new System.Drawing.Size(75, 23);
            this.btnSuspendidos_Clic.TabIndex = 13;
            this.btnSuspendidos_Clic.Text = "suspendido";
            this.btnSuspendidos_Clic.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.btnSuspendidos_Clic);
            this.Controls.Add(this.btnAprobados_Clic);
            this.Controls.Add(this.agg);
            this.Controls.Add(this.cali);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.dn);
            this.Controls.Add(this.ape);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notas);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.gestor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gestor;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label notas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox ape;
        private System.Windows.Forms.TextBox dn;
        private System.Windows.Forms.TextBox nota;
        private System.Windows.Forms.TextBox cali;
        private System.Windows.Forms.Button agg;
        private System.Windows.Forms.Button btnAprobados_Clic;
        private System.Windows.Forms.Button btnSuspendidos_Clic;
    }
}

