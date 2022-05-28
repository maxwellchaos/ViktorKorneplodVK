
namespace testVk
{
    partial class FormLikePostOnPeoplesWall
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
            this.labelAccesTok = new System.Windows.Forms.Label();
            this.TakeLike = new System.Windows.Forms.Button();
            this.likesYN = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAccesTok
            // 
            this.labelAccesTok.AutoSize = true;
            this.labelAccesTok.Location = new System.Drawing.Point(12, 330);
            this.labelAccesTok.Name = "labelAccesTok";
            this.labelAccesTok.Size = new System.Drawing.Size(0, 17);
            this.labelAccesTok.TabIndex = 0;
            this.labelAccesTok.Click += new System.EventHandler(this.label1_Click);
            // 
            // TakeLike
            // 
            this.TakeLike.BackColor = System.Drawing.Color.White;
            this.TakeLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeLike.Location = new System.Drawing.Point(36, 217);
            this.TakeLike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TakeLike.Name = "TakeLike";
            this.TakeLike.Size = new System.Drawing.Size(113, 65);
            this.TakeLike.TabIndex = 1;
            this.TakeLike.Text = "Поставить лайки";
            this.TakeLike.UseVisualStyleBackColor = false;
            this.TakeLike.Click += new System.EventHandler(this.button1_Click);
            // 
            // likesYN
            // 
            this.likesYN.AutoSize = true;
            this.likesYN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.likesYN.Location = new System.Drawing.Point(1, 81);
            this.likesYN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likesYN.Name = "likesYN";
            this.likesYN.Size = new System.Drawing.Size(22, 31);
            this.likesYN.TabIndex = 4;
            this.likesYN.Text = ".";
            this.likesYN.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.Location = new System.Drawing.Point(248, 25);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(383, 29);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(12, 25);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(209, 29);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "Введите ссылку:";
            // 
            // FormLikePostOnPeoplesWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 308);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.likesYN);
            this.Controls.Add(this.TakeLike);
            this.Controls.Add(this.labelAccesTok);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLikePostOnPeoplesWall";
            this.Text = "FormLikePostOnPeoplesWall";
            this.Load += new System.EventHandler(this.FormLikePostOnPeoplesWall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccesTok;
        private System.Windows.Forms.Button TakeLike;
        private System.Windows.Forms.Label likesYN;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
    }
}