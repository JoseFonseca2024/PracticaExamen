namespace PRACTICAeXAMEN
{
    partial class VerRegistro
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
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Dirección = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apellidos, Nombres, FechaNacimiento, Dirección, Telefono });
            dataGridView1.Location = new Point(13, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(676, 384);
            dataGridView1.TabIndex = 0;
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
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dirección";
            Dirección.Name = "Dirección";
            Dirección.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // VerRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 404);
            Controls.Add(dataGridView1);
            Name = "VerRegistro";
            Text = "VerRegistro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Telefono;
    }
}