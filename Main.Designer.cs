namespace Incrementer {
    partial class MainForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frontTextBox = new System.Windows.Forms.TextBox();
            this.incrementTextBox = new System.Windows.Forms.NumericUpDown();
            this.IncrementButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputResultFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTrueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFalseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.incrementTextBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetTextBox
            // 
            this.targetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetTextBox.Location = new System.Drawing.Point(12, 27);
            this.targetTextBox.Multiline = true;
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(200, 172);
            this.targetTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "直前の文字列";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "加算値";
            // 
            // frontTextBox
            // 
            this.frontTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frontTextBox.Location = new System.Drawing.Point(94, 205);
            this.frontTextBox.Name = "frontTextBox";
            this.frontTextBox.Size = new System.Drawing.Size(118, 19);
            this.frontTextBox.TabIndex = 3;
            // 
            // incrementTextBox
            // 
            this.incrementTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incrementTextBox.Location = new System.Drawing.Point(94, 231);
            this.incrementTextBox.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.incrementTextBox.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.incrementTextBox.Name = "incrementTextBox";
            this.incrementTextBox.Size = new System.Drawing.Size(37, 19);
            this.incrementTextBox.TabIndex = 4;
            // 
            // IncrementButton
            // 
            this.IncrementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IncrementButton.Location = new System.Drawing.Point(137, 230);
            this.IncrementButton.Name = "IncrementButton";
            this.IncrementButton.Size = new System.Drawing.Size(75, 19);
            this.IncrementButton.TabIndex = 5;
            this.IncrementButton.Text = "加算";
            this.IncrementButton.UseVisualStyleBackColor = true;
            this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(224, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.設定ToolStripMenuItem.Text = "設定(&S)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "終了(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputMainFormToolStripMenuItem,
            this.outputResultFormToolStripMenuItem});
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.resultToolStripMenuItem.Text = "出力結果(&O)";
            // 
            // outputMainFormToolStripMenuItem
            // 
            this.outputMainFormToolStripMenuItem.Checked = true;
            this.outputMainFormToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outputMainFormToolStripMenuItem.Name = "outputMainFormToolStripMenuItem";
            this.outputMainFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outputMainFormToolStripMenuItem.Text = "入力テキストに上書き";
            this.outputMainFormToolStripMenuItem.Click += new System.EventHandler(this.outputMainFormToolStripMenuItem_Click);
            // 
            // outputResultFormToolStripMenuItem
            // 
            this.outputResultFormToolStripMenuItem.Name = "outputResultFormToolStripMenuItem";
            this.outputResultFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outputResultFormToolStripMenuItem.Text = "別ウィンドウに出力";
            this.outputResultFormToolStripMenuItem.Click += new System.EventHandler(this.outputResultFormToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTrueToolStripMenuItem,
            this.copyFalseToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.copyToolStripMenuItem.Text = "クリップボードにコピー(&C)";
            // 
            // copyTrueToolStripMenuItem
            // 
            this.copyTrueToolStripMenuItem.Checked = true;
            this.copyTrueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyTrueToolStripMenuItem.Name = "copyTrueToolStripMenuItem";
            this.copyTrueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyTrueToolStripMenuItem.Text = "する";
            this.copyTrueToolStripMenuItem.Click += new System.EventHandler(this.copyTrueToolStripMenuItem_Click);
            // 
            // copyFalseToolStripMenuItem
            // 
            this.copyFalseToolStripMenuItem.Name = "copyFalseToolStripMenuItem";
            this.copyFalseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyFalseToolStripMenuItem.Text = "しない";
            this.copyFalseToolStripMenuItem.Click += new System.EventHandler(this.copyFalseToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.Controls.Add(this.IncrementButton);
            this.Controls.Add(this.incrementTextBox);
            this.Controls.Add(this.frontTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(240, 140);
            this.Name = "mainForm";
            this.Text = "Incrementer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incrementTextBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frontTextBox;
        private System.Windows.Forms.NumericUpDown incrementTextBox;
        private System.Windows.Forms.Button IncrementButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputResultFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTrueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFalseToolStripMenuItem;
    }
}

