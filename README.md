# ADFGX Cipher

This C# project brings to life the ADFGX Cipher, a historically significant cryptographic method employed during World War I. It encompasses essential functionalities, including encryption, decryption, and key generation.

## Overview

The ADFGX Cipher is a field cipher renowned for its role in securing sensitive communications during World War I. This project, implemented in C#, encapsulates the essence of the ADFGX Cipher, offering a practical tool for modern developers.

## Key Features

- **Encryption:** Utilize the ADFGX algorithm to encode messages securely.
- **Decryption:** Decode ADFGX-encrypted messages with precision.
- **Key Generation:** Generate cryptographic keys for enhanced security and communication integrity.

## How to Use

1. Clone the repository to your local machine.
2. Open the project in your preferred C# development environment.
3. Run the application and explore encryption, decryption, and key generation functionalities.

## Example

```csharp
ADFGXCipher cipher = new ADFGXCipher();
string plaintext = "HELLO";
string key = "KEYWORD";
string encryptedText = cipher.Encrypt(plaintext, key);
Console.WriteLine($"Encrypted Text: {encryptedText}");
