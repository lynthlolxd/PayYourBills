namespace PayYourBills
{
    partial class SettingsForm
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
            this.BackToMenubtn = new System.Windows.Forms.Button();
            this.Fullscreen = new System.Windows.Forms.CheckBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.ResetProgress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToMenubtn
            // 
            this.BackToMenubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(201)));
            this.BackToMenubtn.Location = new System.Drawing.Point(12, 862);
            this.BackToMenubtn.Name = "BackToMenubtn";
            this.BackToMenubtn.Size = new System.Drawing.Size(264, 111);
            this.BackToMenubtn.TabIndex = 0;
            this.BackToMenubtn.Text = "Назад";
            this.BackToMenubtn.UseVisualStyleBackColor = true;
            this.BackToMenubtn.Click += new System.EventHandler(this.BackToMenubtn_Click);
            // 
            // Fullscreen
            // 
            this.Fullscreen.AutoSize = true;
            this.Fullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fullscreen.Location = new System.Drawing.Point(108, 62);
            this.Fullscreen.Name = "Fullscreen";
            this.Fullscreen.Size = new System.Drawing.Size(404, 43);
            this.Fullscreen.TabIndex = 1;
            this.Fullscreen.Text = "Полноэкранный режим";
            this.Fullscreen.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(108, 280);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(168, 68);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Применить изменения";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ResetProgress
            // 
            this.ResetProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetProgress.Location = new System.Drawing.Point(108, 188);
            this.ResetProgress.Name = "ResetProgress";
            this.ResetProgress.Size = new System.Drawing.Size(168, 68);
            this.ResetProgress.TabIndex = 3;
            this.ResetProgress.Text = "Сбросить прогресс";
            this.ResetProgress.UseVisualStyleBackColor = true;
            this.ResetProgress.Click += new System.EventHandler(this.ResetProgress_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 985);
            this.Controls.Add(this.ResetProgress);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.Fullscreen);
            this.Controls.Add(this.BackToMenubtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenubtn;
        private System.Windows.Forms.CheckBox Fullscreen;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button ResetProgress;
    }
}