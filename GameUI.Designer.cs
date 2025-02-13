namespace CSharp_Projects
{
	partial class GameUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUI));
			splitContainer1 = new SplitContainer();
			tableLayoutPanel1 = new TableLayoutPanel();
			bestScoreLabel = new Label();
			label3 = new Label();
			scoreLabel = new Label();
			label1 = new Label();
			gridPanel = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.FixedPanel = FixedPanel.Panel1;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
			splitContainer1.Panel1MinSize = 50;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(gridPanel);
			splitContainer1.Panel2MinSize = 332;
			splitContainer1.Size = new Size(382, 436);
			splitContainer1.SplitterDistance = 64;
			splitContainer1.TabIndex = 0;
			splitContainer1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.Controls.Add(bestScoreLabel, 3, 0);
			tableLayoutPanel1.Controls.Add(label3, 2, 0);
			tableLayoutPanel1.Controls.Add(scoreLabel, 1, 0);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(382, 64);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// bestScoreLabel
			// 
			bestScoreLabel.AutoSize = true;
			bestScoreLabel.Dock = DockStyle.Fill;
			bestScoreLabel.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
			bestScoreLabel.ImageAlign = ContentAlignment.MiddleRight;
			bestScoreLabel.Location = new Point(288, 0);
			bestScoreLabel.Name = "bestScoreLabel";
			bestScoreLabel.Size = new Size(91, 64);
			bestScoreLabel.TabIndex = 3;
			bestScoreLabel.Text = "0";
			bestScoreLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
			label3.ImageAlign = ContentAlignment.MiddleRight;
			label3.Location = new Point(193, 0);
			label3.Name = "label3";
			label3.Size = new Size(89, 64);
			label3.TabIndex = 2;
			label3.Text = "Best:";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// scoreLabel
			// 
			scoreLabel.AutoSize = true;
			scoreLabel.Dock = DockStyle.Fill;
			scoreLabel.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
			scoreLabel.ImageAlign = ContentAlignment.MiddleRight;
			scoreLabel.Location = new Point(98, 0);
			scoreLabel.Name = "scoreLabel";
			scoreLabel.Size = new Size(89, 64);
			scoreLabel.TabIndex = 1;
			scoreLabel.Text = "0";
			scoreLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
			label1.ImageAlign = ContentAlignment.MiddleRight;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(89, 64);
			label1.TabIndex = 0;
			label1.Text = "Score:";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// gridPanel
			// 
			gridPanel.Anchor = AnchorStyles.None;
			gridPanel.BackColor = Color.FromArgb(205, 193, 180);
			gridPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			gridPanel.ColumnCount = 4;
			gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			gridPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
			gridPanel.Location = new Point(3, 3);
			gridPanel.Name = "gridPanel";
			gridPanel.RowCount = 4;
			gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			gridPanel.Size = new Size(300, 300);
			gridPanel.TabIndex = 0;
			// 
			// GameUI
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(382, 436);
			Controls.Add(splitContainer1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			MaximizeBox = false;
			MinimumSize = new Size(400, 483);
			Name = "GameUI";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "2048小游戏";
			FormClosed += GameUI_FormClosed;
			Load += GameUI_Load;
			SizeChanged += GameUI_SizeChanged;
			KeyDown += GameUI_KeyDown;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label bestScoreLabel;
		private Label label3;
		private Label scoreLabel;
		private Label label1;
		private TableLayoutPanel gridPanel;
	}
}