using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace regex {
	public partial class mainForm : Form {

		List<SearchResult> found = new List<SearchResult>();
		int total = 0;
		public mainForm() {
			InitializeComponent();
			matchesLabel.Text = $"Matches found: {total}";
		}

		private void runButton_Click(object sender, EventArgs e) {
			if (!validateTextFields()) return;

			var regex = new Regex(regexArea.Text);
			var results = regex.Matches(textArea.Text);

			if(results.Count > 0) {
				isResults(results);
			}
		}

		public bool validateTextFields() {
			if (textArea.Equals("") || String.IsNullOrWhiteSpace(textArea.Text)) {
				MessageBox.Show("Enter some text to search.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			if (regexArea.Equals("") || String.IsNullOrWhiteSpace(regexArea.Text)) {
				MessageBox.Show("You must enter a Regular Expression to search.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			return true;
		}

		public void isResults(MatchCollection match) {

			foreach(Match item in match) {
				textArea.SelectionStart = item.Index;
				textArea.SelectionLength = item.Value.Length;
				textArea.SelectionColor = Color.Red;
				total++;
			}

			matchesLabel.Text = $"Matches found: {total}";
		}

		private void textArea_TextChanged(object sender, EventArgs e) {
			textArea.ForeColor = Color.Black;
		}
	}
}
