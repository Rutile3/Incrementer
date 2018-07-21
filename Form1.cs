using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incrementer {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e) {
            
        }

        private void IncrementButton_Click(object sender, EventArgs e) {
            if (targetTextBox.Text == "" || frontTextBox.Text == "")
                return;//未入力時は即リターン

            string[] split_string = { "\r\n" };
            string[] rows = targetTextBox.Text.Split(split_string, StringSplitOptions.None);
            StringBuilder result = new StringBuilder();

            foreach(string row in rows) {

            }
        }
    }
}
