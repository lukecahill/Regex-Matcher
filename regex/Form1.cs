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
			textArea.SelectAll();
			textArea.SelectionColor = Color.Black;
			total = 0;

			if (!validateTextFields()) return;

			var regex = new Regex(regexArea.Text);
			var results = regex.Matches(textArea.Text);

			if(results.Count > 0) {
				showResults(results);
			} else {
				MessageBox.Show("Could not find any results for that search");
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

		public void showResults(MatchCollection match) {

			foreach(Match item in match) {
				textArea.SelectionStart = item.Index;
				textArea.SelectionLength = item.Value.Length;
				textArea.SelectionColor = Color.Red;
				total++;
			}

			matchesLabel.Text = $"Matches found: {total}";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			if (comboBox1.SelectedIndex == 0) {
				regexArea.Text = "\\d";
			} else if(comboBox1.SelectedIndex == 1) {
				regexArea.Text = "\\w{4}";
			} else if (comboBox1.SelectedIndex == 2) {
				regexArea.Text = "[A-Z]";
			} else if (comboBox1.SelectedIndex == 3) {
				// below regex from http://stackoverflow.com/a/5717338.
				regexArea.Text = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";
			} else if(comboBox1.SelectedIndex == 4) {
				regexArea.Text = @"(?:[0-9]{1,3}\.){3}[0-9]{1,3}";
			}
		}
	}
}
