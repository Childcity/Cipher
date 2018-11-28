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
	public partial class KnapsackKeyGeneratorForm :Form {
		private TheKnapsackProblemCipher knapsack;
		public int M { set { knapsack.M = value; textBox2.Text = value.ToString(); } get {return knapsack.M; } }
		public int N { set { knapsack.N = value; textBox4.Text = value.ToString(); } get { return knapsack.N; } }
		public int[] PublicKey { 
			get { return knapsack.PublicKey; }
			set {
					textBox3.Text = "";
					foreach(var num in value) {
						textBox3.Text += num + " ";
					}
					textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1, 1);
			}
		}
		public int[] PrivateKey {
			get {
				return knapsack.PrivateKey;
			}
			set {
				textBox1.Text = "";
				foreach(var num in value) {
						textBox1.Text += num + " ";
				}
				textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
			}
		}
		public KnapsackKeyGeneratorForm() {
			InitializeComponent();
			knapsack = new TheKnapsackProblemCipher();
		}

		private void button2_Click(object sender, EventArgs e) {
			saveFileDialog1.FileName = "key";
			if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
				File.WriteAllText(saveFileDialog1.FileName + "_private.txt", textBox1.Text + "\n" + M + " " + N);
				File.WriteAllText(saveFileDialog1.FileName + "_public.txt", textBox3.Text);
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e) {
			checkMN();
		}

		private void textBox4_TextChanged(object sender, EventArgs e) {
			checkMN();
		}

		private void checkMN() {
			try {
				knapsack.M = Int32.Parse(textBox2.Text);
				knapsack.N = Int32.Parse(textBox4.Text);
				if(TheKnapsackProblemCipher.GCD(knapsack.N, knapsack.M) == 1) {
					label8.BackColor = Color.LawnGreen;
				} else {
					label8.BackColor = Color.Tomato;
				}
				int sumOfAll = TheKnapsackProblemCipher.CountSumOfPrev(knapsack.PrivateKey);
				label7.Text = "(> " + sumOfAll + " )";
				if(knapsack.M > sumOfAll) {
					label7.BackColor = Color.LawnGreen;
				} else {
					label7.BackColor = Color.Tomato;
				}
			} catch {
				knapsack.M = knapsack.N = 0;
				MessageBox.Show("M, N are numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			try {
				int i = 0;
				knapsack.PrivateKey = new int[textBox1.Text.Split(' ').Length];
				foreach(var item in textBox1.Text.Split(' ')) {
					if(item != "")
						knapsack.PrivateKey[i++] = Int32.Parse(item);
				}
				knapsack.RegeneratePublicKey();
				PublicKey = knapsack.PublicKey;
				M = TheKnapsackProblemCipher.CountSumOfPrev(PrivateKey) + 1;
				checkMN();
			} catch {
				knapsack.PrivateKey = knapsack.PublicKey = null;
				MessageBox.Show("Key should consist numbers, seperated by space!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void textBox5_TextChanged(object sender, EventArgs e) {
			try {
				knapsack.RegeneratePrivateKey(10, Int32.Parse(textBox5.Text)); 
				PrivateKey = knapsack.PrivateKey;
			} catch {
				MessageBox.Show("Seed is a numbers, seperated by space!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
