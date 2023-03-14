

using System.Collections.Generic;
using System.Data.Common;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int Senha { get; set; }
        public List<GrupoUsuario> GruposUsuarios { get; set; }
    }
    
   // Usuario Usuario_()

}
