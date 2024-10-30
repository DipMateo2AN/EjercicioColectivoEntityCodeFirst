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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtPatente = new TextBox();
            txtNombre = new TextBox();
            numCantidadAsientos = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregarColectivo = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtApellido = new TextBox();
            txtNombrePasajero = new TextBox();
            txtLegajo = new TextBox();
            txtDNI = new TextBox();
            label7 = new Label();
            rbtnSiEstudiante = new RadioButton();
            rbtnNoEstudiante = new RadioButton();
            label8 = new Label();
            btnAgregarPasajero = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadAsientos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(325, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(463, 115);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(325, 337);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(463, 115);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(325, 32);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(463, 115);
            dataGridView3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarColectivo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numCantidadAsientos);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtPatente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 163);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos colectivo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregarPasajero);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(rbtnNoEstudiante);
            groupBox2.Controls.Add(rbtnSiEstudiante);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtLegajo);
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNombrePasajero);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 271);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Pasajero";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(148, 22);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // numCantidadAsientos
            // 
            numCantidadAsientos.Location = new Point(148, 91);
            numCantidadAsientos.Name = "numCantidadAsientos";
            numCantidadAsientos.Size = new Size(100, 23);
            numCantidadAsientos.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
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
            // btnAgregarColectivo
            // 
            btnAgregarColectivo.Location = new Point(173, 134);
            btnAgregarColectivo.Name = "btnAgregarColectivo";
            btnAgregarColectivo.Size = new Size(75, 23);
            btnAgregarColectivo.TabIndex = 5;
            btnAgregarColectivo.Text = "Agregar";
            btnAgregarColectivo.UseVisualStyleBackColor = true;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 67);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 7;
            label5.Text = "Apellido";
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
            // txtApellido
            // 
            txtApellido.Location = new Point(148, 62);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtNombrePasajero
            // 
            txtNombrePasajero.Location = new Point(148, 33);
            txtNombrePasajero.Name = "txtNombrePasajero";
            txtNombrePasajero.Size = new Size(100, 23);
            txtNombrePasajero.TabIndex = 6;
            // 
            // txtLegajo
            // 
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 189);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 11;
            label7.Text = "Legajo";
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
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Location = new Point(173, 232);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(75, 23);
            btnAgregarPasajero.TabIndex = 6;
            btnAgregarPasajero.Text = "Agregar";
            btnAgregarPasajero.UseVisualStyleBackColor = true;
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
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadAsientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private TextBox txtPatente;
        private GroupBox groupBox2;
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
    }
}
