import crypto from "crypto";

// Generate a random 32-byte key for AES-256
const key = crypto.randomBytes(32);

// Generate a random 16-byte initialization vector
const iv = crypto.randomBytes(16);

// Encrypt a message using the key and IV
const message = "Hello, world!";
const cipher = crypto.createCipheriv("aes-256-cbc", key, iv);
let encrypted = cipher.update(message, "utf8", "hex");
encrypted += cipher.final("hex");

console.log("Encrypted message:", encrypted);

// Decrypt the message using the same key and IV
const decipher = crypto.createDecipheriv("aes-256-cbc", key, iv);
let decrypted = decipher.update(encrypted, "hex", "utf8");
decrypted += decipher.final("utf8");

console.log("Decrypted message:", decrypted);