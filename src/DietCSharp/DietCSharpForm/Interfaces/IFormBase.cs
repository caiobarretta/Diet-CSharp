using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCSharpForm.Base
{
    public interface IFormBase<TEntity> where TEntity : Entity
    {
        IService<TEntity> _service { get; }
        CriarEditarService<TEntity> criarEditarService { get; }
        TipoDeOperacao TipoDeOperacao { get; }
        int Id { get; set; }
        IFormBase<TEntity> BuildServices(TipoDeOperacao tipoDeOperacao);
        Form GetForm();
    }
}
