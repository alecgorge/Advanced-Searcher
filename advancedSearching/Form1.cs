using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

public delegate void AddItemDeleg(object obj);

namespace advancedSearching {
	public partial class Form1 : Form {
		public static Form1 inst;
		public Form1() {
			InitializeComponent();
			inst = this;
		}

		private void startBtn_Click(object sender, EventArgs e) {
			didClick();
		}

		private void didClick() {
			List<string> tmp = new List<string>();
			foreach (object obj in searchIn.Items) {
				tmp.Add((string)obj);
			}
			SearchBot s = new SearchBot(search.Text, dir.Text, caseSensitive.Checked, doRegex.Checked, searchWithin.Checked, tmp, results, currentDir);

			Thread t = new Thread(s.go);
			t.Start();
		}

		private void browse_Click(object sender, EventArgs e) {
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				this.dir.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private static void AddItem(object obj) {
			inst.results.Items.Add(obj);
		}

		public static void addItem (string item) {
			//inst.results.Items.Add(item);
			inst.results.Invoke(new AddItemDeleg(AddItem),
				new object[] { item });
		}

		private void openCurrent() {
			if (results.SelectedIndex == -1) return;
			string argument = @"/select, " + "\"" + dir.Text.TrimEnd(new char[] {'\\', '/'}) + @"\" + (string)results.Items[results.SelectedIndex] + "\"";

			System.Diagnostics.Process.Start("explorer.exe", argument);
		}

		private void button1_Click(object sender, EventArgs e) {
			openCurrent();
		}

		private void results_DoubleClick(object sender, EventArgs e) {
			openCurrent();
		}

		private void addBtn_Click(object sender, EventArgs e) {
			string res = InputBox.Show("Add a new regular expression to match files against.", "Add new").Text;
			if (res.Length > 0) {
				searchIn.Items.Add(res);
			}
		}

		private void editBtn_Click(object sender, EventArgs e) {
			if (searchIn.SelectedIndex == -1) return;
			string res = InputBox.Show("Edit a regular expression to match files against.", "Edit", searchIn.Items[searchIn.SelectedIndex].ToString()).Text;
			if (res.Length > 0) {
				searchIn.Items[searchIn.SelectedIndex] = res;
			}
		}

		private void removeBtn_Click(object sender, EventArgs e) {
			if (searchIn.SelectedIndex == -1) return;
			searchIn.Items.RemoveAt(searchIn.SelectedIndex);
		}

		private void results_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				didClick();
			}
		}

	}
}
