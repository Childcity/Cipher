using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cipher {
		public class CaesarCipher {
			public enum Operation{ Encrypt, Decrypt}
			public CaesarCipher() {
				int i = 0;
				dict = new Dictionary<Char, int>();

				for ( Char a = 'a'; a <= 'z'; a++ )
					dict[a] = i++;
				for ( Char a = 'A'; a <= 'Z'; a++ )
					dict[a] = i++;


				for ( Char a = 'а'; a <= 'я'; a++ )
					dict[a] = i++;

				dict['\n'] = i++; // new line
				dict['\r'] = i++; // new line

				dict['—'] = i++; dict[','] = i++; dict['.'] = i++; dict['?'] = i++;
				dict['!'] = i++; dict[')'] = i++;dict['('] = i++; dict['-'] = i++;
				dict[':'] = i++;
				//dict['\''] = i++; dict['!'] = i++;
				//dict['"'] = i++; dict['№'] = i++; dict[';'] = i++; dict['%'] = i++;
				//dict[':'] = i++; dict['?'] = i++; dict['*'] = i++; dict['('] = i++;
				//dict[')'] = i++;dict['_'] = i++; dict['-'] = i++; dict['='] = i++;
				//dict['+'] = i++;

				for ( Char a = 'А'; a <= 'Я'; a++ )
					dict[a] = i++;

				dict[' '] = i++; // Space
				dict['ё'] = i++; // rus
				dict['Ё'] = i++; // rus
				dict['Ї'] = i++; // ukr
				dict['І'] = i++; // ukr
				dict['ї'] = i++; // ukr
				dict['і'] = i++; // ukr

				for ( Char a = '0'; a <= '9'; a++ )
					dict[a] = i++;
			}

			public string getAlphabet(int width) {
				string res = string.Empty;
				int length = 0;	
				foreach ( var it in dict ) {
					res += it;

					length+=it.ToString().Length;
					if(length >= width - 750 ) {
						res += "\n";
						length = 0;
					}
				}
				return res;
			}

			public string Caesar(string input, int key, Operation op) {
				string result = string.Empty;

				foreach ( Char letter in input ) {
					int num;

					if ( op == Operation.Encrypt ) {
						num = ( dict[letter] + key ) % dict.Count;
					} else {
						num = ( ( dict[letter] + dict.Count - ( key % dict.Count ) ) % dict.Count );
					}

					// Finding in dict letter num
					result += dict.FirstOrDefault(x => x.Value == num).Key;
				}
		
				return result;
			}

			public static bool CheckInput(string str, out MatchCollection matches) {
				Regex reg = new Regex(@"^[a-z а-я0-9\n\rЇїІіёЁ—,\.!?:\-\(\)]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
				matches = reg.Matches(str);
				return matches.Count > 0;
			}

			protected Dictionary<Char, int> dict;
	}
}