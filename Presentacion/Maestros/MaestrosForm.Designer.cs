namespace Presentacion.Maestros
{
    partial class MaestrosForm
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
            MaestrosGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNombres = new DataGridViewTextBoxColumn();
            ColApellidos = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Exportar = new DataGridViewButtonColumn();
            HorasAsignadas = new DataGridViewTextBoxColumn();
            CrearMaestroButton = new ReaLTaiizor.Controls.MaterialButton();
            MaestrosLabel = new ReaLTaiizor.Controls.MaterialLabel();
            SearchTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ((System.ComponentModel.ISupportInitialize)MaestrosGrid).BeginInit();
            SuspendLayout();
            // 
            // MaestrosGrid
            // 
            MaestrosGrid.AllowUserToAddRows = false;
            MaestrosGrid.AllowUserToDeleteRows = false;
            MaestrosGrid.AllowUserToResizeRows = false;
            MaestrosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MaestrosGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            MaestrosGrid.BorderStyle = BorderStyle.None;
            MaestrosGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            MaestrosGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MaestrosGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MaestrosGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaestrosGrid.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombres, ColApellidos, Eliminar, Exportar, HorasAsignadas });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MaestrosGrid.DefaultCellStyle = dataGridViewCellStyle2;
            MaestrosGrid.EnableHeadersVisualStyles = false;
            MaestrosGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaestrosGrid.GridColor = Color.FromArgb(255, 255, 255);
            MaestrosGrid.Location = new Point(14, 128);
            MaestrosGrid.Name = "MaestrosGrid";
            MaestrosGrid.ReadOnly = true;
            MaestrosGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            MaestrosGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MaestrosGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            MaestrosGrid.RowTemplate.Height = 25;
            MaestrosGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MaestrosGrid.Size = new Size(672, 302);
            MaestrosGrid.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            MaestrosGrid.TabIndex = 6;
            MaestrosGrid.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            MaestrosGrid.VirtualMode = true;
            MaestrosGrid.CellContentClick += MaestrosGrid_CellContentClick;
            MaestrosGrid.CellFormatting += MaestrosGrid_CellFormatting;
            // 
            // ColId
            // 
            ColId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColNombres
            // 
            ColNombres.DataPropertyName = "Nombres";
            ColNombres.HeaderText = "Nombres";
            ColNombres.Name = "ColNombres";
            ColNombres.ReadOnly = true;
            // 
            // ColApellidos
            // 
            ColApellidos.DataPropertyName = "Apellidos";
            ColApellidos.HeaderText = "Apellidos";
            ColApellidos.Name = "ColApellidos";
            ColApellidos.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Exportar
            // 
            Exportar.HeaderText = "Exportar/Excel";
            Exportar.Name = "Exportar";
            Exportar.ReadOnly = true;
            Exportar.Resizable = DataGridViewTriState.True;
            Exportar.SortMode = DataGridViewColumnSortMode.Automatic;
            Exportar.Text = "Exportar/Excel";
            Exportar.UseColumnTextForButtonValue = true;
            // 
            // HorasAsignadas
            // 
            HorasAsignadas.DataPropertyName = "HorasAsignadas";
            HorasAsignadas.HeaderText = "HorasAsignadas";
            HorasAsignadas.Name = "HorasAsignadas";
            HorasAsignadas.ReadOnly = true;
            HorasAsignadas.Visible = false;
            // 
            // CrearMaestroButton
            // 
            CrearMaestroButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CrearMaestroButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            CrearMaestroButton.Depth = 0;
            CrearMaestroButton.HighEmphasis = true;
            CrearMaestroButton.Icon = null;
            CrearMaestroButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            CrearMaestroButton.Location = new Point(545, 20);
            CrearMaestroButton.Margin = new Padding(4, 6, 4, 6);
            CrearMaestroButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CrearMaestroButton.Name = "CrearMaestroButton";
            CrearMaestroButton.NoAccentTextColor = Color.Empty;
            CrearMaestroButton.Size = new Size(141, 36);
            CrearMaestroButton.TabIndex = 5;
            CrearMaestroButton.Text = "Nuevo Maestro";
            CrearMaestroButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            CrearMaestroButton.UseAccentColor = false;
            CrearMaestroButton.UseVisualStyleBackColor = true;
            CrearMaestroButton.Click += CrearMaestroButton_Click;
            // 
            // MaestrosLabel
            // 
            MaestrosLabel.AutoSize = true;
            MaestrosLabel.Depth = 0;
            MaestrosLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            MaestrosLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            MaestrosLabel.Location = new Point(14, 21);
            MaestrosLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MaestrosLabel.Name = "MaestrosLabel";
            MaestrosLabel.Padding = new Padding(16);
            MaestrosLabel.Size = new Size(146, 41);
            MaestrosLabel.TabIndex = 4;
            MaestrosLabel.Text = "Maestros";
            // 
            // SearchTextBox
            // 
            SearchTextBox.AnimateReadOnly = false;
            SearchTextBox.AutoCompleteMode = AutoCompleteMode.None;
            SearchTextBox.AutoCompleteSource = AutoCompleteSource.None;
            SearchTextBox.BackgroundImageLayout = ImageLayout.None;
            SearchTextBox.CharacterCasing = CharacterCasing.Normal;
            SearchTextBox.Depth = 0;
            SearchTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SearchTextBox.HideSelection = true;
            SearchTextBox.Hint = "Buscar Maestros";
            SearchTextBox.LeadingIcon = null;
            SearchTextBox.Location = new Point(14, 65);
            SearchTextBox.MaxLength = 32767;
            SearchTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PasswordChar = '\0';
            SearchTextBox.PrefixSuffixText = null;
            SearchTextBox.ReadOnly = false;
            SearchTextBox.RightToLeft = RightToLeft.No;
            SearchTextBox.SelectedText = "";
            SearchTextBox.SelectionLength = 0;
            SearchTextBox.SelectionStart = 0;
            SearchTextBox.ShortcutsEnabled = true;
            SearchTextBox.Size = new Size(672, 48);
            SearchTextBox.TabIndex = 7;
            SearchTextBox.TabStop = false;
            SearchTextBox.TextAlign = HorizontalAlignment.Left;
            SearchTextBox.TrailingIcon = Properties.Resources.close_ic;
            SearchTextBox.UseAccent = false;
            SearchTextBox.UseSystemPasswordChar = false;
            SearchTextBox.TrailingIconClick += SearchTextBox_TrailingIconClick;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // MaestrosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 488);
            Controls.Add(SearchTextBox);
            Controls.Add(MaestrosGrid);
            Controls.Add(CrearMaestroButton);
            Controls.Add(MaestrosLabel);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "MaestrosForm";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Listado de Maestros";
            Load += MaestrosForm_Load;
            ((System.ComponentModel.ISupportInitialize)MaestrosGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView MaestrosGrid;
        private ReaLTaiizor.Controls.MaterialButton CrearMaestroButton;
        private ReaLTaiizor.Controls.MaterialLabel MaestrosLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit SearchTextBox;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombres;
        private DataGridViewTextBoxColumn ColApellidos;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewButtonColumn Exportar;
        private DataGridViewTextBoxColumn HorasAsignadas;
    }
}