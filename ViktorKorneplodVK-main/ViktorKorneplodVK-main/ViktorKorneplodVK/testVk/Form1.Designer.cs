﻿
namespace testVk
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartWebBrowser = new System.Windows.Forms.WebBrowser();
            this.AccessTokenTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.buttonLikePostOnPeoplesWall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartWebBrowser
            // 
            this.StartWebBrowser.Location = new System.Drawing.Point(624, 38);
            this.StartWebBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.StartWebBrowser.Name = "StartWebBrowser";
            this.StartWebBrowser.Size = new System.Drawing.Size(460, 362);
            this.StartWebBrowser.TabIndex = 2;
            this.StartWebBrowser.Url = new System.Uri("https://oauth.vk.com/authorize?client_id=8104769&display=page&redirect_uri=https:" +
        "//oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.131&state=123456" +
        "", System.UriKind.Absolute);
            this.StartWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Location = new System.Drawing.Point(16, 439);
            this.AccessTokenTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.Size = new System.Drawing.Size(1049, 22);
            this.AccessTokenTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(31, 38);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(109, 39);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "label1";
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(399, 38);
            this.AvatarPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(183, 172);
            this.AvatarPictureBox.TabIndex = 5;
            this.AvatarPictureBox.TabStop = false;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(31, 94);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(109, 39);
            this.FirstNameLabel.TabIndex = 6;
            this.FirstNameLabel.Text = "label1";
            // 
            // buttonLikePostOnPeoplesWall
            // 
            this.buttonLikePostOnPeoplesWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLikePostOnPeoplesWall.Location = new System.Drawing.Point(217, 39);
            this.buttonLikePostOnPeoplesWall.Name = "buttonLikePostOnPeoplesWall";
            this.buttonLikePostOnPeoplesWall.Size = new System.Drawing.Size(139, 51);
            this.buttonLikePostOnPeoplesWall.TabIndex = 7;
            this.buttonLikePostOnPeoplesWall.Text = "лайкер постов на стене человека";
            this.buttonLikePostOnPeoplesWall.UseVisualStyleBackColor = true;
            this.buttonLikePostOnPeoplesWall.Click += new System.EventHandler(this.buttonLikePostOnPeoplesWall_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 482);
            this.Controls.Add(this.buttonLikePostOnPeoplesWall);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.AccessTokenTextBox);
            this.Controls.Add(this.StartWebBrowser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Виктор Корнеплод VK";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser StartWebBrowser;
        private System.Windows.Forms.TextBox AccessTokenTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button buttonLikePostOnPeoplesWall;
    }
}

