namespace Presentacion.Grupos
{
    partial class NuevoGrupoForm
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
            NombreTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            PrimeroRadioButton = new ReaLTaiizor.Controls.MaterialRadioButton();
            GradoLabel = new ReaLTaiizor.Controls.MaterialLabel();
            SegundoRadioButton = new ReaLTaiizor.Controls.MaterialRadioButton();
            TerceroRadioButton = new ReaLTaiizor.Controls.MaterialRadioButton();
            GuardarGrupoButton = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // NombreTextBox
            // 
            NombreTextBox.AnimateReadOnly = false;
            NombreTextBox.AutoCompleteMode = AutoCompleteMode.None;
            NombreTextBox.AutoCompleteSource = AutoCompleteSource.None;
            NombreTextBox.BackgroundImageLayout = ImageLayout.None;
            NombreTextBox.CharacterCasing = CharacterCasing.Normal;
            NombreTextBox.Depth = 0;
            NombreTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NombreTextBox.HideSelection = true;
            NombreTextBox.Hint = "Nombre";
            NombreTextBox.LeadingIcon = null;
            NombreTextBox.Location = new Point(16, 78);
            NombreTextBox.MaxLength = 50;
            NombreTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.PasswordChar = '\0';
            NombreTextBox.PrefixSuffixText = null;
            NombreTextBox.ReadOnly = false;
            NombreTextBox.RightToLeft = RightToLeft.No;
            NombreTextBox.SelectedText = "";
            NombreTextBox.SelectionLength = 0;
            NombreTextBox.SelectionStart = 0;
            NombreTextBox.ShortcutsEnabled = true;
            NombreTextBox.Size = new Size(250, 48);
            NombreTextBox.TabIndex = 4;
            NombreTextBox.TabStop = false;
            NombreTextBox.TextAlign = HorizontalAlignment.Left;
            NombreTextBox.TrailingIcon = null;
            NombreTextBox.UseAccent = false;
            NombreTextBox.UseSystemPasswordChar = false;
            // 
            // PrimeroRadioButton
            // 
            PrimeroRadioButton.AutoSize = true;
            PrimeroRadioButton.Depth = 0;
            PrimeroRadioButton.Location = new Point(16, 160);
            PrimeroRadioButton.Margin = new Padding(0);
            PrimeroRadioButton.MouseLocation = new Point(-1, -1);
            PrimeroRadioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            PrimeroRadioButton.Name = "PrimeroRadioButton";
            PrimeroRadioButton.Ripple = true;
            PrimeroRadioButton.Size = new Size(111, 37);
            PrimeroRadioButton.TabIndex = 5;
            PrimeroRadioButton.TabStop = true;
            PrimeroRadioButton.Text = "1 - Primero";
            PrimeroRadioButton.UseAccentColor = false;
            PrimeroRadioButton.UseVisualStyleBackColor = true;
            // 
            // GradoLabel
            // 
            GradoLabel.AutoSize = true;
            GradoLabel.Depth = 0;
            GradoLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            GradoLabel.Location = new Point(16, 141);
            GradoLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            GradoLabel.Name = "GradoLabel";
            GradoLabel.Size = new Size(44, 19);
            GradoLabel.TabIndex = 6;
            GradoLabel.Text = "Grado";
            // 
            // SegundoRadioButton
            // 
            SegundoRadioButton.AutoSize = true;
            SegundoRadioButton.Depth = 0;
            SegundoRadioButton.Location = new Point(16, 197);
            SegundoRadioButton.Margin = new Padding(0);
            SegundoRadioButton.MouseLocation = new Point(-1, -1);
            SegundoRadioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            SegundoRadioButton.Name = "SegundoRadioButton";
            SegundoRadioButton.Ripple = true;
            SegundoRadioButton.Size = new Size(119, 37);
            SegundoRadioButton.TabIndex = 7;
            SegundoRadioButton.TabStop = true;
            SegundoRadioButton.Text = "2 - Segundo";
            SegundoRadioButton.UseAccentColor = false;
            SegundoRadioButton.UseVisualStyleBackColor = true;
            // 
            // TerceroRadioButton
            // 
            TerceroRadioButton.AutoSize = true;
            TerceroRadioButton.Depth = 0;
            TerceroRadioButton.Location = new Point(16, 234);
            TerceroRadioButton.Margin = new Padding(0);
            TerceroRadioButton.MouseLocation = new Point(-1, -1);
            TerceroRadioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TerceroRadioButton.Name = "TerceroRadioButton";
            TerceroRadioButton.Ripple = true;
            TerceroRadioButton.Size = new Size(109, 37);
            TerceroRadioButton.TabIndex = 8;
            TerceroRadioButton.TabStop = true;
            TerceroRadioButton.Text = "3 - Tercero";
            TerceroRadioButton.UseAccentColor = false;
            TerceroRadioButton.UseVisualStyleBackColor = true;
            // 
            // GuardarGrupoButton
            // 
            GuardarGrupoButton.AutoSize = false;
            GuardarGrupoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GuardarGrupoButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            GuardarGrupoButton.Depth = 0;
            GuardarGrupoButton.HighEmphasis = true;
            GuardarGrupoButton.Icon = null;
            GuardarGrupoButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            GuardarGrupoButton.Location = new Point(16, 287);
            GuardarGrupoButton.Margin = new Padding(4, 6, 4, 6);
            GuardarGrupoButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            GuardarGrupoButton.Name = "GuardarGrupoButton";
            GuardarGrupoButton.NoAccentTextColor = Color.Empty;
            GuardarGrupoButton.Size = new Size(250, 36);
            GuardarGrupoButton.TabIndex = 9;
            GuardarGrupoButton.Text = "Guardar";
            GuardarGrupoButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            GuardarGrupoButton.UseAccentColor = false;
            GuardarGrupoButton.UseVisualStyleBackColor = true;
            GuardarGrupoButton.Click += GuardarGrupoButton_Click;
            // 
            // NuevoGrupoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 332);
            Controls.Add(GuardarGrupoButton);
            Controls.Add(TerceroRadioButton);
            Controls.Add(SegundoRadioButton);
            Controls.Add(GradoLabel);
            Controls.Add(PrimeroRadioButton);
            Controls.Add(NombreTextBox);
            Name = "NuevoGrupoForm";
            Text = "Nuevo Grupo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit NombreTextBox;
        private ReaLTaiizor.Controls.MaterialRadioButton PrimeroRadioButton;
        private ReaLTaiizor.Controls.MaterialLabel GradoLabel;
        private ReaLTaiizor.Controls.MaterialRadioButton SegundoRadioButton;
        private ReaLTaiizor.Controls.MaterialRadioButton TerceroRadioButton;
        private ReaLTaiizor.Controls.MaterialButton GuardarGrupoButton;
    }
}