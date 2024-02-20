using System.Security.Cryptography.X509Certificates;

namespace Exo.WebApi
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}