using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MusicFinderBL.Model;

namespace MusicFinderView {
    public partial class MainForm : MetroForm {
        public MainForm() {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void downloadButton_Click(object sender, EventArgs e) {
            Finder finder = new Finder(searchTextBox.Text);
            searchTextBox.Text = finder.GetHTML(searchTextBox.Text);
        }
    }
}
