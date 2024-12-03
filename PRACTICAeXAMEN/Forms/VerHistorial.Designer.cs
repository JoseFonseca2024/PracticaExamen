namespace PRACTICAeXAMEN.Forms
{
    partial class VerHistorial
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
            dataGridView1 = new DataGridView();
            Apellidos = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            FechadeNacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            Altura = new DataGridViewTextBoxColumn();
            MotivodeConsulta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apellidos, Nombres, FechadeNacimiento, Sexo, Peso, Altura, MotivodeConsulta });
            dataGridView1.Location = new Point(12, 10);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(677, 382);
            dataGridView1.TabIndex = 1;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            Nombres.ReadOnly = true;
            // 
            // FechadeNacimiento
            // 
            FechadeNacimiento.HeaderText = "Fecha de Nacimiento";
            FechadeNacimiento.Name = "FechadeNacimiento";
            FechadeNacimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // Peso
            // 
            Peso.HeaderText = "Peso";
            Peso.Name = "Peso";
            Peso.ReadOnly = true;
            // 
            // Altura
            // 
            Altura.HeaderText = "Altura";
            Altura.Name = "Altura";
            Altura.ReadOnly = true;
            // 
            // MotivodeConsulta
            // 
            MotivodeConsulta.HeaderText = "Motivo de Consulta";
            MotivodeConsulta.Name = "MotivodeConsulta";
            MotivodeConsulta.ReadOnly = true;
            // 
            // VerHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 404);
            Controls.Add(dataGridView1);
            Name = "VerHistorial";
            Text = "VerHistorial";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn FechadeNacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Altura;
        private DataGridViewTextBoxColumn MotivodeConsulta;
    }
}