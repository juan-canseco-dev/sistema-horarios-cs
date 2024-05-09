using Presentacion.Utils;

namespace Presentacion.Mayas
{
    partial class MayasForm
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
            MayasGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColGrado = new DataGridViewTextBoxColumn();
            ColVer = new DataGridViewDisableButtonColumn();
            ColEditar = new DataGridViewDisableButtonColumn();
            ColAsignada = new DataGridViewTextBoxColumn();
            MayasLabel = new ReaLTaiizor.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)MayasGrid).BeginInit();
            SuspendLayout();
            // 
            // MayasGrid
            // 
            MayasGrid.AllowUserToAddRows = false;
            MayasGrid.AllowUserToDeleteRows = false;
            MayasGrid.AllowUserToResizeColumns = false;
            MayasGrid.AllowUserToResizeRows = false;
            MayasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MayasGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            MayasGrid.BorderStyle = BorderStyle.None;
            MayasGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            MayasGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            MayasGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MayasGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MayasGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MayasGrid.Columns.AddRange(new DataGridViewColumn[] { ColId, ColGrado, ColVer, ColEditar, ColAsignada });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MayasGrid.DefaultCellStyle = dataGridViewCellStyle2;
            MayasGrid.EnableHeadersVisualStyles = false;
            MayasGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            MayasGrid.GridColor = Color.FromArgb(255, 255, 255);
            MayasGrid.Location = new Point(14, 65);
            MayasGrid.MultiSelect = false;
            MayasGrid.Name = "MayasGrid";
            MayasGrid.ReadOnly = true;
            MayasGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            MayasGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MayasGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            MayasGrid.RowTemplate.Height = 25;
            MayasGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MayasGrid.Size = new Size(672, 302);
            MayasGrid.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            MayasGrid.TabIndex = 6;
            MayasGrid.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            MayasGrid.VirtualMode = true;
            MayasGrid.CellClick += MayasGrid_CellClick;
            MayasGrid.CellFormatting += MayasGrid_CellFormatting;
            MayasGrid.CurrentCellDirtyStateChanged += MayasGrid_CurrentCellDirtyStateChanged;
            // 
            // ColId
            // 
            ColId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColGrado
            // 
            ColGrado.DataPropertyName = "Grado";
            ColGrado.HeaderText = "Grado";
            ColGrado.Name = "ColGrado";
            ColGrado.ReadOnly = true;
            // 
            // ColVer
            // 
            ColVer.HeaderText = "Ver Maya";
            ColVer.Name = "ColVer";
            ColVer.ReadOnly = true;
            ColVer.Text = "Ver Maya";
            ColVer.UseColumnTextForButtonValue = true;
            // 
            // ColEditar
            // 
            ColEditar.HeaderText = "Editar";
            ColEditar.Name = "ColEditar";
            ColEditar.ReadOnly = true;
            ColEditar.Resizable = DataGridViewTriState.True;
            ColEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColAsignada
            // 
            ColAsignada.DataPropertyName = "Asignada";
            ColAsignada.HeaderText = "Asignada";
            ColAsignada.Name = "ColAsignada";
            ColAsignada.ReadOnly = true;
            ColAsignada.Visible = false;
            // 
            // MayasLabel
            // 
            MayasLabel.AutoSize = true;
            MayasLabel.Depth = 0;
            MayasLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            MayasLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            MayasLabel.Location = new Point(14, 21);
            MayasLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MayasLabel.Name = "MayasLabel";
            MayasLabel.Padding = new Padding(16);
            MayasLabel.Size = new Size(103, 41);
            MayasLabel.TabIndex = 4;
            MayasLabel.Text = "Mayas";
            // 
            // MayasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 388);
            Controls.Add(MayasGrid);
            Controls.Add(MayasLabel);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "MayasForm";
            Padding = new Padding(3, 0, 3, 3);
            Text = "MayasForm";
            Load += MayasForm_Load;
            ((System.ComponentModel.ISupportInitialize)MayasGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView MayasGrid;
        private ReaLTaiizor.Controls.MaterialLabel MayasLabel;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColGrado;
        private DataGridViewDisableButtonColumn ColVer;
        private DataGridViewDisableButtonColumn ColEditar;
        private DataGridViewTextBoxColumn ColAsignada;
    }
}