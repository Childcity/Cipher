using System;
using System.IO;
using System.Windows.Forms;

namespace Cipher.HelpfulForms {
	public partial class RSAKeyGeneratorForm :Form {
		public RSAKeyGeneratorForm() {
			InitializeComponent();
			NativeCipherImplemantation.GenerateAsymmetricKeys(1024, out string prvKey, out string pubKey);
			textBox1.Text = prvKey;
			textBox3.Text = pubKey;
		}

		private void button2_Click(object sender, EventArgs e) { 
			saveFileDialog1.FileName = "key";
			if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
				File.WriteAllText(saveFileDialog1.FileName + "_private.json", textBox1.Text);
				File.WriteAllText(saveFileDialog1.FileName + "_public.json", textBox3.Text);
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e) {

		}
	}
}
