namespace testVk
{
    partial class LikePhotoFriend
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
            this.buttonfriend = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1PhotoFriend = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonfriend
            // 
            this.buttonfriend.Location = new System.Drawing.Point(96, 187);
            this.buttonfriend.Name = "buttonfriend";
            this.buttonfriend.Size = new System.Drawing.Size(126, 36);
            this.buttonfriend.TabIndex = 1;
            this.buttonfriend.Text = "Показать друзей";
            this.buttonfriend.UseVisualStyleBackColor = true;
            this.buttonfriend.Click += new System.EventHandler(this.buttonfriend_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(228, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 292);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // textBox1PhotoFriend
            // 
            this.textBox1PhotoFriend.Location = new System.Drawing.Point(581, 69);
            this.textBox1PhotoFriend.Multiline = true;
            this.textBox1PhotoFriend.Name = "textBox1PhotoFriend";
            this.textBox1PhotoFriend.Size = new System.Drawing.Size(261, 292);
            this.textBox1PhotoFriend.TabIndex = 6;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 112;
            // 
            // LikePhotoFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.textBox1PhotoFriend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonfriend);
            this.Name = "LikePhotoFriend";
            this.Text = "LikePhotoFriend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonfriend;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1PhotoFriend;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}