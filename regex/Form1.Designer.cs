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
			this.SuspendLayout();
			// 
			// textArea
			// 
			this.textArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textArea.Location = new System.Drawing.Point(12, 44);
			this.textArea.Name = "textArea";
			this.textArea.Size = new System.Drawing.Size(791, 211);
			this.textArea.TabIndex = 0;
			this.textArea.Text = "";
			this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
			// 
			// regexArea
			// 
			this.regexArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.regexArea.Location = new System.Drawing.Point(12, 293);
			this.regexArea.Name = "regexArea";
			this.regexArea.Size = new System.Drawing.Size(791, 147);
			this.regexArea.TabIndex = 1;
			this.regexArea.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter text to search below:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 277);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Enter your Regular Expression below:";
			// 
			// runButton
			// 
			this.runButton.Location = new System.Drawing.Point(655, 446);
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
			this.matchesLabel.Location = new System.Drawing.Point(665, 277);
			this.matchesLabel.Name = "matchesLabel";
			this.matchesLabel.Size = new System.Drawing.Size(81, 13);
			this.matchesLabel.TabIndex = 5;
			this.matchesLabel.Text = "Matches found:";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 508);
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
	}
}

