namespace KSnake
{
    partial class MainMenu
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
            this.StartGameButton = new System.Windows.Forms.Button();
            this.buttonDesc = new System.Windows.Forms.Button();
            this.ChangeName = new System.Windows.Forms.Button();
            this.RecordsButton = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartGameButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.Location = new System.Drawing.Point(134, 176);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(201, 51);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Играть";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // buttonDesc
            // 
            this.buttonDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDesc.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDesc.Location = new System.Drawing.Point(134, 248);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(201, 54);
            this.buttonDesc.TabIndex = 1;
            this.buttonDesc.Text = "Описание";
            this.buttonDesc.UseVisualStyleBackColor = false;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // ChangeName
            // 
            this.ChangeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChangeName.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeName.Location = new System.Drawing.Point(134, 323);
            this.ChangeName.Name = "ChangeName";
            this.ChangeName.Size = new System.Drawing.Size(201, 54);
            this.ChangeName.TabIndex = 2;
            this.ChangeName.Text = "Смена имени";
            this.ChangeName.UseVisualStyleBackColor = false;
            this.ChangeName.Click += new System.EventHandler(this.ChangeName_Click);
            // 
            // RecordsButton
            // 
            this.RecordsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RecordsButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordsButton.Location = new System.Drawing.Point(134, 398);
            this.RecordsButton.Name = "RecordsButton";
            this.RecordsButton.Size = new System.Drawing.Size(201, 54);
            this.RecordsButton.TabIndex = 3;
            this.RecordsButton.Text = "Рекорды";
            this.RecordsButton.UseVisualStyleBackColor = false;
            this.RecordsButton.Click += new System.EventHandler(this.RecordsButton_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuit.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuit.Location = new System.Drawing.Point(134, 475);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(201, 54);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Выйти";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KSnake.Properties.Resources.mainFone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.RecordsButton);
            this.Controls.Add(this.ChangeName);
            this.Controls.Add(this.buttonDesc);
            this.Controls.Add(this.StartGameButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Button ChangeName;
        private System.Windows.Forms.Button RecordsButton;
        private System.Windows.Forms.Button buttonQuit;
    }
}