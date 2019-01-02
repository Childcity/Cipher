

# Simple of cipher on C#, that provide encription and decription in defferent algorithms

#### Currently cipher provide realization of:
  - Caesar algorithme;         
  - Trithemius algorithme;
  - XOR Encription algorithme;
  - Book cipher algorithme;
  - The Knapsack cipher algorithme (based on The Knapsack Problem);
  - .NET native algorithm implementation
	  - DES;
	  - TripleDES;
	  - AES;
	  - RSA.

#### Next future: 
  - Today - nothing

#### Some info:
  - ##### Caesar algorithme is described [here](https://en.wikipedia.org/wiki/Caesar_cipher)
    - Encrypt: ```y  = (x+k) mod n ```
    - Decrypt: ```x  = (y+n−(k mod n)) mod n```
        , where: 
        - ```x```  —  letter of plaintext
        - ```y```  —  letter of ciphertext
        - ```k```  —  key (how much symbols to shift)
        - ```n```  —  count of all symbols in our alphabet
      
  - ##### Trithemius algorithme is described [here](https://en.wikipedia.org/wiki/Tabula_recta)
    - Encrypt: ```y  = (x+k) mod n```               (as in Caesar)
    - Decrypt: ```x  = (y+n−(k mod n)) mod n```     (as in Caesar)
        , where: 
        - ```x```  —  letter of plaintext
        - ```y```  —  letter of ciphertext
        - ```n```  —  count of all symbols in our alphabet
        - ```k```  —  key (how much symbols to shift) is calculated by next three way
            1) by linear equation:    ```k = Ap + B```
            2) by nonlinear equation: ```k = Ap^2 + Bp + C``` 
            3) by ```MOTTO```
                   , where: 
                - ```A,B,C``` - coefficients of equation, that User enter instead of password
                - ```MOTTO``` - this some word or sentence (as password)

  - ##### XOR Encription algorithme is described [here](https://en.wikipedia.org/wiki/XOR_cipher)
    - Encrypt/Decrypt: ```z = x + g (mod 2) = x XOR g```
        , where: 
        - ```x```  —  letter of plaintext/ciphertext
       - ```z```  —  result letter 
            - (if Encription: letter of ciphertext) 
            - (if Decription: letter of plaintext)   
       - ```g```  —  symbol of 'gamma'
            -   Explanation:
                1) user enter password (some 'digit') -> we create Random generator with user seed ('digit', that he/she entered);
                2) we generate random 'gamma' which length equals to length of plaintext;
                2) encrypt each letter, using formula, that you can see upper.


  - ##### Book cipher algorithme  is described [here](https://en.wikipedia.org/wiki/Book_cipher)
    - Explanation:
      1) password it is some 'book' or 'poem'. (in my realization i use just TXT file, in which should be some text);
      2) to encrypt and decript input text we make table (in my realization it is 'char[,] dict;') and feel it with letters from input.
         It will be in practic something like this:
         
            0 |1| 2| 3| 4| 5 | 6 | 7 | 8 | 9 |...|
            | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- |
            1| H | y | , | M | y | n | a | m | e |
            2| i | s | B | o | b | M | o | r | l |
            3| a | y | . | T | h | i | s | i | s |
            4| a | s | i | m | p | l | e | ' | b |
            5| o | o | k| ! | C | i | p | h | e |
           ...|
      3) to encrypt, for each letter in plaintext we: just find x and y of this letter in our table.
         Important to get random letter if in table there are more then one the same letter!
      4) to decrypt, jut find position of each letter (that will be in ciphertext) in our table


  - ##### The Knapsack cipher algorithme (based on The Knapsack Problem) [here](https://en.wikipedia.org/wiki/Merkle%E2%80%93Hellman_knapsack_cryptosystem) and [here](https://nrich.maths.org/2199) (more understandable to me)
    - Explanation:
	    1) Private key is superincreasing sequence. For example, the set {1, 2, 4, 10, 20, 40}
	    2) - Public key:
	    One algorithm that uses a superincreasing knapsack for the private (easy) key and a non-superincreasing knapsack for the public key was created by Merkle and Hellman They did this by taking a superincreasing knapsack problem and converting it into a non-superincreasing one that could be made public, using modulus arithmetic.
			-    **Making the Public Key**
			To produce a normal knapsack sequence, take a superincreasing sequence; e.g. {1, 2, 4, 10, 20, 40}. Multiply all the values by a number ```n MODulo m```. The modulus should be a number greater than the sum of all the numbers in the sequence, for example, 110. The multiplier should have no factors in common with the modulus. So let's choose 31. The normal knapsack sequence would be: 
					```
					1×31 mod(110) = 31  
					2×31 mod(110) = 62  
					4×31 mod(110) = 14  
					10×31 mod(110) = 90  
					20×31 mod(110) = 70  
					40×31 mod(110) = 30
					```

		3) So the public key is: {31, 62, 14, 90, 70, 30} and  
		the private key is **{1, 2, 4, 10, 20.40}, n = 31, m = 110**.


  - ##### .NET native algorithm implementation [here](https://en.wikipedia.org/wiki/Book_cipher)
    - Explanation:
    This project contains examples of implementation of standard encryption algorithms such as DES, TripleDES, AES, RSA with GUI Interface.


##### Nikolay gorodetskiy,
###### January 2, 2018 - Kyiv, Ukraine   
