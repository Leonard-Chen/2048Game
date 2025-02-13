namespace CSharp_Projects
{
	partial class StartMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
			splitContainer1 = new SplitContainer();
			pictureBox1 = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			StartGameButton = new Button();
			SettingsButton = new Button();
			ExitButton = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(pictureBox1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
			splitContainer1.Size = new Size(332, 303);
			splitContainer1.SplitterDistance = 73;
			splitContainer1.TabIndex = 0;
			splitContainer1.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(332, 73);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(StartGameButton, 0, 0);
			tableLayoutPanel1.Controls.Add(SettingsButton, 0, 1);
			tableLayoutPanel1.Controls.Add(ExitButton, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.Size = new Size(332, 226);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// StartGameButton
			// 
			StartGameButton.Anchor = AnchorStyles.None;
			StartGameButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			StartGameButton.Location = new Point(66, 12);
			StartGameButton.Name = "StartGameButton";
			StartGameButton.Size = new Size(200, 50);
			StartGameButton.TabIndex = 0;
			StartGameButton.Text = "开始游戏";
			StartGameButton.UseVisualStyleBackColor = true;
			StartGameButton.Click += StartGameButton_Click;
			// 
			// SettingsButton
			// 
			SettingsButton.Anchor = AnchorStyles.None;
			SettingsButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			SettingsButton.Location = new Point(66, 87);
			SettingsButton.Name = "SettingsButton";
			SettingsButton.Size = new Size(200, 50);
			SettingsButton.TabIndex = 1;
			SettingsButton.Text = "设置";
			SettingsButton.UseVisualStyleBackColor = true;
			SettingsButton.Click += SettingsButton_Click;
			// 
			// ExitButton
			// 
			ExitButton.Anchor = AnchorStyles.None;
			ExitButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			ExitButton.Location = new Point(66, 163);
			ExitButton.Name = "ExitButton";
			ExitButton.Size = new Size(200, 50);
			ExitButton.TabIndex = 2;
			ExitButton.Text = "退出";
			ExitButton.UseVisualStyleBackColor = true;
			ExitButton.Click += ExitButton_Click;
			// 
			// StartMenu
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(332, 303);
			Controls.Add(splitContainer1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "StartMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "2048小游戏";
			FormClosed += StartMenu_FormClosed;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private PictureBox pictureBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private Button StartGameButton;
		private Button SettingsButton;
		private Button ExitButton;
	}
}