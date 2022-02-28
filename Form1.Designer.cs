namespace Ejemplo3E
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
            this.textBoxDpi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonCuentas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DPI";
            // 
            // textBoxDpi
            // 
            this.textBoxDpi.Location = new System.Drawing.Point(182, 136);
            this.textBoxDpi.Name = "textBoxDpi";
            this.textBoxDpi.Size = new System.Drawing.Size(175, 20);
            this.textBoxDpi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(182, 208);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(280, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(182, 292);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(280, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(182, 364);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 7;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(105, 479);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(200, 72);
            this.buttonIngresar.TabIndex = 8;
            this.buttonIngresar.Text = "Ingresar Datos";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 31);
            this.label7.TabIndex = 12;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(358, 479);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(186, 72);
            this.buttonMostrar.TabIndex = 17;
            this.buttonMostrar.Text = "Mostrar los Datos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonCuentas
            // 
            this.buttonCuentas.Location = new System.Drawing.Point(1020, 486);
            this.buttonCuentas.Name = "buttonCuentas";
            this.buttonCuentas.Size = new System.Drawing.Size(161, 65);
            this.buttonCuentas.TabIndex = 18;
            this.buttonCuentas.Text = "Ir a Cuentas";
            this.buttonCuentas.UseVisualStyleBackColor = true;
            this.buttonCuentas.Click += new System.EventHandler(this.buttonCuentas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(584, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 310);
            this.dataGridView1.TabIndex = 19;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(597, 479);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(177, 72);
            this.buttonGuardar.TabIndex = 20;
            this.buttonGuardar.Text = "Guardar Datos";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(803, 479);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(161, 72);
            this.buttonCargar.TabIndex = 21;
            this.buttonCargar.Text = "Cargar Datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 606);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCuentas);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDpi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDpi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonCuentas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCargar;
    }
}

