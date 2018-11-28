using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher.HelpfulForms {
	public partial class KnapsackPubKeyForm :Form {
		private int[] key;
		public int[] Key {
			get {
				key = new int[textBox3.Text.Split(' ').Length];
				int i = 0;
				try {
					foreach(var item in textBox3.Text.Split(' ')) {
						if(item != "")
							key[i++] = Int32.Parse(item);
					}
				} catch {
					key = null;
					MessageBox.Show("Key should consist numbers, seperated by space!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				return key;
			}
			set {
				foreach(var num in value) {
					textBox3.Text += num + " ";
				}
				textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1, 1);
			}
		}

		public KnapsackPubKeyForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
		}

		private void button2_Click(object sender, EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				textBox3.Text = File.ReadAllText(openFileDialog1.FileName);
			}
		}
	}
}
