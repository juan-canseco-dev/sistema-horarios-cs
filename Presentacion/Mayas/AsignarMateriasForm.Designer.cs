namespace Presentacion.Mayas
{
    partial class AsignarMateriasForm
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
            GradoLabel = new ReaLTaiizor.Controls.MaterialLabel();
            MateriasGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            HorasSemanales = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            AgregarMateriaButton = new ReaLTaiizor.Controls.MaterialButton();
            NumeroMateriasLabel = new ReaLTaiizor.Controls.MaterialLabel();
            NumeroHorasLabel = new ReaLTaiizor.Controls.MaterialLabel();
            AsignarButton = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)MateriasGridView).BeginInit();
            SuspendLayout();
            // 
            // GradoLabel
            // 
            GradoLabel.AutoSize = true;
            GradoLabel.Depth = 0;
            GradoLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            GradoLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            GradoLabel.Location = new Point(22, 79);
            GradoLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            GradoLabel.Name = "GradoLabel";
            GradoLabel.Size = new Size(381, 41);
            GradoLabel.TabIndex = 0;
            GradoLabel.Text = "Materias - Primero Grado";
            // 
            // MateriasGridView
            // 
            MateriasGridView.AllowUserToAddRows = false;
            MateriasGridView.AllowUserToDeleteRows = false;
            MateriasGridView.AllowUserToResizeRows = false;
            MateriasGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MateriasGridView.BackgroundColor = Color.FromArgb(255, 255, 255);
            MateriasGridView.BorderStyle = BorderStyle.None;
            MateriasGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            MateriasGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MateriasGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MateriasGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MateriasGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Nombre, HorasSemanales, Eliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MateriasGridView.DefaultCellStyle = dataGridViewCellStyle2;
            MateriasGridView.EnableHeadersVisualStyles = false;
            MateriasGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            MateriasGridView.GridColor = Color.FromArgb(255, 255, 255);
            MateriasGridView.Location = new Point(22, 123);
            MateriasGridView.MultiSelect = false;
            MateriasGridView.Name = "MateriasGridView";
            MateriasGridView.ReadOnly = true;
            MateriasGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            MateriasGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MateriasGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            MateriasGridView.RowTemplate.Height = 25;
            MateriasGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MateriasGridView.Size = new Size(651, 279);
            MateriasGridView.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            MateriasGridView.TabIndex = 1;
            MateriasGridView.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            MateriasGridView.CellContentClick += MateriasGridView_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // HorasSemanales
            // 
            HorasSemanales.DataPropertyName = "HorasSemanales";
            HorasSemanales.HeaderText = "Horas Semanales";
            HorasSemanales.Name = "HorasSemanales";
            HorasSemanales.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // AgregarMateriaButton
            // 
            AgregarMateriaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AgregarMateriaButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            AgregarMateriaButton.Depth = 0;
            AgregarMateriaButton.HighEmphasis = true;
            AgregarMateriaButton.Icon = null;
            AgregarMateriaButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            AgregarMateriaButton.Location = new Point(515, 79);
            AgregarMateriaButton.Margin = new Padding(4, 6, 4, 6);
            AgregarMateriaButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            AgregarMateriaButton.Name = "AgregarMateriaButton";
            AgregarMateriaButton.NoAccentTextColor = Color.Empty;
            AgregarMateriaButton.Size = new Size(154, 36);
            AgregarMateriaButton.TabIndex = 2;
            AgregarMateriaButton.Text = "Agregar Materia";
            AgregarMateriaButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            AgregarMateriaButton.UseAccentColor = false;
            AgregarMateriaButton.UseVisualStyleBackColor = true;
            AgregarMateriaButton.Click += AgregarMateriaButton_Click;
            // 
            // NumeroMateriasLabel
            // 
            NumeroMateriasLabel.AutoSize = true;
            NumeroMateriasLabel.Depth = 0;
            NumeroMateriasLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            NumeroMateriasLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            NumeroMateriasLabel.Location = new Point(22, 423);
            NumeroMateriasLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            NumeroMateriasLabel.Name = "NumeroMateriasLabel";
            NumeroMateriasLabel.Size = new Size(97, 24);
            NumeroMateriasLabel.TabIndex = 3;
            NumeroMateriasLabel.Text = "5 Materias";
            // 
            // NumeroHorasLabel
            // 
            NumeroHorasLabel.AutoSize = true;
            NumeroHorasLabel.Depth = 0;
            NumeroHorasLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            NumeroHorasLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            NumeroHorasLabel.Location = new Point(22, 460);
            NumeroHorasLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            NumeroHorasLabel.Name = "NumeroHorasLabel";
            NumeroHorasLabel.Size = new Size(174, 24);
            NumeroHorasLabel.TabIndex = 4;
            NumeroHorasLabel.Text = "3 Horas Semanales";
            // 
            // AsignarButton
            // 
            AsignarButton.AutoSize = false;
            AsignarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AsignarButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            AsignarButton.Depth = 0;
            AsignarButton.HighEmphasis = true;
            AsignarButton.Icon = null;
            AsignarButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            AsignarButton.Location = new Point(515, 423);
            AsignarButton.Margin = new Padding(4, 6, 4, 6);
            AsignarButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            AsignarButton.Name = "AsignarButton";
            AsignarButton.NoAccentTextColor = Color.Empty;
            AsignarButton.Size = new Size(154, 61);
            AsignarButton.TabIndex = 5;
            AsignarButton.Text = "Guardar Maya";
            AsignarButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            AsignarButton.UseAccentColor = false;
            AsignarButton.UseVisualStyleBackColor = true;
            // 
            // AsignarMateriasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 502);
            Controls.Add(AsignarButton);
            Controls.Add(NumeroHorasLabel);
            Controls.Add(NumeroMateriasLabel);
            Controls.Add(AgregarMateriaButton);
            Controls.Add(MateriasGridView);
            Controls.Add(GradoLabel);
            Name = "AsignarMateriasForm";
            Text = "Asignar Materias";
            Load += AsignarMateriasForm_Load;
            ((System.ComponentModel.ISupportInitialize)MateriasGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel GradoLabel;
        private ReaLTaiizor.Controls.PoisonDataGridView MateriasGridView;
        private ReaLTaiizor.Controls.MaterialButton AgregarMateriaButton;
        private ReaLTaiizor.Controls.MaterialLabel NumeroMateriasLabel;
        private ReaLTaiizor.Controls.MaterialLabel NumeroHorasLabel;
        private ReaLTaiizor.Controls.MaterialButton AsignarButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn HorasSemanales;
        private DataGridViewButtonColumn Eliminar;
    }
}