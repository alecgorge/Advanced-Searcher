using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Permissions;

namespace advancedSearching {
	class SearchBot {
		public string needle;
		public string haystack;
		public bool regex;
		public bool caseSensitive;
		public bool searchHaystack;
		public Regex fileSearch;
		ListBox output;
		Label current;

		public SearchBot(string needle, string haystack, bool caseSensitive, bool regex, bool searchHaystack, List<string> fileSearch, ListBox results, Label current) {
			this.needle = needle;
			this.haystack = haystack;
			this.regex = regex;
			this.searchHaystack = searchHaystack;
			this.output = results;
			this.caseSensitive = caseSensitive;
			string tmp = "";
			foreach (string f in fileSearch) {
				tmp += f.Replace(".", "[.]").Replace("*", ".*").Replace("?", ".") + "|";
			}
			this.fileSearch = new Regex(tmp.TrimEnd('|'));

			output.Items.Clear();
			this.current = current;
		}

		private bool FitsMask(string sFileName, string sFileMask) {
			Regex mask = new Regex(sFileMask.Replace(".", "[.]").Replace("*", ".*").Replace("?", "."));
			return mask.IsMatch(sFileName);
		}

		delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
		private void SetControlPropertyValue(Control oControl, string propName, object propValue) {
			if (oControl.InvokeRequired) {
				SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
				oControl.Invoke(d, new object[] { oControl, propName, propValue });
			}
			else {
				Type t = oControl.GetType();
				PropertyInfo[] props = t.GetProperties();
				foreach (PropertyInfo p in props) {
					if (p.Name.ToUpper() == propName.ToUpper()) {
						p.SetValue(oControl, propValue, null);
					}
				}
			}
		}


		public void go() {
			bool continueVar = false;
			if (Directory.Exists(haystack)) {
				Directory.EnumerateFiles(haystack, "*", SearchOption.AllDirectories);
				try {
					IEnumerable<string> files = Directory.EnumerateFiles(haystack, "*", SearchOption.AllDirectories);
					foreach (string file in files) {
						try {
							SetControlPropertyValue(current, "Text", Directory.GetParent(file).FullName.Replace(haystack, "").TrimStart('\\'));
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
								//MessageBox.Show("adding " + file + " due to 1");
								Form1.addItem(file.Replace(haystack, "").TrimStart('\\'));
							}
							else if (searchHaystack && fileSearch.Match(file2).Success) {
								StreamReader sr = File.OpenText(file);
								string st = sr.ReadToEnd();
								if (!caseSensitive) {
									st = st.ToLower();
								}

								if (regex && FitsMask(st, needle)) {
									Form1.addItem(file.Replace(haystack, "").TrimStart('\\'));
								}
								else if (st.IndexOf(needle) > -1) {
									Form1.addItem(file.Replace(haystack, "").TrimStart('\\'));
								}
								else {
									continueVar = true;
								}
								// MessageBox.Show("adding " + file + " due to 2");
								// output.Items.Add(file);
								// todo add search within file
							}
							if (continueVar && regex) {
								//MessageBox.Show("file2: " + file2 + " needle: " + needle.Replace(".", "[.]").Replace("*", ".*").Replace("?", "."));
								if (FitsMask(file2, needle)) {
									//MessageBox.Show("adding " + file + " due to 3");
									Form1.addItem(file.Replace(haystack, "").TrimStart('\\'));
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
				SetControlPropertyValue(current, "Text", "done.");
			}
			else {
				MessageBox.Show(haystack + " doesn't exist!");
			}
		}
	}
}
