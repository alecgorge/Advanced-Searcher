using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using SHOpenFolderAndSelectItems;
using Ookii.Dialogs;
using System.IO;

public delegate void AddItemDeleg(object obj);

namespace advancedSearching {
	public partial class Form1 : Form {
        public VistaFolderBrowserDialog folderBrowserDialog1 = new VistaFolderBrowserDialog();
        public string searchDir = "";

		public Form1() {
			InitializeComponent();
		}

		private void startBtn_Click(object sender, EventArgs e) {
			didClick();
		}

		private void didClick() {
            searchDir = dir.Text;
            SearchBot s = new SearchBot(this, search.Text, dir.Text, caseSensitive.Checked, doRegex.Checked, searchWithin.Checked, searchIn.Text.Trim().Trim(';').Split(';'), results, currentDir);

			Thread t = new Thread(s.go);
			t.Start();
		}

		private void browse_Click(object sender, EventArgs e) {
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				this.dir.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		public void addItem (string item, long size, DateTime lastModfied) {
            results.InvokeEx(r => r.Rows.Add(new object[] {item, size, humanBytes(size), humanTime(lastModfied)}));
		}

		private void openCurrent(int index) {
            ShowSelectedInExplorer.FileOrFolder(Path.Combine(new string[] {
                searchDir,
                results.Rows[index].Cells["path"].Value.ToString()
            }));
		}

		private void results_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				didClick();
			}
		}
        private string humanBytes(long bytes) {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB" };

            if (bytes < 1) {
                return "0 B";
            }

            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return num.ToString() + " " + suf[place];
        }
        private string humanTime(DateTime date) {
            return date.ToString("u");
        }

        private void results_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            openCurrent(e.RowIndex);
        }
	}
    public static class ISynchronizeInvokeExtensions {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke {
            if (@this.InvokeRequired) {
                @this.Invoke(action, new object[] { @this });
            }
            else {
                action(@this);
            }
        }
    }
}
