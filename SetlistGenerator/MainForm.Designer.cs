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
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(350, 415);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 0;
            this.go.Text = "Start";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(13, 13);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(686, 20);
            this.filePath.TabIndex = 1;
            this.filePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browse
            // 
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
            this.setlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.song});
            this.setlistView.Location = new System.Drawing.Point(12, 39);
            this.setlistView.Name = "setlistView";
            this.setlistView.Size = new System.Drawing.Size(776, 370);
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}