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
			continueButton = new Button();
			newGameButton = new Button();
			exitButton = new Button();
			settingsButton = new Button();
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
			splitContainer1.Size = new Size(332, 353);
			splitContainer1.SplitterDistance = 85;
			splitContainer1.TabIndex = 0;
			splitContainer1.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(332, 85);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(continueButton, 0, 1);
			tableLayoutPanel1.Controls.Add(newGameButton, 0, 0);
			tableLayoutPanel1.Controls.Add(exitButton, 0, 3);
			tableLayoutPanel1.Controls.Add(settingsButton, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.Size = new Size(332, 264);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// continueButton
			// 
			continueButton.Anchor = AnchorStyles.None;
			continueButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			continueButton.Location = new Point(66, 74);
			continueButton.Name = "continueButton";
			continueButton.Size = new Size(200, 50);
			continueButton.TabIndex = 3;
			continueButton.Text = "继续游戏";
			continueButton.UseVisualStyleBackColor = true;
			continueButton.Click += ContinueButton_Click;
			// 
			// newGameButton
			// 
			newGameButton.Anchor = AnchorStyles.None;
			newGameButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			newGameButton.Location = new Point(66, 8);
			newGameButton.Name = "newGameButton";
			newGameButton.Size = new Size(200, 50);
			newGameButton.TabIndex = 0;
			newGameButton.Text = "开始游戏";
			newGameButton.UseVisualStyleBackColor = true;
			newGameButton.Click += NewGameButton_Click;
			// 
			// exitButton
			// 
			exitButton.Anchor = AnchorStyles.None;
			exitButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			exitButton.Location = new Point(66, 206);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(200, 50);
			exitButton.TabIndex = 2;
			exitButton.Text = "退出";
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += ExitButton_Click;
			// 
			// settingsButton
			// 
			settingsButton.Anchor = AnchorStyles.None;
			settingsButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
			settingsButton.Location = new Point(66, 140);
			settingsButton.Name = "settingsButton";
			settingsButton.Size = new Size(200, 50);
			settingsButton.TabIndex = 1;
			settingsButton.Text = "设置";
			settingsButton.UseVisualStyleBackColor = true;
			settingsButton.Click += SettingsButton_Click;
			// 
			// StartMenu
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(332, 353);
			Controls.Add(splitContainer1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "StartMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "2048小游戏";
			Activated += StartMenu_Activated;
			FormClosed += StartMenu_FormClosed;
			Load += StartMenu_Load;
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
		private Button newGameButton;
		private Button settingsButton;
		private Button exitButton;
		private Button continueButton;
	}
}