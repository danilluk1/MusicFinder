using System;
using System.Collections.Generic;
using MetroFramework.Forms;
using MusicFinderBL.Model;

namespace MusicFinderView {
    public partial class MainForm : MetroForm {
        readonly Finder finder = new Finder();
        public MainForm() {
            InitializeComponent();

            finder.ParseFailed += ParseFailed;
            finder.ParseSuccess += ParseSuccess;
            finder.DownloadSuccess += DownloadSuccess;
            finder.BarIncrement += BarIncrement;
        }
        private void BarIncrement(int procPercentage, long bytesReceived, long totalBytes) {
            metroProgressBar1.Value = procPercentage;
            switch (finder.PreferedDataTypeVal) {
                case PreferedDataType.Bytes:
                progressLabel.Text = bytesReceived + "/" + totalBytes + "Байт";
                break;
                case PreferedDataType.Kb:
                progressLabel.Text = String.Format("{0:f2} /  {1:f2} Кб", bytesReceived / 1024, totalBytes / 1024);
                break;
                case PreferedDataType.Mb:
                progressLabel.Text = String.Format("{0:f2} /  {1:f2} Мб", bytesReceived / (1024 * 1024), totalBytes / (1024 * 1024));
                break;
                case PreferedDataType.Gb:
                progressLabel.Text = String.Format("{0:f2} /  {1:f2} Гб", bytesReceived / (1024 * 1024 * 1024), totalBytes / (1024 * 1024 * 1024));
                break;
            }
        }

        private void DownloadSuccess(string songName) {
            downloadBox.Items.Add(songName);
        }
        private void ParseFailed() {
            progressLabel.Text = "Ошибка сервера!";
        }

        private void ParseSuccess() {
           
        }

        private void DownloadButton_Click(object sender, EventArgs e) {
            if (searchTextBox.Text.Length > 0) {
                finder.SearchRequest = searchTextBox.Text;
                string s = finder.GetHTML(searchTextBox.Text);
                finder.ParseAsync(s);
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e) {
            SettingsView view = new SettingsView(finder);
            view.Show();
        }
    }
}
