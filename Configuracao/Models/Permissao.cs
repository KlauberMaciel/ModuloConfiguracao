
using System.Collections.Generic;

namespace Models
{
    public class Permissao
    {
        public int Id { get; set; }
        public string Descrisaao { get; set; }
        public List<GrupoUsuario> Grupos { get; set; }
    }
}
