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
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.listView1 = new System.Windows.Forms.ListView();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(15, 15);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(885, 23);
            this.searchTextBox.TabIndex = 0;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(906, 6);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(73, 33);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Скачать!";
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(986, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new System.Drawing.Point(15, 64);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new System.Drawing.Size(96, 19);
            metroLabel1.TabIndex = 3;
            metroLabel1.Text = "Мои загрузки:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(986, 658);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.listView1);
            this.Controls.Add(metroLabel1);
            this.Controls.Add(this.exitButton);
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
        private MetroFramework.Controls.MetroButton exitButton;
        private System.Windows.Forms.ListView listView1;
    }
}

