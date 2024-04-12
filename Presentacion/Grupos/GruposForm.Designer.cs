namespace Presentacion.Grupos
{
    partial class GruposForm
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
            GruposGrid = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Grado = new DataGridViewTextBoxColumn();
            NuevoGrupoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)GruposGrid).BeginInit();
            SuspendLayout();
            // 
            // GruposGrid
            // 
            GruposGrid.AllowUserToAddRows = false;
            GruposGrid.AllowUserToDeleteRows = false;
            GruposGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GruposGrid.Columns.AddRange(new DataGridViewColumn[] { Nombre, Grado });
            GruposGrid.Location = new Point(21, 21);
            GruposGrid.Name = "GruposGrid";
            GruposGrid.ReadOnly = true;
            GruposGrid.RowTemplate.Height = 25;
            GruposGrid.Size = new Size(249, 282);
            GruposGrid.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Grado
            // 
            Grado.DataPropertyName = "Grado";
            Grado.HeaderText = "Grado";
            Grado.Name = "Grado";
            Grado.ReadOnly = true;
            // 
            // NuevoGrupoButton
            // 
            NuevoGrupoButton.Location = new Point(195, 310);
            NuevoGrupoButton.Name = "NuevoGrupoButton";
            NuevoGrupoButton.Size = new Size(75, 23);
            NuevoGrupoButton.TabIndex = 1;
            NuevoGrupoButton.Text = "Nuevo";
            NuevoGrupoButton.UseVisualStyleBackColor = true;
            NuevoGrupoButton.Click += NuevoGrupoButton_Click;
            // 
            // GruposForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 345);
            Controls.Add(NuevoGrupoButton);
            Controls.Add(GruposGrid);
            Name = "GruposForm";
            Text = "Grupos";
            Load += GruposForm_Load;
            ((System.ComponentModel.ISupportInitialize)GruposGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GruposGrid;
        private Button NuevoGrupoButton;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Grado;
    }
}