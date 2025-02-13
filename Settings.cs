using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Projects
{
	public partial class Settings : Form
	{
		public Action<int, int>? setValueHandler;
		public Action? clearBestScoreHandler;
		public int Row { get; set; }
		public int Column { get; set; }
		public int BestScore { get; set; }

		public Settings()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			if (setValueHandler is not null)
				setValueHandler(Row, Column);
			Dispose();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void ClearBestScoreButton_Click(object sender, EventArgs e)
		{
			BestScore = 0;
			bestScoreLabel.Text = $"{0}";

			if (clearBestScoreHandler is not null)
				clearBestScoreHandler();
		}

		private void RowSetting_ValueChanged(object sender, EventArgs e)
		{
			var setting = sender as NumericUpDown;

			if (setting is not null)
				Row = Convert.ToInt32(setting.Value);
		}

		private void ColumnSetting_ValueChanged(object sender, EventArgs e)
		{
			var setting = sender as NumericUpDown;

			if (setting is not null)
				Column = Convert.ToInt32(setting.Value);
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			rowSetting.Value = Row;
			columnSetting.Value = Column;
			bestScoreLabel.Text = $"{BestScore}";
		}

		private void Settings_FormClosed(object sender, FormClosedEventArgs e)
		{
			Dispose();
		}
	}
}
