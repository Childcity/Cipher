using System;
using System.IO;
using System.Windows.Forms;

namespace Cipher.HelpfulForms {
	public partial class StandartPswForm :Form {
		public string Password {set; get;}
		public StandartPswForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			Password = textBox3.Text;
		}

		private void button2_Click(object sender, EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				textBox3.Text = File.ReadAllText(openFileDialog1.FileName);
			}
		}
	}
}
