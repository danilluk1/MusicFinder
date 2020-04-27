namespace MusicFinderView {
    partial class SettingsView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            MetroFramework.Controls.MetroLabel licenseLabel;
            this.grBox = new System.Windows.Forms.GroupBox();
            this.pathButton = new MetroFramework.Controls.MetroButton();
            this.pathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            licenseLabel = new MetroFramework.Controls.MetroLabel();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // licenseLabel
            // 
            licenseLabel.AutoSize = true;
            licenseLabel.Location = new System.Drawing.Point(373, 461);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new System.Drawing.Size(204, 19);
            licenseLabel.TabIndex = 2;
            licenseLabel.Text = "danilluk1 | justovich@outlook.com";
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.pathButton);
            this.grBox.Controls.Add(this.pathTextBox);
            this.grBox.Controls.Add(this.metroLabel3);
            this.grBox.Controls.Add(this.metroLabel2);
            this.grBox.Controls.Add(this.formatComboBox);
            this.grBox.Location = new System.Drawing.Point(4, 24);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(363, 456);
            this.grBox.TabIndex = 0;
            this.grBox.TabStop = false;
            this.grBox.Text = "Настройки";
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(316, 55);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(24, 23);
            this.pathButton.TabIndex = 4;
            this.pathButton.Text = "...";
            this.pathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(121, 55);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(189, 23);
            this.pathTextBox.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Путь загрузки:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Формат данных:";
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "Байт",
            "Килобайт",
            "Мегабайт",
            "Гигабайт"});
            this.formatComboBox.Location = new System.Drawing.Point(121, 19);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(219, 21);
            this.formatComboBox.TabIndex = 0;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.FormatComboBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Music Finder v1.00";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 488);
            this.Controls.Add(licenseLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grBox);
            this.Name = "SettingsView";
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox formatComboBox;
        private MetroFramework.Controls.MetroButton pathButton;
        private MetroFramework.Controls.MetroTextBox pathTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}