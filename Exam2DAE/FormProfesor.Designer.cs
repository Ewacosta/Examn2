namespace Exam2DAE
{
    partial class FormProfesor
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
            groupBox1 = new GroupBox();
            lblEdad = new Label();
            dateTimePicker1 = new DateTimePicker();
            textSalario = new TextBox();
            textCarrera = new TextBox();
            textTitulo = new TextBox();
            textApellidos = new TextBox();
            textNombres = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblEdad);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textSalario);
            groupBox1.Controls.Add(textCarrera);
            groupBox1.Controls.Add(textTitulo);
            groupBox1.Controls.Add(textApellidos);
            groupBox1.Controls.Add(textNombres);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profesor";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(349, 91);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(0, 15);
            lblEdad.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textSalario
            // 
            textSalario.Location = new Point(108, 171);
            textSalario.Name = "textSalario";
            textSalario.Size = new Size(90, 23);
            textSalario.TabIndex = 12;
            // 
            // textCarrera
            // 
            textCarrera.Location = new Point(108, 142);
            textCarrera.Name = "textCarrera";
            textCarrera.Size = new Size(187, 23);
            textCarrera.TabIndex = 11;
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(71, 114);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(187, 23);
            textTitulo.TabIndex = 10;
            // 
            // textApellidos
            // 
            textApellidos.Location = new Point(71, 56);
            textApellidos.Name = "textApellidos";
            textApellidos.Size = new Size(187, 23);
            textApellidos.TabIndex = 9;
            // 
            // textNombres
            // 
            textNombres.Location = new Point(71, 27);
            textNombres.Name = "textNombres";
            textNombres.Size = new Size(187, 23);
            textNombres.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(307, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 91);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 174);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Salario:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 145);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 4;
            label5.Text = "Carrera asignada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 121);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Titulo:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de nacimiento:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            label1.Click += label1_Click;
            // 
            // FormProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 253);
            Controls.Add(groupBox1);
            Name = "FormProfesor";
            Text = "FormProfesor";
            Load += FormProfesor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox textCarrera;
        private TextBox textTitulo;
        private TextBox textApellidos;
        private TextBox textNombres;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textSalario;
        private Label lblEdad;
    }
}