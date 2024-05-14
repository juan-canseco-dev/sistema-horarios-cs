namespace Presentacion.Mayas
{
    partial class AgregarMateriaForm
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
            CodigoEditText = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            NombreEditText = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            HorasSlider = new ReaLTaiizor.Controls.MaterialSlider();
            AgregarMateriaButton = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // CodigoEditText
            // 
            CodigoEditText.AnimateReadOnly = false;
            CodigoEditText.AutoCompleteMode = AutoCompleteMode.None;
            CodigoEditText.AutoCompleteSource = AutoCompleteSource.None;
            CodigoEditText.BackgroundImageLayout = ImageLayout.None;
            CodigoEditText.CharacterCasing = CharacterCasing.Normal;
            CodigoEditText.Depth = 0;
            CodigoEditText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CodigoEditText.HideSelection = true;
            CodigoEditText.Hint = "Codigo";
            CodigoEditText.LeadingIcon = null;
            CodigoEditText.Location = new Point(17, 82);
            CodigoEditText.MaxLength = 10;
            CodigoEditText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CodigoEditText.Name = "CodigoEditText";
            CodigoEditText.PasswordChar = '\0';
            CodigoEditText.PrefixSuffixText = null;
            CodigoEditText.ReadOnly = false;
            CodigoEditText.RightToLeft = RightToLeft.No;
            CodigoEditText.SelectedText = "";
            CodigoEditText.SelectionLength = 0;
            CodigoEditText.SelectionStart = 0;
            CodigoEditText.ShortcutsEnabled = true;
            CodigoEditText.Size = new Size(275, 48);
            CodigoEditText.TabIndex = 1;
            CodigoEditText.TabStop = false;
            CodigoEditText.TextAlign = HorizontalAlignment.Left;
            CodigoEditText.TrailingIcon = null;
            CodigoEditText.UseAccent = false;
            CodigoEditText.UseSystemPasswordChar = false;
            // 
            // NombreEditText
            // 
            NombreEditText.AnimateReadOnly = false;
            NombreEditText.AutoCompleteMode = AutoCompleteMode.None;
            NombreEditText.AutoCompleteSource = AutoCompleteSource.None;
            NombreEditText.BackgroundImageLayout = ImageLayout.None;
            NombreEditText.CharacterCasing = CharacterCasing.Normal;
            NombreEditText.Depth = 0;
            NombreEditText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NombreEditText.HideSelection = true;
            NombreEditText.Hint = "Nombre";
            NombreEditText.LeadingIcon = null;
            NombreEditText.Location = new Point(17, 154);
            NombreEditText.MaxLength = 50;
            NombreEditText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            NombreEditText.Name = "NombreEditText";
            NombreEditText.PasswordChar = '\0';
            NombreEditText.PrefixSuffixText = null;
            NombreEditText.ReadOnly = false;
            NombreEditText.RightToLeft = RightToLeft.No;
            NombreEditText.SelectedText = "";
            NombreEditText.SelectionLength = 0;
            NombreEditText.SelectionStart = 0;
            NombreEditText.ShortcutsEnabled = true;
            NombreEditText.Size = new Size(275, 48);
            NombreEditText.TabIndex = 2;
            NombreEditText.TabStop = false;
            NombreEditText.TextAlign = HorizontalAlignment.Left;
            NombreEditText.TrailingIcon = null;
            NombreEditText.UseAccent = false;
            NombreEditText.UseSystemPasswordChar = false;
            // 
            // HorasSlider
            // 
            HorasSlider.Depth = 0;
            HorasSlider.ForeColor = Color.FromArgb(222, 0, 0, 0);
            HorasSlider.Location = new Point(17, 223);
            HorasSlider.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            HorasSlider.Name = "HorasSlider";
            HorasSlider.RangeMax = 10;
            HorasSlider.RangeMin = 1;
            HorasSlider.Size = new Size(275, 40);
            HorasSlider.StepChange = 1;
            HorasSlider.TabIndex = 3;
            HorasSlider.Text = "Horas Semanales";
            HorasSlider.Value = 1;
            // 
            // AgregarMateriaButton
            // 
            AgregarMateriaButton.AutoSize = false;
            AgregarMateriaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AgregarMateriaButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            AgregarMateriaButton.Depth = 0;
            AgregarMateriaButton.HighEmphasis = true;
            AgregarMateriaButton.Icon = null;
            AgregarMateriaButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            AgregarMateriaButton.Location = new Point(17, 287);
            AgregarMateriaButton.Margin = new Padding(4, 6, 4, 6);
            AgregarMateriaButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            AgregarMateriaButton.Name = "AgregarMateriaButton";
            AgregarMateriaButton.NoAccentTextColor = Color.Empty;
            AgregarMateriaButton.Size = new Size(275, 47);
            AgregarMateriaButton.TabIndex = 4;
            AgregarMateriaButton.Text = "Agregar Materia";
            AgregarMateriaButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            AgregarMateriaButton.UseAccentColor = false;
            AgregarMateriaButton.UseVisualStyleBackColor = true;
            AgregarMateriaButton.Click += AgregarMateriaButton_Click;
            // 
            // AgregarMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 361);
            Controls.Add(AgregarMateriaButton);
            Controls.Add(HorasSlider);
            Controls.Add(NombreEditText);
            Controls.Add(CodigoEditText);
            Name = "AgregarMateriaForm";
            Text = "Agregar Materia ";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit CodigoEditText;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit NombreEditText;
        private ReaLTaiizor.Controls.MaterialSlider HorasSlider;
        private ReaLTaiizor.Controls.MaterialButton AgregarMateriaButton;
    }
}