using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Cipher.HelpfulForms {
	using TrithemiusKey = TrithemiusCipher.Key.KeyType;

	public partial class HuckBrutforceTrithemius :Form {
		private TrithemiusKey keyType;
		private Thread[] th;
		private Brutforser huckTrith;

		private class Brutforser {
			public bool isRunning { get; set; }
			public delegate void UpdateLinMethod(int i, int j);
			public event UpdateLinMethod updateLinEvent;
			public delegate void FoundedLinMethod(int i, int j);
			public event FoundedLinMethod foundedLinEvent;

			public delegate void UpdateNonLinMethod(int i, int j, int t);
			public event UpdateNonLinMethod updateNonLinEvent;
			public delegate void FoundedNonLinMethod(int i, int j, int t);
			public event FoundedNonLinMethod foundedNonLinEvent;

			TrithemiusCipher trithemius;
			private string text1;
			private string text2;

			public Brutforser(string text1_, string text2_) {
				text1 = text1_; text2 = text2_;
				trithemius = new TrithemiusCipher();
			}

			public void runLin() {
				isRunning = true;
				string encrypted;
				object args = new TrithemiusCipher.LinKey();
				int length = text1.Length < 5 ? text1.Length : 5;
				((TrithemiusCipher.LinKey)args).keyType = TrithemiusKey.LinearAquestion;
				
				for(int i = 0; i < 9999; i++) {
					if(!isRunning)
						return;
					((TrithemiusCipher.LinKey)args).A = i;
					for(int j = 0; j < 9999; j++) {
						((TrithemiusCipher.LinKey)args).B = j;
						int k;
						encrypted = trithemius.Trithemius(text1, CaesarCipher.Operation.Encrypt, args);
						for(k = 0; k < length; k++) {
							if(encrypted[k] != text2[k])
								break;
						}
						if(k >= length) {
							foundedLinEvent(i, j);
							return;
						}
						if(j%511 == 0)
							updateLinEvent(-1, j);
					}
					updateLinEvent(i, -1);
				}
			}

			public void runNonLin() {
				isRunning = true;
				string encrypted;
				object args = new TrithemiusCipher.NonLinKey();
				int length = text1.Length < 5 ? text1.Length : 5;
				((TrithemiusCipher.NonLinKey)args).keyType = TrithemiusKey.NonLinearAquestion;

				for(int i = 0; i < 9999; i++) {
					((TrithemiusCipher.NonLinKey)args).A = i;
					for(int j = 0; j < 9999; j++) {
						if(!isRunning)
							return;
						((TrithemiusCipher.NonLinKey)args).B = j;
						for(int t = 0; t < 9999; t++) {
							((TrithemiusCipher.NonLinKey)args).C = t;
							int k;
							encrypted = trithemius.Trithemius(text1, CaesarCipher.Operation.Encrypt, args);
							for(k = 0; k < length; k++) {
								if(encrypted[k] != text2[k])
									break;
							}
							if(k >= length) {
								foundedNonLinEvent(i, j, t);
								return;
							}
							if(t % 2000 == 0)
								updateNonLinEvent(-1, -1, t);
						}

						if(j % 5 == 0)
							updateNonLinEvent(-1, j, -1);
					}
					updateNonLinEvent(i, -1, -1);
				}
			}
		}

		public HuckBrutforceTrithemius() {
			InitializeComponent();
			keyType = TrithemiusKey.LinearAquestion;
			th = new Thread[3];
			panel3.Enabled = false;
			panel4.Enabled = false;
		}

		private void CaesarPswForm_Load(object sender, EventArgs e) {
		}

		private void radioButtonClicked(object sender, EventArgs e) {
			if(sender == radioButton1) {
				keyType = TrithemiusKey.LinearAquestion;
				panel2.Enabled = true;
				panel3.Enabled = false;
				panel4.Enabled = false;
				textBox8.Text = "оJSабZLупаЕэУФщЮЮЖj71lxtC";
			} else if(sender == radioButton2) {
				keyType = TrithemiusKey.NonLinearAquestion;
				panel2.Enabled = false;
				panel3.Enabled = true;
				panel4.Enabled = false;
				textBox8.Text = "UqCPXдбОЩЫMXКіІгАЙVфУHВ6а";
			} else if(sender == radioButton3) {
				keyType = TrithemiusKey.Gaslo;
				panel2.Enabled = false;
				panel3.Enabled = false;
				panel4.Enabled = true;
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e) {
			radioButtonClicked(sender, e);
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e) {
			radioButtonClicked(sender, e);
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e) {
			radioButtonClicked(sender, e);
		}

		private void TrithemiusPswForm_Load(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			string text1 = textBox7.Text;
			string text2 = textBox8.Text;
			if(huckTrith != null && huckTrith.isRunning) {
				huckTrith.isRunning = false;
				huckTrith = null;
			}
			huckTrith = new Brutforser(text1, text2);
			if(keyType == TrithemiusKey.LinearAquestion) {
				th[0] = null;
				th[0] = new Thread(() => huckTrith.runLin());
				huckTrith.foundedLinEvent += (int i, int j) => {
					textBox1.Text = i.ToString();
					textBox2.Text = j.ToString();
					MessageBox.Show($"Founded: [{i}, {j}] !", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				};

				huckTrith.updateLinEvent += (int i, int j) => {
					if(i > 0)
						textBox1.Text = i.ToString();
					if(j > 0)
						textBox2.Text = j.ToString();
				};
				th[0].Start();
			} else if(keyType == TrithemiusKey.NonLinearAquestion) {
				th[0] = null;
				th[0] = new Thread(() => huckTrith.runNonLin());
				huckTrith.foundedNonLinEvent += (int i, int j, int k) => {
					textBox5.Text = i.ToString();
					textBox4.Text = j.ToString();
					textBox6.Text = k.ToString();
					MessageBox.Show($"Founded: [{i}, {j}, {k}] !", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				};

				huckTrith.updateNonLinEvent += (int i, int j, int k) => {
					if(i > 0)
						textBox5.Text = i.ToString();
					if(j > 0)
						textBox4.Text = j.ToString();
					if(k > 0)
						textBox6.Text = k.ToString();
				};
				th[0].Start();
			} else if(keyType == TrithemiusKey.Gaslo) {
			}
		}

		private void HuckBrutforceTrithemius_FormClosing(object sender, FormClosingEventArgs e) {
			if(huckTrith != null && huckTrith.isRunning) {
				huckTrith.isRunning = false;
			}
			if(th[0] != null) {
				//MessageBox.Show($"{th[0].ManagedThreadId}");
				th[0].Join();
			}
		}
	}
}
