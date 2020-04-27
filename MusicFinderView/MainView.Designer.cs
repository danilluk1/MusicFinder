namespace MusicFinderView {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            MetroFramework.Controls.MetroLabel metroLabel1;
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.downloadButton = new MetroFramework.Controls.MetroButton();
            this.downloadBox = new System.Windows.Forms.ListBox();
            this.settingsButton = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.progressLabel = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new System.Drawing.Point(5, 33);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new System.Drawing.Size(96, 19);
            metroLabel1.TabIndex = 3;
            metroLabel1.Text = "Мои загрузки:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(5, 7);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(666, 23);
            this.searchTextBox.TabIndex = 0;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(677, 8);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(59, 22);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Скачать!";
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // downloadBox
            // 
            this.downloadBox.FormattingEnabled = true;
            this.downloadBox.Location = new System.Drawing.Point(5, 65);
            this.downloadBox.Name = "downloadBox";
            this.downloadBox.Size = new System.Drawing.Size(413, 680);
            this.downloadBox.TabIndex = 4;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(742, 8);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(65, 23);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(813, 7);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(65, 23);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Помощь";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(104, 36);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(421, 16);
            this.metroProgressBar1.TabIndex = 9;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(525, 30);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 0);
            this.progressLabel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(425, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 699);
            this.panel1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.downloadBox);
            this.Controls.Add(metroLabel1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "MainForm";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroButton downloadButton;
        private System.Windows.Forms.ListBox downloadBox;
        private MetroFramework.Controls.MetroButton settingsButton;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel progressLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

