namespace EXAMENDIXON
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
            this.label1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.nota = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lista = new System.Windows.Forms.Button();
            this.aprobado = new System.Windows.Forms.Button();
            this.suspendido = new System.Windows.Forms.Button();
            this.candidato = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.modificacion = new System.Windows.Forms.Button();
            this.elimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestor de calificaciones";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(17, 106);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(144, 19);
            this.l.TabIndex = 1;
            this.l.Text = "Ingrese nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese dni:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese nota:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(187, 106);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 5;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(187, 162);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 6;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(187, 224);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 7;
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(187, 287);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(100, 20);
            this.nota.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(354, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(462, 225);
            this.listBox1.TabIndex = 9;
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lista.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.Location = new System.Drawing.Point(354, 77);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(71, 23);
            this.lista.TabIndex = 10;
            this.lista.Text = "mostrar lista";
            this.lista.UseVisualStyleBackColor = false;
            this.lista.Click += new System.EventHandler(this.lista_Click);
            // 
            // aprobado
            // 
            this.aprobado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aprobado.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprobado.Location = new System.Drawing.Point(449, 77);
            this.aprobado.Name = "aprobado";
            this.aprobado.Size = new System.Drawing.Size(71, 23);
            this.aprobado.TabIndex = 11;
            this.aprobado.Text = "aprobados";
            this.aprobado.UseVisualStyleBackColor = false;
            this.aprobado.Click += new System.EventHandler(this.aprobado_Click);
            // 
            // suspendido
            // 
            this.suspendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.suspendido.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendido.ForeColor = System.Drawing.Color.White;
            this.suspendido.Location = new System.Drawing.Point(549, 77);
            this.suspendido.Name = "suspendido";
            this.suspendido.Size = new System.Drawing.Size(104, 23);
            this.suspendido.TabIndex = 12;
            this.suspendido.Text = "suspendidos";
            this.suspendido.UseVisualStyleBackColor = false;
            this.suspendido.Click += new System.EventHandler(this.suspendido_Click);
            // 
            // candidato
            // 
            this.candidato.BackColor = System.Drawing.Color.Yellow;
            this.candidato.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidato.Location = new System.Drawing.Point(659, 77);
            this.candidato.Name = "candidato";
            this.candidato.Size = new System.Drawing.Size(157, 23);
            this.candidato.TabIndex = 13;
            this.candidato.Text = "candidato abanderado";
            this.candidato.UseVisualStyleBackColor = false;
            this.candidato.Click += new System.EventHandler(this.candidato_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.Lime;
            this.btnregistrar.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(42, 328);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(119, 35);
            this.btnregistrar.TabIndex = 14;
            this.btnregistrar.Text = "Regisrarse";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // modificacion
            // 
            this.modificacion.BackColor = System.Drawing.Color.Cyan;
            this.modificacion.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacion.Location = new System.Drawing.Point(187, 334);
            this.modificacion.Name = "modificacion";
            this.modificacion.Size = new System.Drawing.Size(106, 29);
            this.modificacion.TabIndex = 15;
            this.modificacion.Text = "modificar";
            this.modificacion.UseVisualStyleBackColor = false;
            this.modificacion.Click += new System.EventHandler(this.modificacion_Click);
            // 
            // elimina
            // 
            this.elimina.BackColor = System.Drawing.Color.Red;
            this.elimina.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elimina.Location = new System.Drawing.Point(109, 393);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(117, 32);
            this.elimina.TabIndex = 16;
            this.elimina.Text = "eliminar";
            this.elimina.UseVisualStyleBackColor = false;
            this.elimina.Click += new System.EventHandler(this.elimina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.modificacion);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.candidato);
            this.Controls.Add(this.suspendido);
            this.Controls.Add(this.aprobado);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox nota;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button lista;
        private System.Windows.Forms.Button aprobado;
        private System.Windows.Forms.Button suspendido;
        private System.Windows.Forms.Button candidato;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button modificacion;
        private System.Windows.Forms.Button elimina;
    }
}

