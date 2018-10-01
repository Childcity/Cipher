using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher {
	class TrithemiusCipher: CaesarCipher {
		public class Key {
			public enum KeyType { LinearAquestion, NonLinearAquestion, Gaslo }
			public KeyType keyType { get; set; }
		}
		public class LinKey : Key {
			public int A { get; set; }
			public int B { get; set; }
		}
		public class NonLinKey : LinKey {
			public int C { get; set; }
		}
		public class Gaslo : Key {
			public string gaslo { get; set; }
		}

		public string Trithemius(string input, Operation op, object operationArgs) {
			string result = string.Empty;

			int posLetterInMsg = 0;
			foreach ( Char letter in input ) {
				int num, key = 0;

				switch(((Key)operationArgs).keyType) {
					case Key.KeyType.LinearAquestion:
						key = ((LinKey)operationArgs).A * posLetterInMsg + ((LinKey)operationArgs).B;
						break;
					case Key.KeyType.NonLinearAquestion:
						key = ((NonLinKey)operationArgs).A * posLetterInMsg * posLetterInMsg
							+ ((NonLinKey)operationArgs).B * posLetterInMsg + ((NonLinKey)operationArgs).C;
						break;
					case Key.KeyType.Gaslo:
						key = dict[((Gaslo)operationArgs).gaslo[posLetterInMsg]];
						if(posLetterInMsg % (((Gaslo)operationArgs).gaslo.Length+1) == 0)
							posLetterInMsg = -1;
						break;
				}

				if ( op == Operation.Encrypt ) {
					num = (dict[letter] + key) % dict.Count;
				} else {
					num = ( ( dict[letter] + dict.Count - ( key % dict.Count ) ) % dict.Count );
				}
				// Finding in dict letter num
				result += dict.FirstOrDefault(x => x.Value == num).Key;
				posLetterInMsg++;
			}

			return result;
		}
	}
}
