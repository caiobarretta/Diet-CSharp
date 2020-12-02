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
    public class DietaService : DefaultService<Dietum>, IDietaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DietaService(IUnitOfWork unitOfWork) : base(unitOfWork.DietaRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
