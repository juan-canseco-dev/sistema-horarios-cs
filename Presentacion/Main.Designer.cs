namespace Presentacion
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialTabMenu = new ReaLTaiizor.Controls.MaterialTabControl();
            MaestrosTab = new TabPage();
            GruposTab = new TabPage();
            MayasTab = new TabPage();
            MaterialTabMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MaterialTabMenu
            // 
            MaterialTabMenu.Controls.Add(MaestrosTab);
            MaterialTabMenu.Controls.Add(GruposTab);
            MaterialTabMenu.Controls.Add(MayasTab);
            MaterialTabMenu.Depth = 0;
            MaterialTabMenu.Dock = DockStyle.Fill;
            MaterialTabMenu.Location = new Point(3, 72);
            MaterialTabMenu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MaterialTabMenu.Multiline = true;
            MaterialTabMenu.Name = "MaterialTabMenu";
            MaterialTabMenu.SelectedIndex = 0;
            MaterialTabMenu.Size = new Size(700, 488);
            MaterialTabMenu.TabIndex = 0;
            MaterialTabMenu.SelectedIndexChanged += MaterialTabMenu_SelectedIndexChanged;
            // 
            // MaestrosTab
            // 
            MaestrosTab.Location = new Point(4, 24);
            MaestrosTab.Name = "MaestrosTab";
            MaestrosTab.Padding = new Padding(3);
            MaestrosTab.Size = new Size(692, 460);
            MaestrosTab.TabIndex = 0;
            MaestrosTab.Text = "Maestros";
            MaestrosTab.UseVisualStyleBackColor = true;
            // 
            // GruposTab
            // 
            GruposTab.Location = new Point(4, 24);
            GruposTab.Name = "GruposTab";
            GruposTab.Padding = new Padding(3);
            GruposTab.Size = new Size(692, 460);
            GruposTab.TabIndex = 1;
            GruposTab.Text = "Grupos";
            GruposTab.UseVisualStyleBackColor = true;
            // 
            // MayasTab
            // 
            MayasTab.Location = new Point(4, 24);
            MayasTab.Name = "MayasTab";
            MayasTab.Padding = new Padding(3);
            MayasTab.Size = new Size(692, 460);
            MayasTab.TabIndex = 2;
            MayasTab.Text = "Mayas Curriculares";
            MayasTab.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 563);
            Controls.Add(MaterialTabMenu);
            DrawerTabControl = MaterialTabMenu;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_48;
            Name = "Main";
            Padding = new Padding(3, 72, 3, 3);
            Text = "Sistema Horarios";
            Load += Main_Load;
            MaterialTabMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl MaterialTabMenu;
        private TabPage MaestrosTab;
        private TabPage GruposTab;
        private TabPage MayasTab;
    }
}
