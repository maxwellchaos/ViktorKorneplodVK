
namespace testVk
{
    partial class frindsSuggestions
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
            this.buttonFriends = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFriends
            // 
            this.buttonFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFriends.Location = new System.Drawing.Point(578, 240);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(111, 41);
            this.buttonFriends.TabIndex = 0;
            this.buttonFriends.Text = "КНОПКА";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // labelButton
            // 
            this.labelButton.AutoSize = true;
            this.labelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelButton.Location = new System.Drawing.Point(12, 246);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(529, 26);
            this.labelButton.TabIndex = 3;
            this.labelButton.Text = "2)Нажмите на кнопку, чтобы добавить в друзья-->";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFriends.Location = new System.Drawing.Point(309, 361);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(258, 29);
            this.labelFriends.TabIndex = 4;
            this.labelFriends.Text = "Добавляю в друзья:)";
            this.labelFriends.Visible = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(12, 35);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(677, 26);
            this.labelText.TabIndex = 5;
            this.labelText.Text = "1)Введите текст сопроводительного сообщения (необязательно)";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(17, 79);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(672, 120);
            this.textBoxText.TabIndex = 6;
            // 
            // frindsSuggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelButton);
            this.Controls.Add(this.buttonFriends);
            this.Name = "frindsSuggestions";
            this.Text = "frindsSuggestions";
            this.Load += new System.EventHandler(this.frindsSuggestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textBoxText;
    }
}