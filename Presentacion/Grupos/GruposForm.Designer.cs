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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            GruposLabel = new ReaLTaiizor.Controls.MaterialLabel();
            CrearGrupoButton = new ReaLTaiizor.Controls.MaterialButton();
            GruposGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            HorarioAsignado = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Grado = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            VerHorario = new DataGridViewButtonColumn();
            AsignarHorario = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GruposGrid).BeginInit();
            SuspendLayout();
            // 
            // GruposLabel
            // 
            GruposLabel.AutoSize = true;
            GruposLabel.Depth = 0;
            GruposLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            GruposLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            GruposLabel.Location = new Point(16, 10);
            GruposLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            GruposLabel.Name = "GruposLabel";
            GruposLabel.Padding = new Padding(16);
            GruposLabel.Size = new Size(111, 41);
            GruposLabel.TabIndex = 0;
            GruposLabel.Text = "Grupos";
            // 
            // CrearGrupoButton
            // 
            CrearGrupoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CrearGrupoButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            CrearGrupoButton.Depth = 0;
            CrearGrupoButton.HighEmphasis = true;
            CrearGrupoButton.Icon = null;
            CrearGrupoButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            CrearGrupoButton.Location = new Point(566, 19);
            CrearGrupoButton.Margin = new Padding(4, 6, 4, 6);
            CrearGrupoButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CrearGrupoButton.Name = "CrearGrupoButton";
            CrearGrupoButton.NoAccentTextColor = Color.Empty;
            CrearGrupoButton.Size = new Size(122, 36);
            CrearGrupoButton.TabIndex = 2;
            CrearGrupoButton.Text = "Nuevo Grupo";
            CrearGrupoButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            CrearGrupoButton.UseAccentColor = false;
            CrearGrupoButton.UseVisualStyleBackColor = true;
            CrearGrupoButton.Click += CrearGrupoButton_Click;
            // 
            // GruposGrid
            // 
            GruposGrid.AllowUserToAddRows = false;
            GruposGrid.AllowUserToDeleteRows = false;
            GruposGrid.AllowUserToResizeRows = false;
            GruposGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GruposGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            GruposGrid.BorderStyle = BorderStyle.None;
            GruposGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            GruposGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GruposGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GruposGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GruposGrid.Columns.AddRange(new DataGridViewColumn[] { HorarioAsignado, Id, Nombre, Grado, Eliminar, VerHorario, AsignarHorario });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GruposGrid.DefaultCellStyle = dataGridViewCellStyle2;
            GruposGrid.EnableHeadersVisualStyles = false;
            GruposGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            GruposGrid.GridColor = Color.FromArgb(255, 255, 255);
            GruposGrid.Location = new Point(16, 54);
            GruposGrid.Name = "GruposGrid";
            GruposGrid.ReadOnly = true;
            GruposGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            GruposGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            GruposGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            GruposGrid.RowTemplate.Height = 25;
            GruposGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GruposGrid.Size = new Size(672, 302);
            GruposGrid.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            GruposGrid.TabIndex = 3;
            GruposGrid.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            GruposGrid.VirtualMode = true;
            GruposGrid.CellContentClick += GruposGrid_CellContentClick;
            GruposGrid.CellFormatting += GruposGrid_CellFormatting;
            // 
            // HorarioAsignado
            // 
            HorarioAsignado.DataPropertyName = "HorarioAsignado";
            HorarioAsignado.HeaderText = "HorarioAsignado";
            HorarioAsignado.Name = "HorarioAsignado";
            HorarioAsignado.ReadOnly = true;
            HorarioAsignado.Visible = false;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
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
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // VerHorario
            // 
            VerHorario.HeaderText = "Ver Horario";
            VerHorario.Name = "VerHorario";
            VerHorario.ReadOnly = true;
            VerHorario.Resizable = DataGridViewTriState.True;
            VerHorario.SortMode = DataGridViewColumnSortMode.Automatic;
            VerHorario.Text = "Ver Horario";
            VerHorario.UseColumnTextForButtonValue = true;
            // 
            // AsignarHorario
            // 
            AsignarHorario.HeaderText = "Asignar Horario";
            AsignarHorario.Name = "AsignarHorario";
            AsignarHorario.ReadOnly = true;
            AsignarHorario.Resizable = DataGridViewTriState.True;
            AsignarHorario.SortMode = DataGridViewColumnSortMode.Automatic;
            AsignarHorario.Text = "Asignar Horario";
            AsignarHorario.UseColumnTextForButtonValue = true;
            // 
            // GruposForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 388);
            Controls.Add(GruposGrid);
            Controls.Add(CrearGrupoButton);
            Controls.Add(GruposLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "GruposForm";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Grupos";
            Load += GruposForm_Load;
            ((System.ComponentModel.ISupportInitialize)GruposGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel GruposLabel;
        private ReaLTaiizor.Controls.MaterialButton CrearGrupoButton;
        private ReaLTaiizor.Controls.PoisonDataGridView GruposGrid;
        private DataGridViewTextBoxColumn HorarioAsignado;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Grado;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewButtonColumn VerHorario;
        private DataGridViewButtonColumn AsignarHorario;
    }
}