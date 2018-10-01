using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cipher.HelpfulForms {
	using TrithemiusKey = TrithemiusCipher.Key.KeyType;

	public partial class TrithemiusPswForm : Form {
		private TrithemiusKey keyType;
		public object TrithemiusKeyArgs;
		public bool retry {get; set;}

		public TrithemiusPswForm() {
			InitializeComponent();
			keyType = TrithemiusKey.LinearAquestion;
			panel3.Enabled = false;
			panel4.Enabled = false;
		}

		private int checkNumber(ref TextBox text) {
			int integer = 0;
			try {
				if (text.Text.Length == 0 ) {
					return integer;
				}
				integer = Int32.Parse(text.Text);
			} catch ( Exception ) {
				text.Text = "0";
				text.BackColor = Color.Red;
				MessageBox.Show("Only number can be a password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				text.BackColor = Color.White;
				throw new ArgumentException();
			}
			return integer < 0 ? -integer : integer;
		}

		private void button1_Click_1(object sender, EventArgs e) {
			try {
				if(keyType == TrithemiusKey.LinearAquestion) {
					TrithemiusKeyArgs = new TrithemiusCipher.LinKey();
					((TrithemiusCipher.LinKey)TrithemiusKeyArgs).A = checkNumber(ref textBox1);
					((TrithemiusCipher.LinKey)TrithemiusKeyArgs).B = checkNumber(ref textBox2);
				} else if(keyType == TrithemiusKey.NonLinearAquestion) {
					TrithemiusKeyArgs = new TrithemiusCipher.NonLinKey();
					((TrithemiusCipher.NonLinKey)TrithemiusKeyArgs).A = checkNumber(ref textBox5);
					((TrithemiusCipher.NonLinKey)TrithemiusKeyArgs).B = checkNumber(ref textBox4);
					((TrithemiusCipher.NonLinKey)TrithemiusKeyArgs).C = checkNumber(ref textBox6);
				} else if(keyType == TrithemiusKey.Gaslo) {
					TrithemiusKeyArgs = new TrithemiusCipher.Gaslo();
					if(CaesarCipher.CheckInput(textBox3.Text, out MatchCollection matches)) {
						((TrithemiusCipher.Gaslo)TrithemiusKeyArgs).gaslo = matches[0].Value;
					} else {
						textBox3.Text = "0";
						textBox3.BackColor = Color.Red;
						MessageBox.Show("Invalid symbol in 'global'!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						textBox3.BackColor = Color.White;
						throw new ArgumentException();
					}
				}

				((TrithemiusCipher.Key)TrithemiusKeyArgs).keyType = keyType;
				retry = false;
			} catch (Exception ){
				retry = true;
			}
		}

		private void CaesarPswForm_Load(object sender, EventArgs e) {
		}

		private void radioButtonClicked(object sender, EventArgs e) {
			if( sender == radioButton1 ) {
				keyType = TrithemiusKey.LinearAquestion;
				panel2.Enabled = true;
				panel3.Enabled = false;
				panel4.Enabled = false;
			} else if( sender == radioButton2 ) {
				keyType = TrithemiusKey.NonLinearAquestion;
				panel2.Enabled = false;
				panel3.Enabled = true;
				panel4.Enabled = false;
			} else if ( sender == radioButton3 ) {
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
	}
}
