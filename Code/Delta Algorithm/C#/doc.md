# Documentation of Delta Algorithm for C# Developper

## Table of Content

* [Auth Methods](#auth-methods)
  * [Regex](#regex)

### Auth Methods

#### Regex

```C#
public class Identification
{
	 public static string Regex(string PublicKey)
}
```
Input : Public PGP key (RFC 4080 format)
Output : 
 - "null" : Publickey was not detected -> string is empty
 - "success" : Publickey have had a positive result to Regex test
 - "Syntaxic Error" : Publickey have had a negetive result to Regex test

