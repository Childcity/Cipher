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
	public partial class KnapsackPrvKeyForm :Form {
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
				textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length-1,1);
			}
		}

		private int m, n;
		public int M {
			set { m = value; textBox2.Text = value.ToString(); }
			get {
				try { m = Int32.Parse(textBox2.Text); }
				catch {
					m = 0;
					MessageBox.Show("M is a number!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				return m;
			} }
		public int N {
			set { n = value; textBox4.Text = value.ToString(); }
			get {
				try { n = Int32.Parse(textBox4.Text); } catch {
					n = 0;
					MessageBox.Show("N is a number!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				return n;
			}
		}

		public KnapsackPrvKeyForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
		}

		private void button2_Click(object sender, EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				string[] lines = File.ReadAllLines(openFileDialog1.FileName);
				if(lines.Length >= 2) {
					textBox3.Text = lines[0];
					textBox2.Text = lines[1].Split(' ')[0];
					textBox4.Text = lines[1].Split(' ')[1];
				}
			}
		}
	}
}
