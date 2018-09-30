using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cezar.HelpfulForms {
	public partial class CaesarPswForm : Form {
		public string key { get; set; }
		public CaesarPswForm() {
			InitializeComponent();
			key = textBox3.Text;
		}

		private void textBox3_TextChanged(object sender, EventArgs e) {
			try {
				textBox3.BackColor = Color.White;
				if ( textBox3.Text.Length == 0 ) {
					key = "0";
					return;
				}
				Int32.Parse(textBox3.Text);
				if ( textBox3.Text.Length < 4 )
					key = textBox3.Text;
				else
					throw new ArgumentException();
			} catch ( Exception ) {
				textBox3.Text = key;
				textBox3.BackColor = Color.Red;
			}
		}

		private void button1_Click(object sender, EventArgs e) {

		}
	}
}
