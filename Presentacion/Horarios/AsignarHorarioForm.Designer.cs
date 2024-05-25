namespace Presentacion.Horarios
{
    partial class AsignarHorarioForm
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
            EliminarHorarioButton = new ReaLTaiizor.Controls.MaterialButton();
            DescatarButton = new ReaLTaiizor.Controls.MaterialButton();
            AsignarHorarioButton = new ReaLTaiizor.Controls.MaterialButton();
            MainPanel = new Panel();
            PanelGrid = new Panel();
            Hora = new TableLayoutPanel();
            ViernesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            JuevesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            MiercolesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            MartesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            LunesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            HoraLabel = new ReaLTaiizor.Controls.MaterialLabel();
            MainPanel.SuspendLayout();
            Hora.SuspendLayout();
            SuspendLayout();
            // 
            // EliminarHorarioButton
            // 
            EliminarHorarioButton.AutoSize = false;
            EliminarHorarioButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EliminarHorarioButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            EliminarHorarioButton.Depth = 0;
            EliminarHorarioButton.HighEmphasis = true;
            EliminarHorarioButton.Icon = null;
            EliminarHorarioButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            EliminarHorarioButton.Location = new Point(1060, 831);
            EliminarHorarioButton.Margin = new Padding(4, 6, 4, 6);
            EliminarHorarioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            EliminarHorarioButton.Name = "EliminarHorarioButton";
            EliminarHorarioButton.NoAccentTextColor = Color.Empty;
            EliminarHorarioButton.Size = new Size(111, 61);
            EliminarHorarioButton.TabIndex = 10;
            EliminarHorarioButton.Text = "Eliminar";
            EliminarHorarioButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            EliminarHorarioButton.UseAccentColor = false;
            EliminarHorarioButton.UseVisualStyleBackColor = true;
            EliminarHorarioButton.Click += EliminarHorarioButton_Click;
            // 
            // DescatarButton
            // 
            DescatarButton.AutoSize = false;
            DescatarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DescatarButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            DescatarButton.Depth = 0;
            DescatarButton.HighEmphasis = true;
            DescatarButton.Icon = null;
            DescatarButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            DescatarButton.Location = new Point(941, 831);
            DescatarButton.Margin = new Padding(4, 6, 4, 6);
            DescatarButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DescatarButton.Name = "DescatarButton";
            DescatarButton.NoAccentTextColor = Color.Empty;
            DescatarButton.Size = new Size(111, 61);
            DescatarButton.TabIndex = 9;
            DescatarButton.Text = "Descartar";
            DescatarButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            DescatarButton.UseAccentColor = false;
            DescatarButton.UseVisualStyleBackColor = true;
            DescatarButton.Click += DescatarButton_Click;
            // 
            // AsignarHorarioButton
            // 
            AsignarHorarioButton.AutoSize = false;
            AsignarHorarioButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AsignarHorarioButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            AsignarHorarioButton.Depth = 0;
            AsignarHorarioButton.HighEmphasis = true;
            AsignarHorarioButton.Icon = null;
            AsignarHorarioButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            AsignarHorarioButton.Location = new Point(1179, 831);
            AsignarHorarioButton.Margin = new Padding(4, 6, 4, 6);
            AsignarHorarioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            AsignarHorarioButton.Name = "AsignarHorarioButton";
            AsignarHorarioButton.NoAccentTextColor = Color.Empty;
            AsignarHorarioButton.Size = new Size(84, 61);
            AsignarHorarioButton.TabIndex = 8;
            AsignarHorarioButton.Text = "Guardar";
            AsignarHorarioButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            AsignarHorarioButton.UseAccentColor = false;
            AsignarHorarioButton.UseVisualStyleBackColor = true;
            AsignarHorarioButton.Click += AsignarHorarioButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(PanelGrid);
            MainPanel.Controls.Add(Hora);
            MainPanel.Location = new Point(26, 88);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1237, 734);
            MainPanel.TabIndex = 11;
            // 
            // PanelGrid
            // 
            PanelGrid.Dock = DockStyle.Fill;
            PanelGrid.Location = new Point(0, 35);
            PanelGrid.Name = "PanelGrid";
            PanelGrid.Size = new Size(1237, 699);
            PanelGrid.TabIndex = 1;
            // 
            // Hora
            // 
            Hora.ColumnCount = 6;
            Hora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Hora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Hora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Hora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Hora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Hora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Hora.Controls.Add(ViernesLabel, 5, 0);
            Hora.Controls.Add(JuevesLabel, 4, 0);
            Hora.Controls.Add(MiercolesLabel, 3, 0);
            Hora.Controls.Add(MartesLabel, 2, 0);
            Hora.Controls.Add(LunesLabel, 1, 0);
            Hora.Controls.Add(HoraLabel, 0, 0);
            Hora.Dock = DockStyle.Top;
            Hora.Location = new Point(0, 0);
            Hora.Name = "Hora";
            Hora.RowCount = 1;
            Hora.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Hora.Size = new Size(1237, 35);
            Hora.TabIndex = 0;
            // 
            // ViernesLabel
            // 
            ViernesLabel.AutoSize = true;
            ViernesLabel.BackColor = SystemColors.Control;
            ViernesLabel.Depth = 0;
            ViernesLabel.Dock = DockStyle.Fill;
            ViernesLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            ViernesLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            ViernesLabel.Location = new Point(1033, 0);
            ViernesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ViernesLabel.Name = "ViernesLabel";
            ViernesLabel.Size = new Size(201, 35);
            ViernesLabel.TabIndex = 5;
            ViernesLabel.Text = "Viernes";
            ViernesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // JuevesLabel
            // 
            JuevesLabel.AutoSize = true;
            JuevesLabel.BackColor = SystemColors.Control;
            JuevesLabel.Depth = 0;
            JuevesLabel.Dock = DockStyle.Fill;
            JuevesLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            JuevesLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            JuevesLabel.Location = new Point(827, 0);
            JuevesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            JuevesLabel.Name = "JuevesLabel";
            JuevesLabel.Size = new Size(200, 35);
            JuevesLabel.TabIndex = 4;
            JuevesLabel.Text = "Jueves";
            JuevesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MiercolesLabel
            // 
            MiercolesLabel.AutoSize = true;
            MiercolesLabel.BackColor = SystemColors.Control;
            MiercolesLabel.Depth = 0;
            MiercolesLabel.Dock = DockStyle.Fill;
            MiercolesLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            MiercolesLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            MiercolesLabel.Location = new Point(621, 0);
            MiercolesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MiercolesLabel.Name = "MiercolesLabel";
            MiercolesLabel.Size = new Size(200, 35);
            MiercolesLabel.TabIndex = 3;
            MiercolesLabel.Text = "Miercoles";
            MiercolesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MartesLabel
            // 
            MartesLabel.AutoSize = true;
            MartesLabel.BackColor = SystemColors.Control;
            MartesLabel.Depth = 0;
            MartesLabel.Dock = DockStyle.Fill;
            MartesLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            MartesLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            MartesLabel.Location = new Point(415, 0);
            MartesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MartesLabel.Name = "MartesLabel";
            MartesLabel.Size = new Size(200, 35);
            MartesLabel.TabIndex = 2;
            MartesLabel.Text = "Martes";
            MartesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LunesLabel
            // 
            LunesLabel.AutoSize = true;
            LunesLabel.BackColor = SystemColors.Control;
            LunesLabel.Depth = 0;
            LunesLabel.Dock = DockStyle.Fill;
            LunesLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LunesLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            LunesLabel.Location = new Point(209, 0);
            LunesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            LunesLabel.Name = "LunesLabel";
            LunesLabel.Size = new Size(200, 35);
            LunesLabel.TabIndex = 1;
            LunesLabel.Text = "Lunes";
            LunesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HoraLabel
            // 
            HoraLabel.AutoSize = true;
            HoraLabel.BackColor = SystemColors.Control;
            HoraLabel.Depth = 0;
            HoraLabel.Dock = DockStyle.Fill;
            HoraLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            HoraLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            HoraLabel.Location = new Point(3, 0);
            HoraLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            HoraLabel.Name = "HoraLabel";
            HoraLabel.Size = new Size(200, 35);
            HoraLabel.TabIndex = 0;
            HoraLabel.Text = "Hora";
            HoraLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AsignarHorarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 910);
            Controls.Add(MainPanel);
            Controls.Add(EliminarHorarioButton);
            Controls.Add(DescatarButton);
            Controls.Add(AsignarHorarioButton);
            Name = "AsignarHorarioForm";
            Load += AsignarHorarioForm_Load;
            MainPanel.ResumeLayout(false);
            Hora.ResumeLayout(false);
            Hora.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton EliminarHorarioButton;
        private ReaLTaiizor.Controls.MaterialButton DescatarButton;
        private ReaLTaiizor.Controls.MaterialButton AsignarHorarioButton;
        private Panel MainPanel;
        private TableLayoutPanel Hora;
        private ReaLTaiizor.Controls.MaterialLabel HoraLabel;
        private ReaLTaiizor.Controls.MaterialLabel ViernesLabel;
        private ReaLTaiizor.Controls.MaterialLabel JuevesLabel;
        private ReaLTaiizor.Controls.MaterialLabel MiercolesLabel;
        private ReaLTaiizor.Controls.MaterialLabel MartesLabel;
        private ReaLTaiizor.Controls.MaterialLabel LunesLabel;
        private Panel PanelGrid;
    }
}