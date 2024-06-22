#! MAKE SURE TO INSTALL THE CRYPTOGRAPHY PACKAGE FIRST

from cryptography.fernet import Fernet

# Generate a key for encryption
key = Fernet.generate_key()
cipher = Fernet(key)

# Message to be encrypted
message = b"Hello, World!"

# Encrypt the message
encrypted_message = cipher.encrypt(message)
print("Encrypted message:", encrypted_message)

# Decrypt the message
decrypted_message = cipher.decrypt(encrypted_message)
print("Decrypted message:", decrypted_message.decode())
