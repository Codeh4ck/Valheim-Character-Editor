
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cbCharacters = new System.Windows.Forms.ComboBox();
            this.btnEditCharacter = new System.Windows.Forms.Button();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character selection:";
            // 
            // cbCharacters
            // 
            this.cbCharacters.BackColor = System.Drawing.Color.White;
            this.cbCharacters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCharacters.FormattingEnabled = true;
            this.cbCharacters.Location = new System.Drawing.Point(16, 30);
            this.cbCharacters.Name = "cbCharacters";
            this.cbCharacters.Size = new System.Drawing.Size(334, 21);
            this.cbCharacters.TabIndex = 1;
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.Location = new System.Drawing.Point(233, 57);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.Size = new System.Drawing.Size(117, 30);
            this.btnEditCharacter.TabIndex = 2;
            this.btnEditCharacter.Text = "Edit character";
            this.btnEditCharacter.UseVisualStyleBackColor = true;
            this.btnEditCharacter.Click += new System.EventHandler(this.btnEditCharacter_Click);
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(145)))), ((int)(((byte)(244)))));
            this.linkAbout.Location = new System.Drawing.Point(13, 66);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(127, 13);
            this.linkAbout.TabIndex = 4;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "Software information";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 104);
            this.Controls.Add(this.linkAbout);
            this.Controls.Add(this.btnEditCharacter);
            this.Controls.Add(this.cbCharacters);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valheim Character Editor";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCharacters;
        private System.Windows.Forms.Button btnEditCharacter;
        private System.Windows.Forms.LinkLabel linkAbout;
    }
}

