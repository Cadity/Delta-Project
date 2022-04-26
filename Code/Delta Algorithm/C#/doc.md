# Documentation of Delta Algorithm for C# Developper

## Table of Content

* [Auth Methods](#auth-methods)
  * [Regex](#regex)
  * [Alea Gen](#alea-gen)

### Auth Methods

#### Regex

```C#
public class Identification
{
	 public static string Regex(string PublicKey)
}
```
Regular Expression for PGP public key (RFC 4080 format)
Input : Public PGP key 
Output : 
 - "null" : Publickey was not detected -> string is empty
 - "success" : Publickey have had a positive result to Regex test
 - "Syntaxic Error" : Publickey have had a negetive result to Regex test

**Exemple of Use :**

```C#
 public void RegexTest
{
	string regex = this.Input.Text;
	var result = Identification.Regex(regex);
	if (result == "success")
	{
		// Instruction
	}
	else 
	{
		MessageBox.Show("Syntaxic Error ! Try again")
	}
}
```

#### Alea Gen

```C#
public class Identification
{
	 public static string AleaGen
}
```
Generate a random string of 128 characters among 42 candidates.

