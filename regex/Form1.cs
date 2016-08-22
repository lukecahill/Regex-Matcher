using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

			if (!ValidateTextFields()) return;

			var regex = new Regex(regexArea.Text);
			var results = regex.Matches(textArea.Text);

			matchesLabel.Text = $"Matches found: {results.Count}";

			if (results.Count > 0) {
				Task.Factory.StartNew(() =>
					ShowResults(results)
				);
			} else {
				MessageBox.Show("Could not find any results for that search");
			}
		}

		public bool ValidateTextFields() {
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

		public void ShowResults(MatchCollection match) {

			foreach(Match item in match) {
				Invoke(new Action(() => textArea.SelectionStart = item.Index));
				Invoke(new Action(() => textArea.SelectionLength = item.Value.Length));
				Invoke(new Action(() => textArea.SelectionColor = Color.Red));
				total++;
			}			
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			if (comboBox1.SelectedIndex == 0) {
				regexArea.Text = "\\d";
			} else if (comboBox1.SelectedIndex == 1) {
				regexArea.Text = "[a-zA-Z]{4}";
			} else if (comboBox1.SelectedIndex == 2) {
				regexArea.Text = "[A-Z]";
			} else if (comboBox1.SelectedIndex == 3) {
				// below regex from http://stackoverflow.com/a/5717338.
				regexArea.Text = @"http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?";
			} else if (comboBox1.SelectedIndex == 4) {
				regexArea.Text = @"(?:[0-9]{1,3}\.){3}[0-9]{1,3}";
			} else if (comboBox1.SelectedIndex == 5) {
				// below from http://stackoverflow.com/q/16167983
				regexArea.Text = @"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)";
			}
		}
	}
}
