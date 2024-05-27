namespace Presentacion.Horarios
{
    partial class AsignarHoraForm
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
            DiaTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            HoraTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            MaestroComboBox = new ReaLTaiizor.Controls.MaterialComboBox();
            MateriasComboBox = new ReaLTaiizor.Controls.MaterialComboBox();
            asignarHoraButton = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // DiaTextBox
            // 
            DiaTextBox.AnimateReadOnly = false;
            DiaTextBox.AutoCompleteMode = AutoCompleteMode.None;
            DiaTextBox.AutoCompleteSource = AutoCompleteSource.None;
            DiaTextBox.BackgroundImageLayout = ImageLayout.None;
            DiaTextBox.CharacterCasing = CharacterCasing.Normal;
            DiaTextBox.Depth = 0;
            DiaTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DiaTextBox.HideSelection = true;
            DiaTextBox.Hint = "Dia";
            DiaTextBox.LeadingIcon = null;
            DiaTextBox.Location = new Point(20, 86);
            DiaTextBox.MaxLength = 32767;
            DiaTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DiaTextBox.Name = "DiaTextBox";
            DiaTextBox.PasswordChar = '\0';
            DiaTextBox.PrefixSuffixText = null;
            DiaTextBox.ReadOnly = false;
            DiaTextBox.RightToLeft = RightToLeft.No;
            DiaTextBox.SelectedText = "";
            DiaTextBox.SelectionLength = 0;
            DiaTextBox.SelectionStart = 0;
            DiaTextBox.ShortcutsEnabled = true;
            DiaTextBox.Size = new Size(324, 48);
            DiaTextBox.TabIndex = 0;
            DiaTextBox.TabStop = false;
            DiaTextBox.Text = "Lunes";
            DiaTextBox.TextAlign = HorizontalAlignment.Left;
            DiaTextBox.TrailingIcon = null;
            DiaTextBox.UseSystemPasswordChar = false;
            // 
            // HoraTextBox
            // 
            HoraTextBox.AnimateReadOnly = false;
            HoraTextBox.AutoCompleteMode = AutoCompleteMode.None;
            HoraTextBox.AutoCompleteSource = AutoCompleteSource.None;
            HoraTextBox.BackgroundImageLayout = ImageLayout.None;
            HoraTextBox.CharacterCasing = CharacterCasing.Normal;
            HoraTextBox.Depth = 0;
            HoraTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            HoraTextBox.HideSelection = true;
            HoraTextBox.Hint = "Hora";
            HoraTextBox.LeadingIcon = null;
            HoraTextBox.Location = new Point(20, 155);
            HoraTextBox.MaxLength = 32767;
            HoraTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            HoraTextBox.Name = "HoraTextBox";
            HoraTextBox.PasswordChar = '\0';
            HoraTextBox.PrefixSuffixText = null;
            HoraTextBox.ReadOnly = false;
            HoraTextBox.RightToLeft = RightToLeft.No;
            HoraTextBox.SelectedText = "";
            HoraTextBox.SelectionLength = 0;
            HoraTextBox.SelectionStart = 0;
            HoraTextBox.ShortcutsEnabled = true;
            HoraTextBox.Size = new Size(324, 48);
            HoraTextBox.TabIndex = 1;
            HoraTextBox.TabStop = false;
            HoraTextBox.Text = "8:00 - 9:00";
            HoraTextBox.TextAlign = HorizontalAlignment.Left;
            HoraTextBox.TrailingIcon = null;
            HoraTextBox.UseSystemPasswordChar = false;
            // 
            // MaestroComboBox
            // 
            MaestroComboBox.AutoResize = false;
            MaestroComboBox.BackColor = Color.FromArgb(255, 255, 255);
            MaestroComboBox.Depth = 0;
            MaestroComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            MaestroComboBox.DropDownHeight = 174;
            MaestroComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MaestroComboBox.DropDownWidth = 121;
            MaestroComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            MaestroComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MaestroComboBox.FormattingEnabled = true;
            MaestroComboBox.Hint = "Maestro";
            MaestroComboBox.IntegralHeight = false;
            MaestroComboBox.ItemHeight = 43;
            MaestroComboBox.Location = new Point(20, 220);
            MaestroComboBox.MaxDropDownItems = 4;
            MaestroComboBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            MaestroComboBox.Name = "MaestroComboBox";
            MaestroComboBox.Size = new Size(324, 49);
            MaestroComboBox.StartIndex = 0;
            MaestroComboBox.TabIndex = 2;
            // 
            // MateriasComboBox
            // 
            MateriasComboBox.AutoResize = false;
            MateriasComboBox.BackColor = Color.FromArgb(255, 255, 255);
            MateriasComboBox.Depth = 0;
            MateriasComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            MateriasComboBox.DropDownHeight = 174;
            MateriasComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MateriasComboBox.DropDownWidth = 121;
            MateriasComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            MateriasComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MateriasComboBox.FormattingEnabled = true;
            MateriasComboBox.Hint = "Materias";
            MateriasComboBox.IntegralHeight = false;
            MateriasComboBox.ItemHeight = 43;
            MateriasComboBox.Location = new Point(20, 290);
            MateriasComboBox.MaxDropDownItems = 4;
            MateriasComboBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            MateriasComboBox.Name = "MateriasComboBox";
            MateriasComboBox.Size = new Size(324, 49);
            MateriasComboBox.StartIndex = 0;
            MateriasComboBox.TabIndex = 3;
            // 
            // asignarHoraButton
            // 
            asignarHoraButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            asignarHoraButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            asignarHoraButton.Depth = 0;
            asignarHoraButton.HighEmphasis = true;
            asignarHoraButton.Icon = null;
            asignarHoraButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            asignarHoraButton.Location = new Point(217, 361);
            asignarHoraButton.Margin = new Padding(4, 6, 4, 6);
            asignarHoraButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            asignarHoraButton.Name = "asignarHoraButton";
            asignarHoraButton.NoAccentTextColor = Color.Empty;
            asignarHoraButton.Size = new Size(127, 36);
            asignarHoraButton.TabIndex = 4;
            asignarHoraButton.Text = "ASIGNAR HORA";
            asignarHoraButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            asignarHoraButton.UseAccentColor = false;
            asignarHoraButton.UseVisualStyleBackColor = true;
            asignarHoraButton.Click += asignarHoraButton_Click;
            // 
            // AsignarHoraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 426);
            Controls.Add(asignarHoraButton);
            Controls.Add(MateriasComboBox);
            Controls.Add(MaestroComboBox);
            Controls.Add(HoraTextBox);
            Controls.Add(DiaTextBox);
            Name = "AsignarHoraForm";
            Text = "AsignarHoraForm";
            Load += AsignarHoraForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit DiaTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit HoraTextBox;
        private ReaLTaiizor.Controls.MaterialComboBox MaestroComboBox;
        private ReaLTaiizor.Controls.MaterialComboBox MateriasComboBox;
        private ReaLTaiizor.Controls.MaterialButton asignarHoraButton;
    }
}