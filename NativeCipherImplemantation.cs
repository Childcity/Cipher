using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Cipher {
	class NativeCipherImplemantation {
		public enum Operation { Encrypt, Decrypt }
		public enum Algorithm { DES, TripleDES, AES}

		public static string NativeCipher(string input, string key, Algorithm alg, Operation op) {
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			SymmetricAlgorithm cryptoProvider = null;
			CryptoStream cryptoStream;
			string result = string.Empty;

			if(String.IsNullOrEmpty(input)) {
				throw new ArgumentNullException
					   ("The string which needs to be encrypted can not be null.");
			}
			
			byte[] keyHash = md5.ComputeHash(Encoding.UTF8.GetBytes(key));

			switch(alg) {
				case Algorithm.DES:
					cryptoProvider = new DESCryptoServiceProvider();
					cryptoProvider.Key = cryptoProvider.IV = keyHash.Take(8).ToArray();
					break;
				case Algorithm.TripleDES:
					cryptoProvider = new TripleDESCryptoServiceProvider();
					cryptoProvider.Key = keyHash.Take(24).ToArray();
					cryptoProvider.IV = keyHash.Take(8).ToArray();
					break;
				case Algorithm.AES:
					cryptoProvider = new AesCryptoServiceProvider();
					cryptoProvider.Key = cryptoProvider.IV = keyHash;
					break;
				default:
					throw new ArgumentException("Algorithm is not implemented!");
			}

			cryptoProvider.Mode = CipherMode.CBC;

			if(op == Operation.Encrypt) {
				MemoryStream memoryStream = new MemoryStream();
				cryptoStream = new CryptoStream(memoryStream,
					cryptoProvider.CreateEncryptor(), CryptoStreamMode.Write);
				StreamWriter writer = new StreamWriter(cryptoStream);
				writer.Write(input); writer.Flush();
				cryptoStream.FlushFinalBlock();
				result = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
			} else {
				MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(input));
				cryptoStream = new CryptoStream(memoryStream,
					cryptoProvider.CreateDecryptor(), CryptoStreamMode.Read);
				result = new StreamReader(cryptoStream).ReadToEnd();
			}

			return result;
		}

	}
}
