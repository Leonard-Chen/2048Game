namespace CSharp_Projects
{
	partial class Settings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			tableLayoutPanel1 = new TableLayoutPanel();
			splitContainer1 = new SplitContainer();
			label1 = new Label();
			rowSetting = new NumericUpDown();
			splitContainer2 = new SplitContainer();
			label2 = new Label();
			columnSetting = new NumericUpDown();
			splitContainer3 = new SplitContainer();
			splitContainer4 = new SplitContainer();
			label3 = new Label();
			bestScoreLabel = new Label();
			clearBestScoreButton = new Button();
			tableLayoutPanel2 = new TableLayoutPanel();
			cancelButton = new Button();
			OKButton = new Button();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)rowSetting).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)columnSetting).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
			splitContainer3.Panel1.SuspendLayout();
			splitContainer3.Panel2.SuspendLayout();
			splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
			splitContainer4.Panel1.SuspendLayout();
			splitContainer4.Panel2.SuspendLayout();
			splitContainer4.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(splitContainer1, 0, 0);
			tableLayoutPanel1.Controls.Add(splitContainer2, 0, 1);
			tableLayoutPanel1.Controls.Add(splitContainer3, 0, 2);
			tableLayoutPanel1.Location = new Point(12, 12);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
			tableLayoutPanel1.Size = new Size(258, 329);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// splitContainer1
			// 
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new Point(3, 3);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(label1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(rowSetting);
			splitContainer1.Size = new Size(252, 80);
			splitContainer1.SplitterDistance = 100;
			splitContainer1.TabIndex = 3;
			splitContainer1.TabStop = false;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			label1.Location = new Point(0, 0);
			label1.Margin = new Padding(50, 0, 50, 0);
			label1.Name = "label1";
			label1.Size = new Size(100, 80);
			label1.TabIndex = 1;
			label1.Text = "行数：";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// rowSetting
			// 
			rowSetting.Anchor = AnchorStyles.None;
			rowSetting.Location = new Point(1, 30);
			rowSetting.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			rowSetting.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
			rowSetting.Name = "rowSetting";
			rowSetting.Size = new Size(100, 27);
			rowSetting.TabIndex = 0;
			rowSetting.Value = new decimal(new int[] { 4, 0, 0, 0 });
			rowSetting.ValueChanged += RowSetting_ValueChanged;
			// 
			// splitContainer2
			// 
			splitContainer2.IsSplitterFixed = true;
			splitContainer2.Location = new Point(3, 89);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(label2);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(columnSetting);
			splitContainer2.Size = new Size(252, 80);
			splitContainer2.SplitterDistance = 100;
			splitContainer2.TabIndex = 4;
			splitContainer2.TabStop = false;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Fill;
			label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(100, 80);
			label2.TabIndex = 2;
			label2.Text = "列数：";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// columnSetting
			// 
			columnSetting.Anchor = AnchorStyles.None;
			columnSetting.Location = new Point(1, 30);
			columnSetting.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			columnSetting.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
			columnSetting.Name = "columnSetting";
			columnSetting.Size = new Size(100, 27);
			columnSetting.TabIndex = 1;
			columnSetting.Value = new decimal(new int[] { 4, 0, 0, 0 });
			columnSetting.ValueChanged += ColumnSetting_ValueChanged;
			// 
			// splitContainer3
			// 
			splitContainer3.Dock = DockStyle.Fill;
			splitContainer3.IsSplitterFixed = true;
			splitContainer3.Location = new Point(3, 175);
			splitContainer3.Name = "splitContainer3";
			splitContainer3.Orientation = Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			splitContainer3.Panel1.Controls.Add(splitContainer4);
			// 
			// splitContainer3.Panel2
			// 
			splitContainer3.Panel2.Controls.Add(clearBestScoreButton);
			splitContainer3.Size = new Size(252, 80);
			splitContainer3.SplitterDistance = 40;
			splitContainer3.TabIndex = 5;
			splitContainer3.TabStop = false;
			// 
			// splitContainer4
			// 
			splitContainer4.Dock = DockStyle.Fill;
			splitContainer4.IsSplitterFixed = true;
			splitContainer4.Location = new Point(0, 0);
			splitContainer4.Name = "splitContainer4";
			// 
			// splitContainer4.Panel1
			// 
			splitContainer4.Panel1.Controls.Add(label3);
			// 
			// splitContainer4.Panel2
			// 
			splitContainer4.Panel2.Controls.Add(bestScoreLabel);
			splitContainer4.Size = new Size(252, 40);
			splitContainer4.SplitterDistance = 126;
			splitContainer4.TabIndex = 0;
			splitContainer4.TabStop = false;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Fill;
			label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			label3.Location = new Point(0, 0);
			label3.Name = "label3";
			label3.Size = new Size(126, 40);
			label3.TabIndex = 3;
			label3.Text = "最高分：";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// bestScoreLabel
			// 
			bestScoreLabel.Dock = DockStyle.Fill;
			bestScoreLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
			bestScoreLabel.Location = new Point(0, 0);
			bestScoreLabel.Name = "bestScoreLabel";
			bestScoreLabel.Size = new Size(122, 40);
			bestScoreLabel.TabIndex = 4;
			bestScoreLabel.Text = "0";
			bestScoreLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// clearBestScoreButton
			// 
			clearBestScoreButton.Anchor = AnchorStyles.None;
			clearBestScoreButton.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
			clearBestScoreButton.Location = new Point(76, 3);
			clearBestScoreButton.Name = "clearBestScoreButton";
			clearBestScoreButton.Size = new Size(100, 30);
			clearBestScoreButton.TabIndex = 2;
			clearBestScoreButton.Text = "清除";
			clearBestScoreButton.UseVisualStyleBackColor = true;
			clearBestScoreButton.Click += ClearBestScoreButton_Click;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(cancelButton, 1, 0);
			tableLayoutPanel2.Controls.Add(OKButton, 0, 0);
			tableLayoutPanel2.Location = new Point(12, 270);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(258, 71);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// cancelButton
			// 
			cancelButton.Anchor = AnchorStyles.None;
			cancelButton.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
			cancelButton.Location = new Point(143, 20);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(100, 30);
			cancelButton.TabIndex = 1;
			cancelButton.Text = "取消";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += CancelButton_Click;
			// 
			// OKButton
			// 
			OKButton.Anchor = AnchorStyles.None;
			OKButton.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
			OKButton.Location = new Point(14, 20);
			OKButton.Name = "OKButton";
			OKButton.Size = new Size(100, 30);
			OKButton.TabIndex = 0;
			OKButton.Text = "确定";
			OKButton.UseVisualStyleBackColor = true;
			OKButton.Click += OKButton_Click;
			// 
			// Settings
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(282, 353);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Settings";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "设置";
			FormClosed += Settings_FormClosed;
			Load += Settings_Load;
			tableLayoutPanel1.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)rowSetting).EndInit();
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)columnSetting).EndInit();
			splitContainer3.Panel1.ResumeLayout(false);
			splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
			splitContainer3.ResumeLayout(false);
			splitContainer4.Panel1.ResumeLayout(false);
			splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
			splitContainer4.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Button cancelButton;
		private Button OKButton;
		private SplitContainer splitContainer1;
		private Label label1;
		private NumericUpDown rowSetting;
		private SplitContainer splitContainer2;
		private Label label2;
		private NumericUpDown columnSetting;
		private SplitContainer splitContainer3;
		private SplitContainer splitContainer4;
		private Label label3;
		private Label bestScoreLabel;
		private Button clearBestScoreButton;
	}
}