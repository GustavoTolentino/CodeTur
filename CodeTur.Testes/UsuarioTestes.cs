using CodeTur.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTur.Testes
{
    public class UsuarioTestes
    {
        [Fact]
        public void DeveRetornarSeUsuarioForValido()
        {
            Usuario user = new Usuario(
                "Gustavo",
                "tolentinogustavo@gmail.com",
                "123456789",
                EnTipoUsuario.Admin
                );

            Assert.True(user.IsValid, "Valid User");
        }
    }
}
