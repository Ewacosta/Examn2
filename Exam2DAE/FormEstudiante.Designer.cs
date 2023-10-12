namespace Exam2DAE
{
    partial class FormEstudiante
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
            dateTimePicker2 = new DateTimePicker();
            textCarrera = new TextBox();
            textCum = new TextBox();
            textCiclo = new TextBox();
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
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(textCarrera);
            groupBox1.Controls.Add(textCum);
            groupBox1.Controls.Add(textCiclo);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 212);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estudiante";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(349, 91);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(0, 15);
            lblEdad.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(132, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(160, 23);
            dateTimePicker2.TabIndex = 13;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // textCarrera
            // 
            textCarrera.Location = new Point(71, 171);
            textCarrera.Name = "textCarrera";
            textCarrera.Size = new Size(221, 23);
            textCarrera.TabIndex = 12;
            // 
            // textCum
            // 
            textCum.Location = new Point(71, 143);
            textCum.Name = "textCum";
            textCum.Size = new Size(55, 23);
            textCum.TabIndex = 11;
            // 
            // textCiclo
            // 
            textCiclo.Location = new Point(71, 114);
            textCiclo.Name = "textCiclo";
            textCiclo.Size = new Size(55, 23);
            textCiclo.TabIndex = 10;
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
            textNombres.TextChanged += textNombres_TextChanged;
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
            label6.Text = "Carrera";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 145);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 4;
            label5.Text = "CUM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 121);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Ciclo";
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // FormEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 240);
            Controls.Add(groupBox1);
            Name = "FormEstudiante";
            Text = "FormEstudiante";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblEdad;
        private DateTimePicker dateTimePicker2;
        private TextBox textCarrera;
        private TextBox textCum;
        private TextBox textCiclo;
        private TextBox textApellidos;
        private TextBox textNombres;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}