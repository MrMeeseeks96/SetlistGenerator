namespace SetlistGenerator
{
    partial class MainForm
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
            this.go = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.setlistView = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.song = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songlistView = new System.Windows.Forms.ListView();
            this.songlistNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songlistName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songlistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.go.Location = new System.Drawing.Point(449, 322);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(101, 24);
            this.go.TabIndex = 0;
            this.go.Text = "Start";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.Location = new System.Drawing.Point(13, 30);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(885, 20);
            this.filePath.TabIndex = 1;
            // 
            // browse
            // 
            this.browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browse.Location = new System.Drawing.Point(912, 27);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // setlistView
            // 
            this.setlistView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.song});
            this.setlistView.Location = new System.Drawing.Point(556, 56);
            this.setlistView.Name = "setlistView";
            this.setlistView.Size = new System.Drawing.Size(431, 563);
            this.setlistView.TabIndex = 3;
            this.setlistView.UseCompatibleStateImageBehavior = false;
            // 
            // number
            // 
            this.number.Text = "No.";
            this.number.Width = 29;
            // 
            // song
            // 
            this.song.Text = "Song";
            this.song.Width = 280;
            // 
            // songlistView
            // 
            this.songlistView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.songlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songlistNumber,
            this.songlistName});
            this.songlistView.Location = new System.Drawing.Point(13, 56);
            this.songlistView.Name = "songlistView";
            this.songlistView.Size = new System.Drawing.Size(430, 563);
            this.songlistView.TabIndex = 4;
            this.songlistView.UseCompatibleStateImageBehavior = false;
            // 
            // songlistNumber
            // 
            this.songlistNumber.Text = "No.";
            this.songlistNumber.Width = 29;
            // 
            // songlistName
            // 
            this.songlistName.Text = "Name";
            this.songlistName.Width = 280;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxLength.Location = new System.Drawing.Point(449, 296);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(101, 20);
            this.textBoxLength.TabIndex = 5;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(449, 256);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(70, 26);
            this.time.TabIndex = 6;
            this.time.Text = "Setlist length \r\nin minutes:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songlistToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // songlistToolStripMenuItem
            // 
            this.songlistToolStripMenuItem.Name = "songlistToolStripMenuItem";
            this.songlistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.songlistToolStripMenuItem.Text = "Songlist";
            this.songlistToolStripMenuItem.Click += new System.EventHandler(this.songlistToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songlistToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // songlistToolStripMenuItem1
            // 
            this.songlistToolStripMenuItem1.Name = "songlistToolStripMenuItem1";
            this.songlistToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.songlistToolStripMenuItem1.Text = "Songlist";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 631);
            this.Controls.Add(this.time);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.songlistView);
            this.Controls.Add(this.setlistView);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.go);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Setlist Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.ListView setlistView;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader song;
        private System.Windows.Forms.ListView songlistView;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ColumnHeader songlistNumber;
        private System.Windows.Forms.ColumnHeader songlistName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songlistToolStripMenuItem1;
    }
}