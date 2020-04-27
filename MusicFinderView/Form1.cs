using System;
using MetroFramework.Forms;
using MusicFinderBL.Model;

namespace MusicFinderView {
    public partial class MainForm : MetroForm {

        Finder finder = new Finder();
        public MainForm() {
            InitializeComponent();

            finder.ParseFailed += ParseFailed;
            finder.ParseSuccess += ParseSuccess;
            finder.DownloadSuccess += DownloadSuccess;
            finder.BarIncrement += BarIncrement;
        }
        private void BarIncrement(int procPercentage, long bytesReceived, long totalBytes) {
            metroProgressBar1.Value = procPercentage;
            progressLabel.Text = bytesReceived / 1024 + "/" + totalBytes / 1024 + "Кб";
        }

        private void DownloadSuccess() {

        }
        private void ParseFailed() {

        }

        private void ParseSuccess() {

        }

        private void DownloadButton_Click(object sender, EventArgs e) {
            finder.SearchRequest = searchTextBox.Text;
            string s = finder.GetHTML(searchTextBox.Text);
            finder.ParseAsync(s);
        }

        private void SettingsButton_Click(object sender, EventArgs e) {
            SettingsView view = new SettingsView();
        }
    }
}
