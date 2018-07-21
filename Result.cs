﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incrementer {
    public partial class ResultForm : Form {
        private string result;
        public ResultForm(string result) {
            this.result = result;
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e) {
            resultTextBox.Text = result;
        }
    }
}
