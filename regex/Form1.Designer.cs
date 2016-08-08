namespace regex {
	partial class mainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.textArea = new System.Windows.Forms.RichTextBox();
			this.regexArea = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.runButton = new System.Windows.Forms.Button();
			this.matchesLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textArea
			// 
			this.textArea.DetectUrls = false;
			this.textArea.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textArea.Location = new System.Drawing.Point(13, 72);
			this.textArea.Name = "textArea";
			this.textArea.Size = new System.Drawing.Size(537, 197);
			this.textArea.TabIndex = 0;
			this.textArea.Text = "";
			// 
			// regexArea
			// 
			this.regexArea.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.regexArea.Location = new System.Drawing.Point(13, 303);
			this.regexArea.Name = "regexArea";
			this.regexArea.Size = new System.Drawing.Size(537, 68);
			this.regexArea.TabIndex = 1;
			this.regexArea.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter text to search below:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 287);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Enter your Regular Expression below:";
			// 
			// runButton
			// 
			this.runButton.Location = new System.Drawing.Point(402, 377);
			this.runButton.Name = "runButton";
			this.runButton.Size = new System.Drawing.Size(148, 50);
			this.runButton.TabIndex = 4;
			this.runButton.Text = "Run";
			this.runButton.UseVisualStyleBackColor = true;
			this.runButton.Click += new System.EventHandler(this.runButton_Click);
			// 
			// matchesLabel
			// 
			this.matchesLabel.AutoSize = true;
			this.matchesLabel.Location = new System.Drawing.Point(431, 287);
			this.matchesLabel.Name = "matchesLabel";
			this.matchesLabel.Size = new System.Drawing.Size(81, 13);
			this.matchesLabel.TabIndex = 5;
			this.matchesLabel.Text = "Matches found:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(247, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "Regex Matcher";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "All numbers",
            "All 4 letter words",
            "All words in capitals",
            "Website URL",
            "IP Address"});
			this.comboBox1.Location = new System.Drawing.Point(16, 393);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(235, 21);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 377);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(237, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Choose a Regular Expression from the dropdown";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 434);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.matchesLabel);
			this.Controls.Add(this.runButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.regexArea);
			this.Controls.Add(this.textArea);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "mainForm";
			this.Text = "Regex Matcher";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox textArea;
		private System.Windows.Forms.RichTextBox regexArea;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button runButton;
		private System.Windows.Forms.Label matchesLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
	}
}

