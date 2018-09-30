using Cezar.HelpfulForms;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cipher {
	public partial class CipherForm : Form
	{
		private CaesarCipher caesarCipher;
		public CipherForm()
		{
			InitializeComponent();
			caesarCipher = new CaesarCipher();
		}

		private void tryCaesarEncryptDecrypt(CaesarCipher.Operation op) {
			string textToEncrypt = textBox1.Text;
			if ( CaesarCipher.CheckInput(textToEncrypt, out MatchCollection matches) ) {
				textBox1.BackColor = Color.White;
				CaesarPswForm showPsw = new CaesarPswForm();
				if ( DialogResult.Cancel == showPsw.ShowDialog(this) ) {
					return;
				}
				textBox1.Text = caesarCipher.Caesar(matches[0].Value,
					Int32.Parse(showPsw.key),
					( op == CaesarCipher.Operation.Encrypt ) ? CaesarCipher.Operation.Encrypt : CaesarCipher.Operation.Decrypt);
			} else {
				textBox1.BackColor = Color.LightGoldenrodYellow;
				MessageBox.Show("Text contain illegal character!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBox1.BackColor = Color.White;
			}
		}

		private void encryptToolStripMenuItem1_Click(object sender, EventArgs e) {
			tryCaesarEncryptDecrypt(CaesarCipher.Operation.Encrypt);
		}

		private void decryptToolStripMenuItem_Click(object sender, EventArgs e) {
			tryCaesarEncryptDecrypt(CaesarCipher.Operation.Decrypt);
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
	}
}
