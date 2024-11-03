namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPasajeros = new DataGridView();
            dgvPasajerosEstudiantes = new DataGridView();
            dgvColectivos = new DataGridView();
            gBoxColectivo = new GroupBox();
            btnEliminarColectivo = new Button();
            btnAgregarColectivo = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numCantidadAsientos = new NumericUpDown();
            txtNombre = new TextBox();
            txtPatente = new TextBox();
            gBoxPasajero = new GroupBox();
            btnEliminarPasajero = new Button();
            btnAgregarPasajero = new Button();
            label8 = new Label();
            rbtnNoEstudiante = new RadioButton();
            rbtnSiEstudiante = new RadioButton();
            label7 = new Label();
            txtLegajo = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            txtNombrePasajero = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPasajeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPasajerosEstudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvColectivos).BeginInit();
            gBoxColectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadAsientos).BeginInit();
            gBoxPasajero.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPasajeros
            // 
            dgvPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasajeros.Location = new Point(325, 181);
            dgvPasajeros.Name = "dgvPasajeros";
            dgvPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasajeros.Size = new Size(463, 115);
            dgvPasajeros.TabIndex = 0;
            // 
            // dgvPasajerosEstudiantes
            // 
            dgvPasajerosEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasajerosEstudiantes.Location = new Point(325, 337);
            dgvPasajerosEstudiantes.Name = "dgvPasajerosEstudiantes";
            dgvPasajerosEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasajerosEstudiantes.Size = new Size(463, 115);
            dgvPasajerosEstudiantes.TabIndex = 1;
            // 
            // dgvColectivos
            // 
            dgvColectivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColectivos.Location = new Point(325, 32);
            dgvColectivos.Name = "dgvColectivos";
            dgvColectivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvColectivos.Size = new Size(463, 115);
            dgvColectivos.TabIndex = 2;
            dgvColectivos.CellClick += dgvColectivos_CellClick;
            // 
            // gBoxColectivo
            // 
            gBoxColectivo.Controls.Add(btnEliminarColectivo);
            gBoxColectivo.Controls.Add(btnAgregarColectivo);
            gBoxColectivo.Controls.Add(label3);
            gBoxColectivo.Controls.Add(label2);
            gBoxColectivo.Controls.Add(label1);
            gBoxColectivo.Controls.Add(numCantidadAsientos);
            gBoxColectivo.Controls.Add(txtNombre);
            gBoxColectivo.Controls.Add(txtPatente);
            gBoxColectivo.Location = new Point(12, 12);
            gBoxColectivo.Name = "gBoxColectivo";
            gBoxColectivo.Size = new Size(265, 163);
            gBoxColectivo.TabIndex = 3;
            gBoxColectivo.TabStop = false;
            gBoxColectivo.Text = "Datos colectivo";
            // 
            // btnEliminarColectivo
            // 
            btnEliminarColectivo.Location = new Point(184, 134);
            btnEliminarColectivo.Name = "btnEliminarColectivo";
            btnEliminarColectivo.Size = new Size(75, 23);
            btnEliminarColectivo.TabIndex = 6;
            btnEliminarColectivo.Text = "Eliminar";
            btnEliminarColectivo.UseVisualStyleBackColor = true;
            btnEliminarColectivo.Click += btnEliminarColectivo_Click;
            // 
            // btnAgregarColectivo
            // 
            btnAgregarColectivo.Location = new Point(96, 134);
            btnAgregarColectivo.Name = "btnAgregarColectivo";
            btnAgregarColectivo.Size = new Size(75, 23);
            btnAgregarColectivo.TabIndex = 5;
            btnAgregarColectivo.Text = "Agregar";
            btnAgregarColectivo.UseVisualStyleBackColor = true;
            btnAgregarColectivo.Click += btnAgregarColectivo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 99);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "Cant asientos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Patente";
            // 
            // numCantidadAsientos
            // 
            numCantidadAsientos.Location = new Point(148, 91);
            numCantidadAsientos.Name = "numCantidadAsientos";
            numCantidadAsientos.Size = new Size(100, 23);
            numCantidadAsientos.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(148, 22);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 0;
            // 
            // gBoxPasajero
            // 
            gBoxPasajero.Controls.Add(btnEliminarPasajero);
            gBoxPasajero.Controls.Add(btnAgregarPasajero);
            gBoxPasajero.Controls.Add(label8);
            gBoxPasajero.Controls.Add(rbtnNoEstudiante);
            gBoxPasajero.Controls.Add(rbtnSiEstudiante);
            gBoxPasajero.Controls.Add(label7);
            gBoxPasajero.Controls.Add(txtLegajo);
            gBoxPasajero.Controls.Add(txtDNI);
            gBoxPasajero.Controls.Add(txtApellido);
            gBoxPasajero.Controls.Add(label4);
            gBoxPasajero.Controls.Add(txtNombrePasajero);
            gBoxPasajero.Controls.Add(label6);
            gBoxPasajero.Controls.Add(label5);
            gBoxPasajero.Enabled = false;
            gBoxPasajero.Location = new Point(12, 181);
            gBoxPasajero.Name = "gBoxPasajero";
            gBoxPasajero.Size = new Size(265, 271);
            gBoxPasajero.TabIndex = 4;
            gBoxPasajero.TabStop = false;
            gBoxPasajero.Text = "Datos Pasajero";
            // 
            // btnEliminarPasajero
            // 
            btnEliminarPasajero.Location = new Point(184, 226);
            btnEliminarPasajero.Name = "btnEliminarPasajero";
            btnEliminarPasajero.Size = new Size(75, 23);
            btnEliminarPasajero.TabIndex = 7;
            btnEliminarPasajero.Text = "Eliminar";
            btnEliminarPasajero.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Location = new Point(96, 226);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(75, 23);
            btnAgregarPasajero.TabIndex = 6;
            btnAgregarPasajero.Text = "Agregar";
            btnAgregarPasajero.UseVisualStyleBackColor = true;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 145);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 14;
            label8.Text = "Estudiante:";
            // 
            // rbtnNoEstudiante
            // 
            rbtnNoEstudiante.AutoSize = true;
            rbtnNoEstudiante.Location = new Point(205, 144);
            rbtnNoEstudiante.Name = "rbtnNoEstudiante";
            rbtnNoEstudiante.Size = new Size(43, 19);
            rbtnNoEstudiante.TabIndex = 13;
            rbtnNoEstudiante.TabStop = true;
            rbtnNoEstudiante.Text = "NO";
            rbtnNoEstudiante.UseVisualStyleBackColor = true;
            rbtnNoEstudiante.CheckedChanged += rbtnNoEstudiante_CheckedChanged;
            // 
            // rbtnSiEstudiante
            // 
            rbtnSiEstudiante.AutoSize = true;
            rbtnSiEstudiante.Location = new Point(148, 145);
            rbtnSiEstudiante.Name = "rbtnSiEstudiante";
            rbtnSiEstudiante.Size = new Size(34, 19);
            rbtnSiEstudiante.TabIndex = 12;
            rbtnSiEstudiante.TabStop = true;
            rbtnSiEstudiante.Text = "SI";
            rbtnSiEstudiante.UseVisualStyleBackColor = true;
            rbtnSiEstudiante.CheckedChanged += rbtnSiEstudiante_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 189);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 11;
            label7.Text = "Legajo";
            // 
            // txtLegajo
            // 
            txtLegajo.Enabled = false;
            txtLegajo.Location = new Point(148, 184);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 10;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(148, 97);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(148, 62);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 102);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "DNI:";
            // 
            // txtNombrePasajero
            // 
            txtNombrePasajero.Location = new Point(148, 33);
            txtNombrePasajero.Name = "txtNombrePasajero";
            txtNombrePasajero.Size = new Size(100, 23);
            txtNombrePasajero.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 33);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 6;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 67);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 7;
            label5.Text = "Apellido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(325, 9);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 6;
            label9.Text = "Colectivos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(325, 160);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 7;
            label10.Text = "Pasajeros";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(325, 319);
            label11.Name = "label11";
            label11.Size = new Size(119, 15);
            label11.TabIndex = 8;
            label11.Text = "Pasajeros estudiantes";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 465);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(btnSalir);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(gBoxPasajero);
            Controls.Add(gBoxColectivo);
            Controls.Add(dgvColectivos);
            Controls.Add(dgvPasajerosEstudiantes);
            Controls.Add(dgvPasajeros);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPasajeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPasajerosEstudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvColectivos).EndInit();
            gBoxColectivo.ResumeLayout(false);
            gBoxColectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadAsientos).EndInit();
            gBoxPasajero.ResumeLayout(false);
            gBoxPasajero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPasajeros;
        private DataGridView dgvPasajerosEstudiantes;
        private DataGridView dgvColectivos;
        private GroupBox gBoxColectivo;
        private TextBox txtNombre;
        private TextBox txtPatente;
        private GroupBox gBoxPasajero;
        private NumericUpDown numCantidadAsientos;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregarColectivo;
        private Label label7;
        private TextBox txtLegajo;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtNombrePasajero;
        private Label label6;
        private Label label5;
        private Label label8;
        private RadioButton rbtnNoEstudiante;
        private RadioButton rbtnSiEstudiante;
        private Button btnAgregarPasajero;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnSalir;
        private Button btnEliminarColectivo;
        private Button btnEliminarPasajero;
    }
}
