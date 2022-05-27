
namespace testVk
{
    partial class FormCommentPostovSoob
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
            this.labelAccessTok = new System.Windows.Forms.Label();
            this.buttonInfoGet = new System.Windows.Forms.Button();
            this.textBoxInfoPosts = new System.Windows.Forms.TextBox();
            this.textBoxCreateComment = new System.Windows.Forms.TextBox();
            this.buttonCreateComment = new System.Windows.Forms.Button();
            this.textBoxSetSearchValue = new System.Windows.Forms.TextBox();
            this.IDtextBoxPoisckID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGroupsSearch = new System.Windows.Forms.Button();
            this.ErrorAndSuccessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAccessTok
            // 
            this.labelAccessTok.AutoSize = true;
            this.labelAccessTok.Location = new System.Drawing.Point(9, 9);
            this.labelAccessTok.Name = "labelAccessTok";
            this.labelAccessTok.Size = new System.Drawing.Size(35, 13);
            this.labelAccessTok.TabIndex = 0;
            this.labelAccessTok.Text = "label1";
            this.labelAccessTok.Visible = false;
            this.labelAccessTok.Click += new System.EventHandler(this.labelAccessTok_Click);
            // 
            // buttonInfoGet
            // 
            this.buttonInfoGet.Location = new System.Drawing.Point(2, 51);
            this.buttonInfoGet.Name = "buttonInfoGet";
            this.buttonInfoGet.Size = new System.Drawing.Size(112, 48);
            this.buttonInfoGet.TabIndex = 1;
            this.buttonInfoGet.Text = "Получить информацию";
            this.buttonInfoGet.UseVisualStyleBackColor = true;
            this.buttonInfoGet.Click += new System.EventHandler(this.buttonInfoGet_Click);
            // 
            // textBoxInfoPosts
            // 
            this.textBoxInfoPosts.Location = new System.Drawing.Point(217, 6);
            this.textBoxInfoPosts.Multiline = true;
            this.textBoxInfoPosts.Name = "textBoxInfoPosts";
            this.textBoxInfoPosts.Size = new System.Drawing.Size(580, 296);
            this.textBoxInfoPosts.TabIndex = 2;
            // 
            // textBoxCreateComment
            // 
            this.textBoxCreateComment.Location = new System.Drawing.Point(264, 324);
            this.textBoxCreateComment.Multiline = true;
            this.textBoxCreateComment.Name = "textBoxCreateComment";
            this.textBoxCreateComment.Size = new System.Drawing.Size(533, 104);
            this.textBoxCreateComment.TabIndex = 3;
            this.textBoxCreateComment.TextChanged += new System.EventHandler(this.textBoxCreateComment_TextChanged);
            // 
            // buttonCreateComment
            // 
            this.buttonCreateComment.Location = new System.Drawing.Point(135, 399);
            this.buttonCreateComment.Name = "buttonCreateComment";
            this.buttonCreateComment.Size = new System.Drawing.Size(123, 29);
            this.buttonCreateComment.TabIndex = 4;
            this.buttonCreateComment.Text = "Отправить";
            this.buttonCreateComment.UseVisualStyleBackColor = true;
            this.buttonCreateComment.Click += new System.EventHandler(this.buttonCreateComment_Click);
            // 
            // textBoxSetSearchValue
            // 
            this.textBoxSetSearchValue.Location = new System.Drawing.Point(2, 25);
            this.textBoxSetSearchValue.Name = "textBoxSetSearchValue";
            this.textBoxSetSearchValue.Size = new System.Drawing.Size(209, 20);
            this.textBoxSetSearchValue.TabIndex = 5;
            this.textBoxSetSearchValue.TextChanged += new System.EventHandler(this.textBoxSetSearchValue_TextChanged);
            // 
            // IDtextBoxPoisckID
            // 
            this.IDtextBoxPoisckID.Location = new System.Drawing.Point(2, 133);
            this.IDtextBoxPoisckID.Name = "IDtextBoxPoisckID";
            this.IDtextBoxPoisckID.Size = new System.Drawing.Size(209, 20);
            this.IDtextBoxPoisckID.TabIndex = 6;
            this.IDtextBoxPoisckID.TextChanged += new System.EventHandler(this.IDtextBoxPoisckID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID комментируемого";
            // 
            // buttonGroupsSearch
            // 
            this.buttonGroupsSearch.Location = new System.Drawing.Point(2, 159);
            this.buttonGroupsSearch.Name = "buttonGroupsSearch";
            this.buttonGroupsSearch.Size = new System.Drawing.Size(114, 35);
            this.buttonGroupsSearch.TabIndex = 8;
            this.buttonGroupsSearch.Text = "Получить сообщества";
            this.buttonGroupsSearch.UseVisualStyleBackColor = true;
            this.buttonGroupsSearch.Click += new System.EventHandler(this.buttonGroupsSearch_Click);
            // 
            // ErrorAndSuccessLabel
            // 
            this.ErrorAndSuccessLabel.AutoSize = true;
            this.ErrorAndSuccessLabel.Location = new System.Drawing.Point(2, 201);
            this.ErrorAndSuccessLabel.Name = "ErrorAndSuccessLabel";
            this.ErrorAndSuccessLabel.Size = new System.Drawing.Size(35, 13);
            this.ErrorAndSuccessLabel.TabIndex = 9;
            this.ErrorAndSuccessLabel.Text = "label3";
            // 
            // FormCommentPostovSoob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorAndSuccessLabel);
            this.Controls.Add(this.buttonGroupsSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDtextBoxPoisckID);
            this.Controls.Add(this.textBoxSetSearchValue);
            this.Controls.Add(this.buttonCreateComment);
            this.Controls.Add(this.textBoxCreateComment);
            this.Controls.Add(this.textBoxInfoPosts);
            this.Controls.Add(this.buttonInfoGet);
            this.Controls.Add(this.labelAccessTok);
            this.Name = "FormCommentPostovSoob";
            this.Text = "FormCommentPostovSoob";
            this.Load += new System.EventHandler(this.FormCommentPostovSoob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccessTok;
        private System.Windows.Forms.Button buttonInfoGet;
        private System.Windows.Forms.TextBox textBoxInfoPosts;
        private System.Windows.Forms.TextBox textBoxCreateComment;
        private System.Windows.Forms.Button buttonCreateComment;
        private System.Windows.Forms.TextBox textBoxSetSearchValue;
        private System.Windows.Forms.TextBox IDtextBoxPoisckID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGroupsSearch;
        private System.Windows.Forms.Label ErrorAndSuccessLabel;
    }
}