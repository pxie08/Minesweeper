namespace q421
{
    partial class q421
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q421));
            this.gameMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meBox = new System.Windows.Forms.PictureBox();
            this.techiebox = new System.Windows.Forms.PictureBox();
            this.gameMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techiebox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameMenu
            // 
            this.gameMenu.BackColor = System.Drawing.Color.Silver;
            this.gameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.gameMenu.Location = new System.Drawing.Point(0, 0);
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(300, 24);
            this.gameMenu.TabIndex = 0;
            this.gameMenu.Text = "gameMenu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // meBox
            // 
            this.meBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.meBox.Image = ((System.Drawing.Image)(resources.GetObject("meBox.Image")));
            this.meBox.Location = new System.Drawing.Point(199, 37);
            this.meBox.Name = "meBox";
            this.meBox.Size = new System.Drawing.Size(89, 74);
            this.meBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meBox.TabIndex = 2;
            this.meBox.TabStop = false;
            // 
            // techiebox
            // 
            this.techiebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.techiebox.Image = global::q421.Properties.Resources.Techies;
            this.techiebox.Location = new System.Drawing.Point(12, 37);
            this.techiebox.Name = "techiebox";
            this.techiebox.Size = new System.Drawing.Size(89, 74);
            this.techiebox.TabIndex = 1;
            this.techiebox.TabStop = false;
            // 
            // q421
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 430);
            this.Controls.Add(this.meBox);
            this.Controls.Add(this.techiebox);
            this.Controls.Add(this.gameMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.gameMenu;
            this.MaximizeBox = false;
            this.Name = "q421";
            this.Text = "Quest 421 -- Patrick Xie";
            this.gameMenu.ResumeLayout(false);
            this.gameMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techiebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip gameMenu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox techiebox;
        private System.Windows.Forms.PictureBox meBox;

    }
}

