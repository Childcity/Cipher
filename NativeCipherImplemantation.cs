using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Cipher {
	class NativeCipherImplemantation {
		public enum Operation { Encrypt, Decrypt }
		public enum Algorithm { DES, TripleDES, AES}

		public static string SymmetricCipher(string input, string key, Algorithm alg, Operation op) {
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			SymmetricAlgorithm cryptoProvider = null;
			CryptoStream cryptoStream;
			string result = string.Empty;
			
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
					throw new ArgumentException("Symmetric algorithm is not implemented!");
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

		public static string RSACipher(string input, string keyXML, Operation op) {
			string result = string.Empty;

			RSACryptoServiceProvider cryptoProvider = new RSACryptoServiceProvider();

			//set params (public or private key, converted from xml)
			cryptoProvider.FromXmlString(keyXML);

			if(op == Operation.Encrypt) {
				// apply pkcs#1.5 padding and encrypt our data 
				byte[] bytesCypherText = cryptoProvider.Encrypt(Encoding.UTF8.GetBytes(input), false);
				//a string representation of our cypher text
				result = Convert.ToBase64String(bytesCypherText);
			} else {
				//decrypt and strip pkcs#1.5 padding
				byte[] bytesPlainTextData = cryptoProvider.Decrypt(Convert.FromBase64String(input), false);
				//get our original plainText back
				result = Encoding.UTF8.GetString(bytesPlainTextData);
			}

			return result;
		}

		public static void GenerateAsymmetricKeys(int bitsNum, out string prvKeyXML, out string pubKeyXML) {
			//new CSP with a new bitsNum bit rsa key pair
			using(var csp = new RSACryptoServiceProvider(bitsNum)) { 
				//get the private key
				prvKeyXML = csp.ToXmlString(true);
				//get the public key
				pubKeyXML = csp.ToXmlString(true);
			}
		}

	}
}
