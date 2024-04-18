namespace Presentacion.Grupos
{
    partial class EditarGrupoForm
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
            GuardarGrupoButton = new Button();
            GradosGroup = new GroupBox();
            TerceroRadioButton = new RadioButton();
            SegundoRadioButton = new RadioButton();
            PrimeroRadioButton = new RadioButton();
            NombreTextBox = new TextBox();
            NombreLabel = new Label();
            GradosGroup.SuspendLayout();
            SuspendLayout();
            // 
            // GuardarGrupoButton
            // 
            GuardarGrupoButton.Location = new Point(12, 171);
            GuardarGrupoButton.Name = "GuardarGrupoButton";
            GuardarGrupoButton.Size = new Size(199, 32);
            GuardarGrupoButton.TabIndex = 7;
            GuardarGrupoButton.Text = "Guardar";
            GuardarGrupoButton.UseVisualStyleBackColor = true;
            GuardarGrupoButton.Click += GuardarGrupoButton_Click;
            // 
            // GradosGroup
            // 
            GradosGroup.Controls.Add(TerceroRadioButton);
            GradosGroup.Controls.Add(SegundoRadioButton);
            GradosGroup.Controls.Add(PrimeroRadioButton);
            GradosGroup.Location = new Point(12, 65);
            GradosGroup.Name = "GradosGroup";
            GradosGroup.Size = new Size(200, 100);
            GradosGroup.TabIndex = 6;
            GradosGroup.TabStop = false;
            GradosGroup.Text = "Grado";
            // 
            // TerceroRadioButton
            // 
            TerceroRadioButton.AutoSize = true;
            TerceroRadioButton.Location = new Point(3, 69);
            TerceroRadioButton.Name = "TerceroRadioButton";
            TerceroRadioButton.Size = new Size(80, 19);
            TerceroRadioButton.TabIndex = 2;
            TerceroRadioButton.TabStop = true;
            TerceroRadioButton.Text = "3 - Tercero";
            TerceroRadioButton.UseVisualStyleBackColor = true;
            // 
            // SegundoRadioButton
            // 
            SegundoRadioButton.AutoSize = true;
            SegundoRadioButton.Location = new Point(3, 44);
            SegundoRadioButton.Name = "SegundoRadioButton";
            SegundoRadioButton.Size = new Size(89, 19);
            SegundoRadioButton.TabIndex = 1;
            SegundoRadioButton.TabStop = true;
            SegundoRadioButton.Text = "2 - Segundo";
            SegundoRadioButton.UseVisualStyleBackColor = true;
            // 
            // PrimeroRadioButton
            // 
            PrimeroRadioButton.AutoSize = true;
            PrimeroRadioButton.Location = new Point(3, 19);
            PrimeroRadioButton.Name = "PrimeroRadioButton";
            PrimeroRadioButton.Size = new Size(84, 19);
            PrimeroRadioButton.TabIndex = 0;
            PrimeroRadioButton.TabStop = true;
            PrimeroRadioButton.Text = "1 - Primero";
            PrimeroRadioButton.UseVisualStyleBackColor = true;
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(12, 27);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(200, 23);
            NombreTextBox.TabIndex = 5;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(12, 9);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(51, 15);
            NombreLabel.TabIndex = 4;
            NombreLabel.Text = "Nombre";
            // 
            // EditarGrupoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 219);
            Controls.Add(GuardarGrupoButton);
            Controls.Add(GradosGroup);
            Controls.Add(NombreTextBox);
            Controls.Add(NombreLabel);
            Name = "EditarGrupoForm";
            Text = "Editar Grupo";
            Load += EditarGrupoForm_Load;
            GradosGroup.ResumeLayout(false);
            GradosGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuardarGrupoButton;
        private GroupBox GradosGroup;
        private RadioButton TerceroRadioButton;
        private RadioButton SegundoRadioButton;
        private RadioButton PrimeroRadioButton;
        private TextBox NombreTextBox;
        private Label NombreLabel;
    }
}