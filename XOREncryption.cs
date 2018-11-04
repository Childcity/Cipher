using System;
using System.Collections.Generic;
using System.Linq;

namespace Cipher {
	class XOREncryptionCipher :CaesarCipher {

		public string XOR(string input, int key, Operation op) {
			string result = string.Empty;
			int num;
			var gamma = GenerateGamma(key, input.Length);
			var it = gamma.GetEnumerator();

			if(op == Operation.Encrypt) {
				foreach(Char letter in input) {
					it.MoveNext();
					//num = (dict[letter] + it.Current) % dict.Count;
					num = (dict[letter] ^ it.Current);
					result += num + " ";
				}
			} else {
				foreach(var item in input.Trim().Split(' ')) {
					it.MoveNext();
					num = (int.Parse(item) ^ it.Current);
					//num = (int.Parse(item) + dict.Count - (it.Current % dict.Count)) % dict.Count;
					result += dict.FirstOrDefault(x => x.Value == num).Key;
				}
			}

			return result;
		}

		public List<int> GenerateGamma(int key, int outLength) {
			List<int> result = new List<int>();
			var rnd = new Random(key);
			for(int i = 0; i < outLength; i++) {
				result.Add(rnd.Next(1, dict.Count-1));
			}
			return result;
		}
	}
}

