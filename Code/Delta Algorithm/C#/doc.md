# Documentation of Delta Algorithm for C#

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
 public string RegexTest
{
	string PublicKey;
	var result = Identification.Regex(PublicKey);
	if (result == "success")
	{
		// Instruction
	}
	else 
	{
		return “Error”;
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
Return random string.

**Exemple of use :**

```C#
public string AleaGen
{
      var randomString = Identification.AleaGen():
      
      return randomString;
}
```

**Exceptions :**

```C#
if (randomString == null)
            {
                throw new Exception(“randomString is null”);
            }
```

