using Core.Entities.DietcSharp;
using Infrastructure.Repository;
using Core.Interfaces.Service;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Services
{
    public class PerfilService : DefaultService<Perfil>, IPerfilService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PerfilService(IUnitOfWork unitOfWork) : base(unitOfWork.PerfilRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
