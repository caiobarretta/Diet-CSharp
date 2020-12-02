using Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCSharpForm.Interfaces.Componente.Base
{
    public interface IDefaultService<TEntity> where TEntity : Entity
    {
        void ConfigureGridSearch(DataGridView dataGridView, ICollection<TEntity> entities);
    }
}
