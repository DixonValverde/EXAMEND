namespace Examen_final
{
    partial class Form1
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
            this.mostrar_alumnos = new System.Windows.Forms.Button();
            this.introducir_alumno = new System.Windows.Forms.Button();
            this.editar_alumno_btn = new System.Windows.Forms.Button();
            this.buscar_editar_eliminar_btn = new System.Windows.Forms.TextBox();
            this.eliminar_alumno_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar_alumno_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mostrar_alumnos
            // 
            this.mostrar_alumnos.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar_alumnos.ForeColor = System.Drawing.Color.Black;
            this.mostrar_alumnos.Location = new System.Drawing.Point(74, 171);
            this.mostrar_alumnos.Name = "mostrar_alumnos";
            this.mostrar_alumnos.Size = new System.Drawing.Size(246, 27);
            this.mostrar_alumnos.TabIndex = 0;
            this.mostrar_alumnos.Text = "Mostrar alumnos";
            this.mostrar_alumnos.UseVisualStyleBackColor = true;
            this.mostrar_alumnos.Click += new System.EventHandler(this.mostrar_alumnos_Click);
            // 
            // introducir_alumno
            // 
            this.introducir_alumno.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introducir_alumno.ForeColor = System.Drawing.Color.Black;
            this.introducir_alumno.Location = new System.Drawing.Point(74, 80);
            this.introducir_alumno.Name = "introducir_alumno";
            this.introducir_alumno.Size = new System.Drawing.Size(246, 26);
            this.introducir_alumno.TabIndex = 1;
            this.introducir_alumno.Text = "Introduzca un alumno que desee";
            this.introducir_alumno.UseVisualStyleBackColor = true;
            this.introducir_alumno.Click += new System.EventHandler(this.introducir_alumno_Click);
            // 
            // editar_alumno_btn
            // 
            this.editar_alumno_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editar_alumno_btn.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_alumno_btn.Location = new System.Drawing.Point(126, 388);
            this.editar_alumno_btn.Name = "editar_alumno_btn";
            this.editar_alumno_btn.Size = new System.Drawing.Size(110, 31);
            this.editar_alumno_btn.TabIndex = 3;
            this.editar_alumno_btn.Text = "Editar";
            this.editar_alumno_btn.UseVisualStyleBackColor = true;
            this.editar_alumno_btn.Click += new System.EventHandler(this.editar_eliminar_alumno_Click);
            // 
            // buscar_editar_eliminar_btn
            // 
            this.buscar_editar_eliminar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_editar_eliminar_btn.Location = new System.Drawing.Point(57, 309);
            this.buscar_editar_eliminar_btn.Margin = new System.Windows.Forms.Padding(4);
            this.buscar_editar_eliminar_btn.Name = "buscar_editar_eliminar_btn";
            this.buscar_editar_eliminar_btn.Size = new System.Drawing.Size(281, 20);
            this.buscar_editar_eliminar_btn.TabIndex = 4;
            this.buscar_editar_eliminar_btn.Text = "solo numeros";
            // 
            // eliminar_alumno_btn
            // 
            this.eliminar_alumno_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.eliminar_alumno_btn.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_alumno_btn.Location = new System.Drawing.Point(126, 425);
            this.eliminar_alumno_btn.Name = "eliminar_alumno_btn";
            this.eliminar_alumno_btn.Size = new System.Drawing.Size(110, 31);
            this.eliminar_alumno_btn.TabIndex = 5;
            this.eliminar_alumno_btn.Text = "Eliminar";
            this.eliminar_alumno_btn.UseVisualStyleBackColor = true;
            this.eliminar_alumno_btn.Click += new System.EventHandler(this.eliminar_alumno_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(33, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Secccion buscar editar y eliminar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "escribe un numero que deseas buscar(dni)";
            // 
            // buscar_alumno_btn
            // 
            this.buscar_alumno_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buscar_alumno_btn.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_alumno_btn.Location = new System.Drawing.Point(126, 351);
            this.buscar_alumno_btn.Name = "buscar_alumno_btn";
            this.buscar_alumno_btn.Size = new System.Drawing.Size(110, 31);
            this.buscar_alumno_btn.TabIndex = 8;
            this.buscar_alumno_btn.Text = "Buscar";
            this.buscar_alumno_btn.UseVisualStyleBackColor = true;
            this.buscar_alumno_btn.Click += new System.EventHandler(this.buscar_alumno_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bienvenido a gestion de alumnos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(77, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seccion de mostrar alumnos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(452, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscar_alumno_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar_alumno_btn);
            this.Controls.Add(this.buscar_editar_eliminar_btn);
            this.Controls.Add(this.editar_alumno_btn);
            this.Controls.Add(this.introducir_alumno);
            this.Controls.Add(this.mostrar_alumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestion alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrar_alumnos;
        private System.Windows.Forms.Button introducir_alumno;
        private System.Windows.Forms.Button editar_alumno_btn;
        private System.Windows.Forms.TextBox buscar_editar_eliminar_btn;
        private System.Windows.Forms.Button eliminar_alumno_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar_alumno_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

