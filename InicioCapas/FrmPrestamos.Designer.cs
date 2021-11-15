
namespace InicioCapas
{
    partial class FrmPrestamos
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
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFechaN = new System.Windows.Forms.TextBox();
            this.txtAp2 = new System.Windows.Forms.TextBox();
            this.txtAp1 = new System.Windows.Forms.TextBox();
            this.txtNomUsu = new System.Windows.Forms.TextBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtClaveE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.dgvLib = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtClavPres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLib)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Location = new System.Drawing.Point(720, 46);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(214, 20);
            this.dtpDevolucion.TabIndex = 0;
            this.dtpDevolucion.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(180, 49);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(131, 20);
            this.txtClave.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite la clave de usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(439, 79);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(99, 385);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(239, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 343);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtFechaN
            // 
            this.txtFechaN.Location = new System.Drawing.Point(99, 301);
            this.txtFechaN.Name = "txtFechaN";
            this.txtFechaN.Size = new System.Drawing.Size(239, 20);
            this.txtFechaN.TabIndex = 6;
            // 
            // txtAp2
            // 
            this.txtAp2.Location = new System.Drawing.Point(99, 259);
            this.txtAp2.Name = "txtAp2";
            this.txtAp2.Size = new System.Drawing.Size(239, 20);
            this.txtAp2.TabIndex = 7;
            // 
            // txtAp1
            // 
            this.txtAp1.Location = new System.Drawing.Point(99, 218);
            this.txtAp1.Name = "txtAp1";
            this.txtAp1.Size = new System.Drawing.Size(239, 20);
            this.txtAp1.TabIndex = 8;
            // 
            // txtNomUsu
            // 
            this.txtNomUsu.Location = new System.Drawing.Point(99, 177);
            this.txtNomUsu.Name = "txtNomUsu";
            this.txtNomUsu.Size = new System.Drawing.Size(239, 20);
            this.txtNomUsu.TabIndex = 9;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(363, 137);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(571, 44);
            this.dgvLibros.TabIndex = 12;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(473, 49);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(213, 20);
            this.dtpEntrega.TabIndex = 15;
            // 
            // txtClaveE
            // 
            this.txtClaveE.Location = new System.Drawing.Point(15, 49);
            this.txtClaveE.Name = "txtClaveE";
            this.txtClaveE.Size = new System.Drawing.Size(131, 20);
            this.txtClaveE.TabIndex = 17;
            this.txtClaveE.TextChanged += new System.EventHandler(this.txtClaveLibro_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 22);
            this.button3.TabIndex = 20;
            this.button3.Text = "Buscar Ejemplar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvLibro
            // 
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Location = new System.Drawing.Point(363, 269);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.Size = new System.Drawing.Size(570, 136);
            this.dgvLibro.TabIndex = 21;
            // 
            // dgvLib
            // 
            this.dgvLib.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLib.Location = new System.Drawing.Point(364, 203);
            this.dgvLib.Name = "dgvLib";
            this.dgvLib.Size = new System.Drawing.Size(570, 47);
            this.dgvLib.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 22);
            this.button4.TabIndex = 23;
            this.button4.Text = "Buscar Usuario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Digite la clave de un ejemplar";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(99, 137);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(239, 20);
            this.txtCurp.TabIndex = 25;
            // 
            // txtClavPres
            // 
            this.txtClavPres.Location = new System.Drawing.Point(345, 49);
            this.txtClavPres.Name = "txtClavPres";
            this.txtClavPres.Size = new System.Drawing.Size(80, 20);
            this.txtClavPres.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Clave Prestamo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Clave Prestamo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Clave Prestamo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Clave Prestamo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Clave Prestamo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Clave Prestamo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Clave Prestamo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Clave Prestamo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(717, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Clave Prestamo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Clave Prestamo";
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 458);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClavPres);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvLib);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtClaveE);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.txtNomUsu);
            this.Controls.Add(this.txtAp1);
            this.Controls.Add(this.txtAp2);
            this.Controls.Add(this.txtFechaN);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.dtpDevolucion);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFechaN;
        private System.Windows.Forms.TextBox txtAp2;
        private System.Windows.Forms.TextBox txtAp1;
        private System.Windows.Forms.TextBox txtNomUsu;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.TextBox txtClaveE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.DataGridView dgvLib;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtClavPres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}