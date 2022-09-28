using palindromo.Domain;

namespace palindromo.Tests
{
    public class PalindromoUnitTests
    {
        [Theory]
        [InlineData("ama")]
        [InlineData("1221")]
        public void VerificaPalindromo_PalavraPalindromaMinusculas_ReturnsTrue(string dadoTeste)
        {

            var sut = new Palindromo();

            var result = sut.VerificaPalindromo(dadoTeste);

            Assert.True(result);

        }

        [Theory]
        [InlineData("Ama")]
        [InlineData("Hanah")]
        public void VerificaPalindromo_PalavraPalindromaCaseSensitive_ReturnsTrue(string dadoTeste)
        {

            var sut = new Palindromo();

            var result = sut.VerificaPalindromo(dadoTeste);

            Assert.True(result);

        }

        [Fact]
        public void VerificaPalindromo_PalavraNaoPalindroma_ReturnsFalse()
        {

            var sut = new Palindromo();

            var result = sut.VerificaPalindromo("teste");

            Assert.False(result);

        }

        [Theory]
        [InlineData("A cara rajada da jararaca")]
        [InlineData("O trote torto")]
        [InlineData("Laço bacana para panaca boçal")]
        public void VerificaPalindromo_FrasePalindromaSemCaracteres_ReturnsTrue(string dadoTeste)
        {

            var sut = new Palindromo();

            var result = sut.VerificaPalindromo(dadoTeste);

            Assert.True(result);

        }

        [Theory]
        [InlineData("Ai, Lima falou: 'Ola, familia'")]
        [InlineData("Ajudem Edu, ja")]
        [InlineData("Socorram-me, subi no onibus em Marrocos")]
        public void VerificaPalindromo_FrasePalindromaComCaracteres_ReturnsTrue(string dadoTeste)
        {

            var sut = new Palindromo();

            var result = sut.VerificaPalindromo(dadoTeste);

            Assert.True(result);

        }
    }
}