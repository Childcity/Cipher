using System;
using System.Windows.Forms;

namespace Cipher.HelpfulForms {
	public partial class HuckCaesarForm : Form {

		public delegate void DecryptCaesarMethod(string textToDe, string keyDe);
		public event DecryptCaesarMethod DecryptCaesarEvent;

		private string key_;

		public HuckCaesarForm(string textToDecrypt) {
			InitializeComponent();
			textBox1.Text = textToDecrypt;
			key_ = "0";
		}

		private void button8_Click(object sender, EventArgs e) {
			key_ = Convert.ToString(Int32.Parse(key_) + 1);
			label3.Text = "Psw: " + key_;
			//emit event
			DecryptCaesarEvent(textBox1.Text, key_);
		}

		private void button9_Click(object sender, EventArgs e) {
			key_ = Convert.ToString(Int32.Parse(key_) - 1);
			label3.Text = "Psw: " + key_;
			//emit event
			DecryptCaesarEvent(textBox1.Text, key_);
		}
	}
}
