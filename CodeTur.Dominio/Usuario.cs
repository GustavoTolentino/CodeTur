using CodeTur.Comum;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Dominio
{
    public class Usuario : Base
    {
        public Usuario(string nome, string email, string senha, EnTipoUsuario tipoUsuario)
        {

            AddNotifications(
            new Contract<Notification>()
                 .Requires()
                 .IsNotEmpty(nome, "Nome", "Nome não pode ser vazio")
                 .IsEmail(email, "Email", "O formato do Email nao esta correto")
                 .IsGreaterThan(senha, 7, "Senha", "A senha deve possuir no minimo 8 caracteres")
            );

            Nome = nome;
            Email = email;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }
    }
}
