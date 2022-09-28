namespace palindromo.Domain
{
    public class Palindromo
    {
        public bool VerificaPalindromo(string entrada)
        {
            var charsToRemove = new string[] { "@", ",", ".", ";", "-", " ", "'", ":" };
            foreach (var c in charsToRemove)
            {
                entrada = entrada.Replace(c, string.Empty);
            }
            return entrada.ToLower().SequenceEqual(entrada.ToLower().Reverse());
        }
    }
}