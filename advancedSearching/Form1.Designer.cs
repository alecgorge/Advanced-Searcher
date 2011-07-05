namespace advancedSearching {
	partial class Form1 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.search = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dir = new System.Windows.Forms.TextBox();
			this.browse = new System.Windows.Forms.Button();
			this.doRegex = new System.Windows.Forms.CheckBox();
			this.searchWithin = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.searchIn = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addBtn = new System.Windows.Forms.Button();
			this.removeBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.startBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.results = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.currentDir = new System.Windows.Forms.Label();
			this.caseSensitive = new System.Windows.Forms.CheckBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Look for:";
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(68, 10);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(229, 20);
			this.search.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(304, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "in";
			// 
			// dir
			// 
			this.dir.Location = new System.Drawing.Point(325, 10);
			this.dir.Name = "dir";
			this.dir.Size = new System.Drawing.Size(307, 20);
			this.dir.TabIndex = 3;
			this.dir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.results_KeyUp);
			// 
			// browse
			// 
			this.browse.Location = new System.Drawing.Point(638, 8);
			this.browse.Name = "browse";
			this.browse.Size = new System.Drawing.Size(75, 23);
			this.browse.TabIndex = 4;
			this.browse.Text = "Browse";
			this.browse.UseVisualStyleBackColor = true;
			this.browse.Click += new System.EventHandler(this.browse_Click);
			// 
			// doRegex
			// 
			this.doRegex.AutoSize = true;
			this.doRegex.Location = new System.Drawing.Point(68, 37);
			this.doRegex.Name = "doRegex";
			this.doRegex.Size = new System.Drawing.Size(104, 17);
			this.doRegex.TabIndex = 5;
			this.doRegex.Text = "Regex enabled?";
			this.doRegex.UseVisualStyleBackColor = true;
			// 
			// searchWithin
			// 
			this.searchWithin.AutoSize = true;
			this.searchWithin.Location = new System.Drawing.Point(68, 61);
			this.searchWithin.Name = "searchWithin";
			this.searchWithin.Size = new System.Drawing.Size(126, 17);
			this.searchWithin.TabIndex = 6;
			this.searchWithin.Text = "Search file contents?";
			this.searchWithin.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Files to search in:";
			// 
			// searchIn
			// 
			this.searchIn.FormattingEnabled = true;
			this.searchIn.Items.AddRange(new object[] {
            "*.txt",
            "*.c",
            "*.h",
            "*.php",
            "*.html",
            "*.py",
            "*.cpp"});
			this.searchIn.Location = new System.Drawing.Point(164, 85);
			this.searchIn.Name = "searchIn";
			this.searchIn.Size = new System.Drawing.Size(133, 95);
			this.searchIn.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(65, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "(Regex Enabled)";
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(304, 85);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(67, 23);
			this.addBtn.TabIndex = 10;
			this.addBtn.Text = "Add  Item";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// removeBtn
			// 
			this.removeBtn.Location = new System.Drawing.Point(304, 141);
			this.removeBtn.Name = "removeBtn";
			this.removeBtn.Size = new System.Drawing.Size(108, 23);
			this.removeBtn.TabIndex = 11;
			this.removeBtn.Text = "Remove Selected";
			this.removeBtn.UseVisualStyleBackColor = true;
			this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(304, 112);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(81, 23);
			this.editBtn.TabIndex = 12;
			this.editBtn.Text = "Edit Selected";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// startBtn
			// 
			this.startBtn.Location = new System.Drawing.Point(588, 37);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(122, 41);
			this.startBtn.TabIndex = 13;
			this.startBtn.Text = "Start Search!";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Currently Searching:";
			// 
			// results
			// 
			this.results.FormattingEnabled = true;
			this.results.Location = new System.Drawing.Point(16, 218);
			this.results.Name = "results";
			this.results.Size = new System.Drawing.Size(694, 264);
			this.results.TabIndex = 15;
			this.results.DoubleClick += new System.EventHandler(this.results_DoubleClick);
			this.results.KeyUp += new System.Windows.Forms.KeyEventHandler(this.results_KeyUp);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(588, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Show File in Explorer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// currentDir
			// 
			this.currentDir.AutoSize = true;
			this.currentDir.Location = new System.Drawing.Point(116, 195);
			this.currentDir.Name = "currentDir";
			this.currentDir.Size = new System.Drawing.Size(0, 13);
			this.currentDir.TabIndex = 17;
			// 
			// caseSensitive
			// 
			this.caseSensitive.AutoSize = true;
			this.caseSensitive.Location = new System.Drawing.Point(200, 37);
			this.caseSensitive.Name = "caseSensitive";
			this.caseSensitive.Size = new System.Drawing.Size(96, 17);
			this.caseSensitive.TabIndex = 18;
			this.caseSensitive.Text = "Case Sensitive";
			this.caseSensitive.UseVisualStyleBackColor = true;
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 498);
			this.Controls.Add(this.caseSensitive);
			this.Controls.Add(this.currentDir);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.results);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.removeBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.searchIn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.searchWithin);
			this.Controls.Add(this.doRegex);
			this.Controls.Add(this.browse);
			this.Controls.Add(this.dir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.search);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(738, 536);
			this.MinimumSize = new System.Drawing.Size(738, 536);
			this.Name = "Form1";
			this.Text = "Advanced Searching Tool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox search;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox dir;
		private System.Windows.Forms.Button browse;
		private System.Windows.Forms.CheckBox doRegex;
		private System.Windows.Forms.CheckBox searchWithin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox searchIn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button removeBtn;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.ListBox results;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label currentDir;
		private System.Windows.Forms.CheckBox caseSensitive;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

