namespace KSnake
{
    partial class InputName
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
            this.tableInputName = new System.Windows.Forms.Label();
            this.inputUser = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableInputName
            // 
            this.tableInputName.AutoSize = true;
            this.tableInputName.BackColor = System.Drawing.Color.Transparent;
            this.tableInputName.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableInputName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableInputName.Location = new System.Drawing.Point(262, 199);
            this.tableInputName.Name = "tableInputName";
            this.tableInputName.Size = new System.Drawing.Size(264, 23);
            this.tableInputName.TabIndex = 0;
            this.tableInputName.Text = "Введите имя:";
            // 
            // inputUser
            // 
            this.inputUser.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputUser.Location = new System.Drawing.Point(266, 263);
            this.inputUser.Name = "inputUser";
            this.inputUser.Size = new System.Drawing.Size(260, 27);
            this.inputUser.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Submit.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Submit.Location = new System.Drawing.Point(326, 315);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(132, 39);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Готово";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // InputName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KSnake.Properties.Resources.mainFone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.inputUser);
            this.Controls.Add(this.tableInputName);
            this.Name = "InputName";
            this.Text = "InputName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableInputName;
        private System.Windows.Forms.TextBox inputUser;
        private System.Windows.Forms.Button Submit;
    }
}