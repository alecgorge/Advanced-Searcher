using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Permissions;
using System.Diagnostics;

namespace advancedSearching {
	class SearchBot {
		public string needle;
		public string haystack;
		public bool regex;
		public bool caseSensitive;
		public bool searchHaystack;
		public Regex fileSearch;
		DataGridView output;
		Label current;
        Form1 inst;

        public SearchBot(Form1 inst, string needle, string haystack, bool caseSensitive, bool regex, bool searchHaystack, IEnumerable<string> fileSearch, DataGridView results, Label current) {
			this.needle = needle;
			this.haystack = haystack;
			this.regex = regex;
			this.searchHaystack = searchHaystack;
			this.output = results;
			this.caseSensitive = caseSensitive;
            this.inst = inst;
			string tmp = "";
			foreach (string f in fileSearch) {
				tmp += f.Replace(".", "[.]").Replace("*", ".*").Replace("?", ".") + "|";
			}
			this.fileSearch = new Regex(tmp.TrimEnd('|'));

            output.Rows.Clear();
			this.current = current;
		}

		private bool FitsMask(string sFileName, string sFileMask) {
			Regex mask = new Regex(sFileMask.Replace(".", "[.]").Replace("*", ".*").Replace("?", "."));
			return mask.IsMatch(sFileName);
		}


		public void go() {
			bool continueVar = false;
			if (Directory.Exists(haystack)) {
				Directory.EnumerateFiles(haystack, "*", SearchOption.AllDirectories);
				try {
					IEnumerable<string> files = Directory.EnumerateFiles(haystack, "*", SearchOption.AllDirectories);
					foreach (string file in files) {
						try {
                            current.InvokeEx(label => label.Text = Directory.GetParent(file).FullName.Replace(haystack, "").TrimStart('\\'));
							continueVar = false;

							string file2;
							if (!caseSensitive) {
								file2 = file.ToLower();
								needle = needle.ToLower();
							}
							else {
								file2 = file;
							}

							if (file2.Contains(needle)) {
                                addItem(file);
                            }
							else if (searchHaystack && fileSearch.Match(file2).Success) {
								StreamReader sr = File.OpenText(file);
								string st = sr.ReadToEnd();
								if (!caseSensitive) {
									st = st.ToLower();
								}

                                if (regex && FitsMask(st, needle) || st.IndexOf(needle) > -1) {
                                    addItem(file);
                                }
								else {
									continueVar = true;
								}
							}
							if (continueVar && regex) {
								if (FitsMask(file2, needle)) {
                                    addItem(file);
								}
							}
						}
						catch (Exception e) {
							MessageBox.Show(e.StackTrace.ToString());
						}
					}
				}
				catch (Exception e) {
					MessageBox.Show(e.StackTrace.ToString());
				}
                current.InvokeEx(label => label.Text = "done.");
            }
			else {
				MessageBox.Show(haystack + " doesn't exist!");
			}
		}
        public void addItem(string o) {
            FileInfo f = new FileInfo(o);
            inst.addItem(o.Replace(haystack, "").TrimStart('\\'), f.Length, f.LastWriteTime);
        }
	}
}
