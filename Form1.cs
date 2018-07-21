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
            StringBuilder tmp = new StringBuilder();
            tmp.AppendLine("row(");
            tmp.AppendLine("row(123");
            tmp.AppendLine("rows(");
            tmp.AppendLine("rows(123");
            tmp.AppendLine("row()");
            tmp.AppendLine("row(123)");
            tmp.AppendLine("rows()");
            tmp.AppendLine("rows(123)");
            tmp.AppendLine("row(");
            targetTextBox.Text = tmp.ToString();
            frontTextBox.Text = "row(";
        }

        private void IncrementButton_Click(object sender, EventArgs e) {
            if (targetTextBox.Text == "" || frontTextBox.Text == "")
                return;//未入力時は即リターン

            string front_text = frontTextBox.Text;
            string[] split_string = { "\r\n" };
            string[] rows = targetTextBox.Text.Split(split_string, StringSplitOptions.None);
            StringBuilder result = new StringBuilder();

            foreach(string row in rows) {
                int index = row.IndexOf(front_text);
                if (index != -1) {
                    index += front_text.Length;
                    result.Append(row.Substring(0, index));

                    bool exists_target_value = false;
                    decimal target_value = 0;
                    while (index < row.Length && '0' <= row[index] && row[index] <= '9') {
                        exists_target_value = true;
                        target_value *= 10;
                        target_value += decimal.Parse(new string(new char[] { row[index]}));
                        index++;
                    }
                    if (exists_target_value) {
                        target_value += incrementTextBox.Value;
                        result.Append(target_value.ToString());
                    }
                    result.AppendLine(row.Substring(index));
                }
                else
                    result.AppendLine(row);
            }

            //ややこしいが、最終行で改行しないようにしてます
            targetTextBox.Text = result.Remove(result.Length - 2, 2).ToString();
            if (copyTrueToolStripMenuItem.Checked)
                Clipboard.SetText(result.ToString());
        }

        private void outputMainFormToolStripMenuItem_Click(object sender, EventArgs e) {
            outputMainFormToolStripMenuItem.Checked = true;
            outputResultFormToolStripMenuItem.Checked = false;
        }

        private void outputResultFormToolStripMenuItem_Click(object sender, EventArgs e) {
            outputMainFormToolStripMenuItem.Checked = false;
            outputResultFormToolStripMenuItem.Checked = true;
        }

        private void copyTrueToolStripMenuItem_Click(object sender, EventArgs e) {
            copyTrueToolStripMenuItem.Checked = true;
            copyFalseToolStripMenuItem.Checked = false;
        }

        private void copyFalseToolStripMenuItem_Click(object sender, EventArgs e) {
            copyTrueToolStripMenuItem.Checked = false;
            copyFalseToolStripMenuItem.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
