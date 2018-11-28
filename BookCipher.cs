using System;
using System.Linq;
using System.Windows.Forms;

namespace Cipher {
	using Operation = CaesarCipher.Operation;

	class BookCipher {
		private char[,] dict = null;
		private Random rnd = null;

		public BookCipher() {
			rnd = new Random(new DateTime().Millisecond);
		}

		public string Book(string input, string book, Operation op) {
			string result = string.Empty;
			dict = prepareDict(ref book);

			if(op == Operation.Encrypt) {
				foreach(var letter in input) {
					var pos = findRandomLetter(letter);
					result += pos.y +"," + pos.x + ' ';
				}
			} else {
				foreach(var letter in input.Trim().Split(' ')) {
					(int x, int y) pos = (Int32.Parse(letter.Split(',')[0]), Int32.Parse(letter.Split(',')[1]));
					if(pos.x == -1) {
						result += '?'; continue;
					}
					result += dict[pos.x, pos.y];
				}
			}
			return result;
		}

		private (int x, int y) findRandomLetter(char letter) {
			int rundomDigit = rnd.Next(1,300);
			//MessageBox.Show(""+rundomDigit);
			var firstPositionOfLetter  = findLetter((0, 0), letter);
			if(firstPositionOfLetter.x == -1)
				return (-1, -1);
			(int x, int y) randomPos = (-1, -1);
			for(int i = 0; i < rundomDigit; i++) {
				randomPos.x++; randomPos.y++;
				randomPos = findLetter(randomPos, letter); 
				if(randomPos.x == -1) {
					if(i < rundomDigit - 2) {
						randomPos = (-1, -1);
						continue;
					} else
						return firstPositionOfLetter;
				}
			}
			return randomPos;
		}

		private (int x, int y) findLetter((int x, int y) start, char letter) {
			for(int i = start.y; i < dict.GetLength(0); i++) {
				for(int j = start.x; j < dict.GetLength(1); j++) {
					if(dict[i,j] == letter) {
						return (j, i);
					}
				}
			}
			return (-1, -1);
		}

		private char[,] prepareDict(ref string book) {
			char[,] result = null;
			int dimentionSize = book.Length / (int)Math.Sqrt(book.Length);
			result = new char[dimentionSize, dimentionSize];
			var nextLetter = book.GetEnumerator();
			for(int i = 0; i < dimentionSize; i++) {
				for(int j = 0; j < dimentionSize && nextLetter.MoveNext(); j++) {
					result[i,j] = nextLetter.Current;
				}
			}
			return result;
		}

		//private string getDict() {
		//	string res = "\r\n";
		//	for(int i = 0; i < dict.GetLength(0); i++) {
		//		for(int j = 0; j < dict.GetLength(1); j++) {
		//			res +=dict[i, j]+" ";
		//		}
		//		res += "\r\n";
		//	}
		//	return res;
		//}
	}
}