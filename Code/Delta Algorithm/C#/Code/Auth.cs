/* Delta Alogrithm 
Developped by Cadity and Delta Project Team
Free use
*/

using System.Text.RegularExpressions;

namespace Delta_Algorithm
{
    public class Identification
    {
        public static string Regex(string PublicKey)
        {                
            Regex PgpReg = new Regex(@"[-]BEGIN PGP PUBLIC KEY BLOCK[-]"); // Regex PGP

            if (PublicKey == null)
            {
                return "null";
            }

            if (PgpReg.IsMatch(PublicKey))
            {
                return "success";
            }
            else
            {
                return "Syntaxic Error";
            }
        }
        public static string AleaGen()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var CharNumber = new char[128];
            var Random = new Random();

            for (int i = 0; i < CharNumber.Length; i++)
            {
                CharNumber[i] = characters[Random.Next(characters.Length)];
            }

            var randomString = new string(CharNumber);

            if (randomString == null)
            {
                throw new Exception("randomString is null");
            }

            return randomString;
        }
}

