namespace SetlistGenerator
{
    partial class AddSonglistView
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
            this.listViewSonglist = new System.Windows.Forms.ListView();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.comboBoxBalladVal = new System.Windows.Forms.ComboBox();
            this.comboBoxHeavyVal = new System.Windows.Forms.ComboBox();
            this.checkBoxIsBegin = new System.Windows.Forms.CheckBox();
            this.checkBoxIsEnd = new System.Windows.Forms.CheckBox();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLenght = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBalVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHeavyVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIsBegin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIsEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSonglist
            // 
            this.listViewSonglist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderLenght,
            this.columnHeaderBalVal,
            this.columnHeaderHeavyVal,
            this.columnHeaderIsBegin,
            this.columnHeaderIsEnd});
            this.listViewSonglist.Location = new System.Drawing.Point(13, 13);
            this.listViewSonglist.Name = "listViewSonglist";
            this.listViewSonglist.Size = new System.Drawing.Size(775, 384);
            this.listViewSonglist.TabIndex = 0;
            this.listViewSonglist.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(13, 418);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(30, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.Text = "Id";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(49, 418);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Text = "Songname";
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.Location = new System.Drawing.Point(258, 418);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(81, 20);
            this.textBoxLenght.TabIndex = 3;
            this.textBoxLenght.Text = "Lenght";
            // 
            // comboBoxBalladVal
            // 
            this.comboBoxBalladVal.DisplayMember = "1";
            this.comboBoxBalladVal.FormattingEnabled = true;
            this.comboBoxBalladVal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBalladVal.Location = new System.Drawing.Point(345, 417);
            this.comboBoxBalladVal.Name = "comboBoxBalladVal";
            this.comboBoxBalladVal.Size = new System.Drawing.Size(86, 21);
            this.comboBoxBalladVal.TabIndex = 4;
            this.comboBoxBalladVal.Text = "Ballad Value";
            // 
            // comboBoxHeavyVal
            // 
            this.comboBoxHeavyVal.FormattingEnabled = true;
            this.comboBoxHeavyVal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxHeavyVal.Location = new System.Drawing.Point(437, 417);
            this.comboBoxHeavyVal.Name = "comboBoxHeavyVal";
            this.comboBoxHeavyVal.Size = new System.Drawing.Size(86, 21);
            this.comboBoxHeavyVal.TabIndex = 5;
            this.comboBoxHeavyVal.Text = "Heavy Value";
            // 
            // checkBoxIsBegin
            // 
            this.checkBoxIsBegin.AutoSize = true;
            this.checkBoxIsBegin.Location = new System.Drawing.Point(530, 421);
            this.checkBoxIsBegin.Name = "checkBoxIsBegin";
            this.checkBoxIsBegin.Size = new System.Drawing.Size(101, 17);
            this.checkBoxIsBegin.TabIndex = 6;
            this.checkBoxIsBegin.Text = "Beginning Song";
            this.checkBoxIsBegin.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsEnd
            // 
            this.checkBoxIsEnd.AutoSize = true;
            this.checkBoxIsEnd.Location = new System.Drawing.Point(637, 421);
            this.checkBoxIsEnd.Name = "checkBoxIsEnd";
            this.checkBoxIsEnd.Size = new System.Drawing.Size(73, 17);
            this.checkBoxIsEnd.TabIndex = 7;
            this.checkBoxIsEnd.Text = "End Song";
            this.checkBoxIsEnd.UseVisualStyleBackColor = true;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 10;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderLenght
            // 
            this.columnHeaderLenght.Text = "Lenght";
            this.columnHeaderLenght.Width = 40;
            // 
            // columnHeaderBalVal
            // 
            this.columnHeaderBalVal.Text = "Ballad Value";
            this.columnHeaderBalVal.Width = 10;
            // 
            // columnHeaderHeavyVal
            // 
            this.columnHeaderHeavyVal.Text = "Heavy Value";
            this.columnHeaderHeavyVal.Width = 10;
            // 
            // columnHeaderIsBegin
            // 
            this.columnHeaderIsBegin.Text = "Beginning Song";
            this.columnHeaderIsBegin.Width = 10;
            // 
            // columnHeaderIsEnd
            // 
            this.columnHeaderIsEnd.Text = "Ending Song";
            this.columnHeaderIsEnd.Width = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(717, 415);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // AddSonglistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxIsEnd);
            this.Controls.Add(this.checkBoxIsBegin);
            this.Controls.Add(this.comboBoxHeavyVal);
            this.Controls.Add(this.comboBoxBalladVal);
            this.Controls.Add(this.textBoxLenght);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.listViewSonglist);
            this.Name = "AddSonglistView";
            this.Text = "Songlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSonglist;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.ComboBox comboBoxBalladVal;
        private System.Windows.Forms.ComboBox comboBoxHeavyVal;
        private System.Windows.Forms.CheckBox checkBoxIsBegin;
        private System.Windows.Forms.CheckBox checkBoxIsEnd;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderLenght;
        private System.Windows.Forms.ColumnHeader columnHeaderBalVal;
        private System.Windows.Forms.ColumnHeader columnHeaderHeavyVal;
        private System.Windows.Forms.ColumnHeader columnHeaderIsBegin;
        private System.Windows.Forms.ColumnHeader columnHeaderIsEnd;
        private System.Windows.Forms.Button buttonAdd;
    }
}