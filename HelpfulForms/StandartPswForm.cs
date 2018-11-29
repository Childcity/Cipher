using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	}
}
