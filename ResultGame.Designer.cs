namespace KSnake
{
    partial class ResultGame
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureIconApple = new System.Windows.Forms.PictureBox();
            this.pictureIconBanana = new System.Windows.Forms.PictureBox();
            this.pictureIconPear = new System.Windows.Forms.PictureBox();
            this.countApple = new System.Windows.Forms.Label();
            this.countBanana = new System.Windows.Forms.Label();
            this.countPear = new System.Windows.Forms.Label();
            this.backToMenu_result = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconPear)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ResultLabel.Location = new System.Drawing.Point(257, 179);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(310, 20);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Результаты игры";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.NameLabel.Location = new System.Drawing.Point(260, 250);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "ИМЯ:";
            // 
            // pictureIconApple
            // 
            this.pictureIconApple.BackColor = System.Drawing.Color.Transparent;
            this.pictureIconApple.BackgroundImage = global::KSnake.Properties.Resources.apple;
            this.pictureIconApple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureIconApple.Location = new System.Drawing.Point(263, 307);
            this.pictureIconApple.Name = "pictureIconApple";
            this.pictureIconApple.Size = new System.Drawing.Size(37, 34);
            this.pictureIconApple.TabIndex = 2;
            this.pictureIconApple.TabStop = false;
            // 
            // pictureIconBanana
            // 
            this.pictureIconBanana.BackColor = System.Drawing.Color.Transparent;
            this.pictureIconBanana.BackgroundImage = global::KSnake.Properties.Resources.banana;
            this.pictureIconBanana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureIconBanana.Location = new System.Drawing.Point(260, 367);
            this.pictureIconBanana.Name = "pictureIconBanana";
            this.pictureIconBanana.Size = new System.Drawing.Size(40, 34);
            this.pictureIconBanana.TabIndex = 3;
            this.pictureIconBanana.TabStop = false;
            // 
            // pictureIconPear
            // 
            this.pictureIconPear.BackColor = System.Drawing.Color.Transparent;
            this.pictureIconPear.BackgroundImage = global::KSnake.Properties.Resources.pear;
            this.pictureIconPear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureIconPear.Location = new System.Drawing.Point(260, 428);
            this.pictureIconPear.Name = "pictureIconPear";
            this.pictureIconPear.Size = new System.Drawing.Size(40, 33);
            this.pictureIconPear.TabIndex = 4;
            this.pictureIconPear.TabStop = false;
            // 
            // countApple
            // 
            this.countApple.AutoSize = true;
            this.countApple.BackColor = System.Drawing.Color.Transparent;
            this.countApple.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countApple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countApple.Location = new System.Drawing.Point(324, 307);
            this.countApple.Name = "countApple";
            this.countApple.Size = new System.Drawing.Size(23, 23);
            this.countApple.TabIndex = 5;
            this.countApple.Text = "0";
            // 
            // countBanana
            // 
            this.countBanana.AutoSize = true;
            this.countBanana.BackColor = System.Drawing.Color.Transparent;
            this.countBanana.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBanana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countBanana.Location = new System.Drawing.Point(324, 367);
            this.countBanana.Name = "countBanana";
            this.countBanana.Size = new System.Drawing.Size(23, 23);
            this.countBanana.TabIndex = 6;
            this.countBanana.Text = "0";
            // 
            // countPear
            // 
            this.countPear.AutoSize = true;
            this.countPear.BackColor = System.Drawing.Color.Transparent;
            this.countPear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countPear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countPear.Location = new System.Drawing.Point(324, 428);
            this.countPear.Name = "countPear";
            this.countPear.Size = new System.Drawing.Size(23, 23);
            this.countPear.TabIndex = 7;
            this.countPear.Text = "0";
            // 
            // backToMenu_result
            // 
            this.backToMenu_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToMenu_result.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenu_result.Location = new System.Drawing.Point(73, 609);
            this.backToMenu_result.Name = "backToMenu_result";
            this.backToMenu_result.Size = new System.Drawing.Size(128, 38);
            this.backToMenu_result.TabIndex = 8;
            this.backToMenu_result.Text = "В меню";
            this.backToMenu_result.UseVisualStyleBackColor = false;
            this.backToMenu_result.Click += new System.EventHandler(this.backToMenu_result_Click);
            // 
            // ResultGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KSnake.Properties.Resources.mainFone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.backToMenu_result);
            this.Controls.Add(this.countPear);
            this.Controls.Add(this.countBanana);
            this.Controls.Add(this.countApple);
            this.Controls.Add(this.pictureIconPear);
            this.Controls.Add(this.pictureIconBanana);
            this.Controls.Add(this.pictureIconApple);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ResultLabel);
            this.Name = "ResultGame";
            this.Text = "ResultGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconPear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureIconApple;
        private System.Windows.Forms.PictureBox pictureIconBanana;
        private System.Windows.Forms.PictureBox pictureIconPear;
        private System.Windows.Forms.Label countApple;
        private System.Windows.Forms.Label countBanana;
        private System.Windows.Forms.Label countPear;
        private System.Windows.Forms.Button backToMenu_result;
    }
}