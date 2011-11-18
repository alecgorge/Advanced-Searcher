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
            this.startBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.currentDir = new System.Windows.Forms.Label();
            this.caseSensitive = new System.Windows.Forms.CheckBox();
            this.searchIn = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.DataGridView();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
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
            this.dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dir.Location = new System.Drawing.Point(325, 10);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(307, 20);
            this.dir.TabIndex = 2;
            this.dir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.results_KeyUp);
            // 
            // browse
            // 
            this.browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.searchWithin.Size = new System.Drawing.Size(113, 17);
            this.searchWithin.TabIndex = 7;
            this.searchWithin.Text = "Search these files:";
            this.searchWithin.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(591, 37);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(122, 42);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "Start Search!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Currently Searching:";
            // 
            // currentDir
            // 
            this.currentDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDir.AutoSize = true;
            this.currentDir.Location = new System.Drawing.Point(121, 94);
            this.currentDir.Name = "currentDir";
            this.currentDir.Size = new System.Drawing.Size(0, 13);
            this.currentDir.TabIndex = 17;
            // 
            // caseSensitive
            // 
            this.caseSensitive.AutoSize = true;
            this.caseSensitive.Location = new System.Drawing.Point(189, 37);
            this.caseSensitive.Name = "caseSensitive";
            this.caseSensitive.Size = new System.Drawing.Size(96, 17);
            this.caseSensitive.TabIndex = 6;
            this.caseSensitive.Text = "Case Sensitive";
            this.caseSensitive.UseVisualStyleBackColor = true;
            // 
            // searchIn
            // 
            this.searchIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.searchIn.Location = new System.Drawing.Point(187, 59);
            this.searchIn.Name = "searchIn";
            this.searchIn.Size = new System.Drawing.Size(398, 20);
            this.searchIn.TabIndex = 8;
            this.searchIn.Text = "*.txt;*.c;*.h;*.php;*.html;*.py;*.cpp";
            // 
            // results
            // 
            this.results.AllowUserToAddRows = false;
            this.results.AllowUserToDeleteRows = false;
            this.results.AllowUserToResizeRows = false;
            this.results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.path,
            this.bytes,
            this.size,
            this.lastModified});
            this.results.Location = new System.Drawing.Point(16, 110);
            this.results.MultiSelect = false;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.RowHeadersVisible = false;
            this.results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.results.Size = new System.Drawing.Size(697, 248);
            this.results.TabIndex = 11;
            this.results.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.results_CellContentDoubleClick);
            // 
            // path
            // 
            this.path.HeaderText = "Location";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Width = 73;
            // 
            // bytes
            // 
            this.bytes.HeaderText = "Size (bytes)";
            this.bytes.Name = "bytes";
            this.bytes.ReadOnly = true;
            this.bytes.Width = 86;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 52;
            // 
            // lastModified
            // 
            this.lastModified.HeaderText = "Last Modified";
            this.lastModified.Name = "lastModified";
            this.lastModified.ReadOnly = true;
            this.lastModified.Width = 95;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 370);
            this.Controls.Add(this.results);
            this.Controls.Add(this.searchIn);
            this.Controls.Add(this.caseSensitive);
            this.Controls.Add(this.currentDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.searchWithin);
            this.Controls.Add(this.doRegex);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Advanced Searching Tool";
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
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
		private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label currentDir;
        private System.Windows.Forms.CheckBox caseSensitive;
        private System.Windows.Forms.TextBox searchIn;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn bytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModified;
	}
}

