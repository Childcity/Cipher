using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Cipher {
	class TheKnapsackProblemCipher {
		public enum Operation { Encrypt, Decrypt }
		public int[] PrivateKey { set; get; }
		public int[] PublicKey { set; get; }
		public int N { set; get; }
		public int M { set; get; }

		public TheKnapsackProblemCipher() { // Generate with default langth, M, N
			RegeneratePrivateKey(10, 1); // 1 - just default seed for default key, 10 - default langth
			M = CountSumOfPrev(PrivateKey) + 1;
			N = 13; // 13 - just default num, that is correct (GCD(M, N) should == 1) !!
			RegeneratePublicKey();
		}

		public void RegeneratePrivateKey(int langth, int seed) {
			// Generate supergrowth sequence (public key)
			PrivateKey = GenerateSupergrowthSequence(langth, seed);
		}

		public void RegeneratePublicKey() {
			PublicKey = new int[PrivateKey.Length];
			for(int i = 0; i < PrivateKey.Length; i++) {
				PublicKey[i] = PrivateKey[i] * N % M;
			}
		}

		public string Knapsack(string input, Operation op) {
			string result = string.Empty;

			if(op == Operation.Encrypt) {
				foreach(var chunk in ChunksUpto(TextToBitsList(input), PublicKey.Length)) {
					int cipherNum = 0;
					for(int i = 0; i < chunk.Count; i++) {
						if(chunk.ElementAt(i) == true) {
							// Encryption
							cipherNum += PublicKey[i];
						}
					}
					result += cipherNum + " ";
				}
			} else {
				// We need n−1, which is a multiplicative inverse of n mod m, i.e. n(n−1) = 1 mod m
				int multInverseOfMN = ModInverse(N, M);
				List<bool> bitsList = new List<bool>();
				foreach(string cipherNumStr in input.Trim().Split(' ')) {
					int cipherNum = int.Parse(cipherNumStr);
					// Find link to decription in README. In general, next line decrypt encrypted number (cipherNum)
					int plainNum = (cipherNum * multInverseOfMN) % M;

					// Building a chunk of bits from plainNum (represent number as list of bits)
					List<bool> chunk = new List<bool>();
					for(int i = PrivateKey.Length - 1; i >= 0; i--) {
						if(PrivateKey[i] <= plainNum) {
							chunk.Add(true);
							plainNum -= PrivateKey[i];
						} else {
							chunk.Add(false);
						}
					}
					chunk.Reverse();
					bitsList.AddRange(chunk);
				}
				
				// Converting bits to Text (UTF8)
				result = BitsListToText(bitsList);
			}

			return result;
		}

		public static List<bool> TextToBitsList(string text) {
			List<bool> bitsList = new List<bool>();
			
			foreach(var oneByte in Encoding.UTF8.GetBytes(text)) {
				for(int i = 7; i >= 0; i--) {
					bitsList.Add(((oneByte >> i) & 1) == 1);
				}
			}

			return bitsList;
		}

		public static string BitsListToText(List<bool> bitsList) {
			byte[] byteArray = new byte[bitsList.Count / 8];
			BitArray bitsArray = new BitArray(bitsList.Count - (bitsList.Count % 8));
			
			// Change from big-endian to little-endian
			for(int i = 0; i < bitsArray.Length; i++)
				bitsArray[i] = bitsList.ElementAt(bitsArray.Length - i - 1);

			bitsArray.CopyTo(byteArray, 0);
			Array.Reverse(byteArray);

			return Encoding.UTF8.GetString(byteArray);
		}

		public static IEnumerable<List<bool>> ChunksUpto(List<bool> bitsLit, int maxChunkSize) {
			for(int i = 0; i < bitsLit.Count; i += maxChunkSize)
				yield return bitsLit.GetRange(i, Math.Min(maxChunkSize, bitsLit.Count - i));
		}

		public int[] GenerateSupergrowthSequence(int langth, int seed) {
			int[] supergrowthSequence = new int[langth];
			var rnd = new Random(seed);

			int lastSumOfPrev = 0;
			for(int i = 0; i < langth; i++) {
				supergrowthSequence[i] = rnd.Next(lastSumOfPrev, lastSumOfPrev + 10);
				lastSumOfPrev += supergrowthSequence[i];
			}

			return supergrowthSequence;
		}

		// The multiplier should have no factors in common with the modulus.
		public static int ModInverse(int n, int m) {
			n = n % m;
			for(int x = 1; x < m; x++)
				if((n * x) % m == 1)
					return x;
			return 1;
		}

		// Euclidean algorithm
		static public int GCD(int a, int b) {
			return (b != 0) ? GCD(b, a % b) : a;
		}

		static public int CountSumOfPrev(int[] arr) {
			int sumOfPrev = 0;
			foreach(var it in arr) {
				sumOfPrev += it;
			}
			return sumOfPrev;
		}
	}
}
