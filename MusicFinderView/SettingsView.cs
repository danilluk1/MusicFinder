using MetroFramework.Forms;
using MusicFinderBL.Model;
using System;
using System.Windows.Forms;

namespace MusicFinderView {
    public partial class SettingsView : MetroForm {
        private readonly Finder _finder;
        public SettingsView(Finder finder) {
            InitializeComponent();
            _finder = finder;
        }

        private void PathButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK) {
                _finder.DownloadPath = fbd.SelectedPath;
                pathTextBox.Text = fbd.SelectedPath;
            }

        }

        private void FormatComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (formatComboBox.SelectedItem.Equals("Байт")) {
                _finder.PreferedDataTypeVal = PreferedDataType.Bytes;
            }
            else if (formatComboBox.SelectedItem.Equals("Килобайт")) {
                _finder.PreferedDataTypeVal = PreferedDataType.Kb;
            }
            else if (formatComboBox.SelectedItem.Equals("Мегабайт")) {
                _finder.PreferedDataTypeVal = PreferedDataType.Mb;
            }
            else if (formatComboBox.SelectedItem.Equals("Гигабайт")) {
                _finder.PreferedDataTypeVal = PreferedDataType.Gb;
            }
        }
    }
}
