namespace Presentacion.Maestros
{
    partial class NuevoMaestroForm
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
            NombresEditText = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ApellidosEditText = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            GuardarMaestroButton = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // NombresEditText
            // 
            NombresEditText.AnimateReadOnly = false;
            NombresEditText.AutoCompleteMode = AutoCompleteMode.None;
            NombresEditText.AutoCompleteSource = AutoCompleteSource.None;
            NombresEditText.BackgroundImageLayout = ImageLayout.None;
            NombresEditText.CharacterCasing = CharacterCasing.Normal;
            NombresEditText.Depth = 0;
            NombresEditText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NombresEditText.HideSelection = true;
            NombresEditText.Hint = "Nombres";
            NombresEditText.LeadingIcon = null;
            NombresEditText.Location = new Point(18, 83);
            NombresEditText.MaxLength = 32767;
            NombresEditText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            NombresEditText.Name = "NombresEditText";
            NombresEditText.PasswordChar = '\0';
            NombresEditText.PrefixSuffixText = null;
            NombresEditText.ReadOnly = false;
            NombresEditText.RightToLeft = RightToLeft.No;
            NombresEditText.SelectedText = "";
            NombresEditText.SelectionLength = 0;
            NombresEditText.SelectionStart = 0;
            NombresEditText.ShortcutsEnabled = true;
            NombresEditText.Size = new Size(275, 48);
            NombresEditText.TabIndex = 0;
            NombresEditText.TabStop = false;
            NombresEditText.TextAlign = HorizontalAlignment.Left;
            NombresEditText.TrailingIcon = null;
            NombresEditText.UseAccent = false;
            NombresEditText.UseSystemPasswordChar = false;
            // 
            // ApellidosEditText
            // 
            ApellidosEditText.AnimateReadOnly = false;
            ApellidosEditText.AutoCompleteMode = AutoCompleteMode.None;
            ApellidosEditText.AutoCompleteSource = AutoCompleteSource.None;
            ApellidosEditText.BackgroundImageLayout = ImageLayout.None;
            ApellidosEditText.CharacterCasing = CharacterCasing.Normal;
            ApellidosEditText.Depth = 0;
            ApellidosEditText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ApellidosEditText.HideSelection = true;
            ApellidosEditText.Hint = "Apellidos";
            ApellidosEditText.LeadingIcon = null;
            ApellidosEditText.Location = new Point(18, 160);
            ApellidosEditText.MaxLength = 32767;
            ApellidosEditText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ApellidosEditText.Name = "ApellidosEditText";
            ApellidosEditText.PasswordChar = '\0';
            ApellidosEditText.PrefixSuffixText = null;
            ApellidosEditText.ReadOnly = false;
            ApellidosEditText.RightToLeft = RightToLeft.No;
            ApellidosEditText.SelectedText = "";
            ApellidosEditText.SelectionLength = 0;
            ApellidosEditText.SelectionStart = 0;
            ApellidosEditText.ShortcutsEnabled = true;
            ApellidosEditText.Size = new Size(275, 48);
            ApellidosEditText.TabIndex = 1;
            ApellidosEditText.TabStop = false;
            ApellidosEditText.TextAlign = HorizontalAlignment.Left;
            ApellidosEditText.TrailingIcon = null;
            ApellidosEditText.UseAccent = false;
            ApellidosEditText.UseSystemPasswordChar = false;
            // 
            // GuardarMaestroButton
            // 
            GuardarMaestroButton.AutoSize = false;
            GuardarMaestroButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GuardarMaestroButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            GuardarMaestroButton.Depth = 0;
            GuardarMaestroButton.HighEmphasis = true;
            GuardarMaestroButton.Icon = null;
            GuardarMaestroButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            GuardarMaestroButton.Location = new Point(18, 231);
            GuardarMaestroButton.Margin = new Padding(4, 6, 4, 6);
            GuardarMaestroButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            GuardarMaestroButton.Name = "GuardarMaestroButton";
            GuardarMaestroButton.NoAccentTextColor = Color.Empty;
            GuardarMaestroButton.Size = new Size(275, 36);
            GuardarMaestroButton.TabIndex = 2;
            GuardarMaestroButton.Text = "Guardar";
            GuardarMaestroButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            GuardarMaestroButton.UseAccentColor = false;
            GuardarMaestroButton.UseVisualStyleBackColor = true;
            GuardarMaestroButton.Click += GuardarMaestroButton_Click;
            // 
            // NuevoMaestroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 298);
            Controls.Add(GuardarMaestroButton);
            Controls.Add(ApellidosEditText);
            Controls.Add(NombresEditText);
            Name = "NuevoMaestroForm";
            Text = "Nuevo Maestro";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit NombresEditText;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit ApellidosEditText;
        private ReaLTaiizor.Controls.MaterialButton GuardarMaestroButton;
    }
}