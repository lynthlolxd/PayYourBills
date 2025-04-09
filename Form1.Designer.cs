namespace PayYourBills
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameStartButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.GameExitButton = new System.Windows.Forms.Button();
            this.AboutGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAY YOUR BILLS!!!!!!!!11";
            // 
            // GameStartButton
            // 
            this.GameStartButton.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartButton.Location = new System.Drawing.Point(23, 213);
            this.GameStartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(267, 108);
            this.GameStartButton.TabIndex = 1;
            this.GameStartButton.Text = "Начать игру";
            this.GameStartButton.UseVisualStyleBackColor = true;
            this.GameStartButton.Click += new System.EventHandler(this.GameStartButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(23, 352);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(267, 108);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // GameExitButton
            // 
            this.GameExitButton.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameExitButton.Location = new System.Drawing.Point(23, 502);
            this.GameExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GameExitButton.Name = "GameExitButton";
            this.GameExitButton.Size = new System.Drawing.Size(267, 108);
            this.GameExitButton.TabIndex = 3;
            this.GameExitButton.Text = "Выход:(";
            this.GameExitButton.UseVisualStyleBackColor = true;
            this.GameExitButton.Click += new System.EventHandler(this.GameExitButton_Click);
            // 
            // AboutGame
            // 
            this.AboutGame.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutGame.Location = new System.Drawing.Point(13, 938);
            this.AboutGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AboutGame.Name = "AboutGame";
            this.AboutGame.Size = new System.Drawing.Size(181, 111);
            this.AboutGame.TabIndex = 4;
            this.AboutGame.Text = "*ТЫК*";
            this.AboutGame.UseVisualStyleBackColor = true;
            this.AboutGame.Click += new System.EventHandler(this.AboutGame_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 985);
            this.Controls.Add(this.AboutGame);
            this.Controls.Add(this.GameExitButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.GameStartButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GameStartButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button GameExitButton;
        private System.Windows.Forms.Button AboutGame;
    }
}

