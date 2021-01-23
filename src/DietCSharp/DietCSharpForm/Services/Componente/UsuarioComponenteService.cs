using Core.Entities.DietcSharp;
using DietCSharpForm.Interfaces.Componente;
using DietCSharpForm.Services.Componente.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCSharpForm.Services.Componente
{
    public class UsuarioComponenteService : DefaultComponenteService<Usuario>, IUsuarioService
    {
        public override void ConfigureGridSearch(DataGridView dataGridView, ICollection<Usuario> entities)
        {
            entities.Where(x => x.ID_Perfil != 1);
            base.ConfigureGridSearch(dataGridView, entities);
        }
    }
}
