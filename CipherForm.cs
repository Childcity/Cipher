using Cipher.HelpfulForms;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cipher {
	using Operation = CaesarCipher.Operation;

	public partial class CipherForm : Form
	{
		private CaesarCipher caesarCipher;
		private TrithemiusCipher trithemiusCipher;
		public CipherForm()
		{
			InitializeComponent();
			caesarCipher = new CaesarCipher();
			trithemiusCipher = new TrithemiusCipher();
		}

		private void tryCaesarEncryptDecrypt(Operation op) {
			string textToEncrypt = textBox1.Text;
			if ( CaesarCipher.CheckInput(textToEncrypt, out MatchCollection matches) ) {
				textBox1.BackColor = Color.White;
				CaesarPswForm showPsw = new CaesarPswForm();
				if ( DialogResult.Cancel == showPsw.ShowDialog(this) ) {
					return;
				}
				textBox1.Text = caesarCipher.Caesar(matches[0].Value,
					Int32.Parse(showPsw.key), op);
			} else {
				textBox1.BackColor = Color.LightGoldenrodYellow;
				MessageBox.Show("Text contain illegal character!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBox1.BackColor = Color.White;
			}
		}

		private void tryThrithemiusEncryptDecrypt(Operation op) {
			string textToEncrypt = textBox1.Text;
			if ( CaesarCipher.CheckInput(textToEncrypt, out MatchCollection matches) ) {
				textBox1.BackColor = Color.White;

				TrithemiusPswForm showPsw = new TrithemiusPswForm();
				do { 
					if ( DialogResult.Cancel == showPsw.ShowDialog(this)) {
						return;
					}
				} while(showPsw.retry);
				//MessageBox.Show(((TrithemiusCipher.LinKey)showPsw.TrithemiusKeyArgs).B.ToString());
				textBox1.Text = trithemiusCipher.Trithemius(matches[0].Value, op, showPsw.TrithemiusKeyArgs);
			} else {
				textBox1.BackColor = Color.LightGoldenrodYellow;
				MessageBox.Show("Text contain illegal character!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBox1.BackColor = Color.White;
			}
		}

		private void encryptToolStripMenuItem1_Click(object sender, EventArgs e) {
			tryCaesarEncryptDecrypt(Operation.Encrypt);
		}

		private void decryptToolStripMenuItem_Click(object sender, EventArgs e) {
			tryCaesarEncryptDecrypt(Operation.Decrypt);
		}

		private void encryptToolStripMenuItem2_Click(object sender, EventArgs e) {
			tryThrithemiusEncryptDecrypt(Operation.Encrypt);
		}

		private void decryptToolStripMenuItem1_Click(object sender, EventArgs e) {
			tryThrithemiusEncryptDecrypt(Operation.Decrypt);
		}

		private void onDecryptCaesar(string textToDe, string keyDe) {
			textBox1.Text = caesarCipher.Caesar(textToDe, Int32.Parse(keyDe), CaesarCipher.Operation.Decrypt);
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
			openFileDialog1.FileName = "text";
			if ( openFileDialog1.ShowDialog() == DialogResult.OK ) {
				textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
			}
		}

		private void hackToolStripMenuItem_Click(object sender, EventArgs e) {
			HuckCaesarForm hucker = new HuckCaesarForm(textBox1.Text);
			hucker.DecryptCaesarEvent += onDecryptCaesar; 
			hucker.Show();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			About about = new About();
			about.Show();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			saveFileDialog1.FileName = "text";
			if ( saveFileDialog1.ShowDialog() == DialogResult.OK ) {
				File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
			}
		}

		private void huckToolStripMenuItem_Click(object sender, EventArgs e) {
			HuckBrutforceTrithemius tritHuck = new HuckBrutforceTrithemius();
			tritHuck.Show();
		}
	}
}
