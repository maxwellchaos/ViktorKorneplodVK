
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
            this.DeletingBannedBlockedFriends = new System.Windows.Forms.Button();
            this.LikePhotoFriend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartWebBrowser
            // 
            this.StartWebBrowser.Location = new System.Drawing.Point(468, 31);
            this.StartWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.StartWebBrowser.Name = "StartWebBrowser";
            this.StartWebBrowser.Size = new System.Drawing.Size(345, 294);
            this.StartWebBrowser.TabIndex = 2;
            this.StartWebBrowser.Url = new System.Uri("https://oauth.vk.com/authorize?client_id=8104769&display=page&redirect_uri=https:" +
        "//oauth.vk.com/blank.html&scope=friends+stories+photos+wall&response_type=token&" +
        "v=5.131&state=123456", System.UriKind.Absolute);
            this.StartWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Location = new System.Drawing.Point(12, 357);
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.Size = new System.Drawing.Size(788, 20);
            this.AccessTokenTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(23, 31);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 31);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "label1";
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(299, 31);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(137, 140);
            this.AvatarPictureBox.TabIndex = 5;
            this.AvatarPictureBox.TabStop = false;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(23, 76);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(86, 31);
            this.FirstNameLabel.TabIndex = 6;
            this.FirstNameLabel.Text = "label1";
            // 
            // DeletingBannedBlockedFriends
            // 
            this.DeletingBannedBlockedFriends.Location = new System.Drawing.Point(12, 131);
            this.DeletingBannedBlockedFriends.Name = "DeletingBannedBlockedFriends";
            this.DeletingBannedBlockedFriends.Size = new System.Drawing.Size(176, 52);
            this.DeletingBannedBlockedFriends.TabIndex = 7;
            this.DeletingBannedBlockedFriends.Text = "удаление из друзей заблокированных/забанненых";
            this.DeletingBannedBlockedFriends.UseVisualStyleBackColor = true;
            this.DeletingBannedBlockedFriends.Click += new System.EventHandler(this.DeletingBannedBlockedFriends_Click);
            // 
            // LikePhotoFriend
            // 
            this.LikePhotoFriend.Location = new System.Drawing.Point(13, 205);
            this.LikePhotoFriend.Name = "LikePhotoFriend";
            this.LikePhotoFriend.Size = new System.Drawing.Size(175, 40);
            this.LikePhotoFriend.TabIndex = 8;
            this.LikePhotoFriend.Text = "лайкать фотографии друга";
            this.LikePhotoFriend.UseVisualStyleBackColor = true;
            this.LikePhotoFriend.Click += new System.EventHandler(this.LikePhotoFriend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "кидать заявки друзьям друзей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LikePhotoFriend);
            this.Controls.Add(this.DeletingBannedBlockedFriends);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.AccessTokenTextBox);
            this.Controls.Add(this.StartWebBrowser);
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
        private System.Windows.Forms.Button DeletingBannedBlockedFriends;
        private System.Windows.Forms.Button LikePhotoFriend;
        private System.Windows.Forms.Button button1;
    }
}

