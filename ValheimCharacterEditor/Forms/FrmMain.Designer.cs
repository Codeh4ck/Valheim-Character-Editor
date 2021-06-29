
namespace ValheimCharacterEditor.Forms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.labelTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cbCharacters = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEditCharacter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // borderlessForm
            // 
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.ResizeForm = false;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.guna2PictureBox1);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(145)))), ((int)(((byte)(244)))));
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.ShadowDecoration.Parent = this.panelTitle;
            this.panelTitle.Size = new System.Drawing.Size(440, 46);
            this.panelTitle.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(48, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnMinimize.HoverState.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnMinimize.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageRotate = 0F;
            this.btnMinimize.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMinimize.Location = new System.Drawing.Point(362, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnMinimize.PressedState.ImageOffset = new System.Drawing.Point(0, 1);
            this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMinimize.PressedState.Parent = this.btnMinimize;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnClose.HoverState.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.Location = new System.Drawing.Point(400, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnClose.PressedState.ImageOffset = new System.Drawing.Point(0, 1);
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(56, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(206, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Valheim Character Editor";
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.panelTitle;
            // 
            // cbCharacters
            // 
            this.cbCharacters.BackColor = System.Drawing.Color.Transparent;
            this.cbCharacters.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCharacters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCharacters.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCharacters.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCharacters.FocusedState.Parent = this.cbCharacters;
            this.cbCharacters.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.cbCharacters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCharacters.HoverState.Parent = this.cbCharacters;
            this.cbCharacters.ItemHeight = 30;
            this.cbCharacters.ItemsAppearance.Parent = this.cbCharacters;
            this.cbCharacters.Location = new System.Drawing.Point(32, 95);
            this.cbCharacters.Name = "cbCharacters";
            this.cbCharacters.ShadowDecoration.Parent = this.cbCharacters;
            this.cbCharacters.Size = new System.Drawing.Size(372, 36);
            this.cbCharacters.TabIndex = 0;
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.AutoRoundedCorners = true;
            this.btnEditCharacter.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCharacter.BorderRadius = 14;
            this.btnEditCharacter.CheckedState.Parent = this.btnEditCharacter;
            this.btnEditCharacter.CustomImages.Parent = this.btnEditCharacter;
            this.btnEditCharacter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCharacter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCharacter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCharacter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCharacter.DisabledState.Parent = this.btnEditCharacter;
            this.btnEditCharacter.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnEditCharacter.ForeColor = System.Drawing.Color.White;
            this.btnEditCharacter.HoverState.Parent = this.btnEditCharacter;
            this.btnEditCharacter.Location = new System.Drawing.Point(256, 137);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.ShadowDecoration.Parent = this.btnEditCharacter;
            this.btnEditCharacter.Size = new System.Drawing.Size(148, 31);
            this.btnEditCharacter.TabIndex = 1;
            this.btnEditCharacter.Text = "Edit character";
            this.btnEditCharacter.UseTransparentBackground = true;
            this.btnEditCharacter.Click += new System.EventHandler(this.btnEditCharacter_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(32, 73);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(130, 16);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Character selection:";
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(145)))), ((int)(((byte)(244)))));
            this.linkAbout.Location = new System.Drawing.Point(35, 146);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(127, 13);
            this.linkAbout.TabIndex = 3;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "Software information";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 192);
            this.Controls.Add(this.linkAbout);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnEditCharacter);
            this.Controls.Add(this.cbCharacters);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valheim Character Editor";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTitle;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnEditCharacter;
        private Guna.UI2.WinForms.Guna2ComboBox cbCharacters;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.LinkLabel linkAbout;
    }
}

