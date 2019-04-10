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
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.songlistNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songlistName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.go.Location = new System.Drawing.Point(350, 280);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(101, 23);
            this.go.TabIndex = 0;
            this.go.Text = "Start";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.Location = new System.Drawing.Point(13, 13);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(686, 20);
            this.filePath.TabIndex = 1;
            this.filePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browse
            // 
            this.browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browse.Location = new System.Drawing.Point(713, 13);
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
            this.setlistView.Location = new System.Drawing.Point(457, 39);
            this.setlistView.Name = "setlistView";
            this.setlistView.Size = new System.Drawing.Size(331, 399);
            this.setlistView.TabIndex = 3;
            this.setlistView.UseCompatibleStateImageBehavior = false;
            // 
            // number
            // 
            this.number.Text = "No.";
            // 
            // song
            // 
            this.song.Text = "Song";
            this.song.Width = 600;
            // 
            // songlistView
            // 
            this.songlistView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.songlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songlistNumber,
            this.songlistName});
            this.songlistView.Location = new System.Drawing.Point(13, 39);
            this.songlistView.Name = "songlistView";
            this.songlistView.Size = new System.Drawing.Size(331, 399);
            this.songlistView.TabIndex = 4;
            this.songlistView.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxLength.Location = new System.Drawing.Point(350, 190);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(101, 20);
            this.textBoxLength.TabIndex = 5;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(351, 171);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(71, 13);
            this.time.TabIndex = 6;
            this.time.Text = "Setlist Length";
            // 
            // songlistNumber
            // 
            this.songlistNumber.Text = "No.";
            // 
            // songlistName
            // 
            this.songlistName.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.songlistView);
            this.Controls.Add(this.setlistView);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.go);
            this.Name = "MainForm";
            this.Text = "MainForm";
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
    }
}