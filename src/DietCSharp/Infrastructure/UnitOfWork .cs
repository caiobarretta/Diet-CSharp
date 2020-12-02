using Core.Entities.DietcSharp;
using Core.Interfaces;
using Core.Interfaces.Repository;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DietCScharpContext _ctx;
        public UnitOfWork(DietCScharpContext ctx)
        {
            _ctx = ctx;
        }

        private IDiasdaSemanaRepository diasdaSemanaRepository;
        public IDiasdaSemanaRepository DiasdaSemanaRepository
        {
            get
            {
                return diasdaSemanaRepository = diasdaSemanaRepository ?? new DiasdaSemanaRepository(_ctx);
            }
        }

        private IDietaRepository dietaRepository;
        public IDietaRepository DietaRepository
        {
            get
            {
                return dietaRepository = dietaRepository ?? new DietaRepository(_ctx);
            }
        }


        private IPerfilRepository perfilRepository;
        public IPerfilRepository PerfilRepository
        {
            get
            {
                return perfilRepository = perfilRepository ?? new PerfilRepository(_ctx);
            }
        }

        private IPorcaoDeAlimentoRepository porcaoDeAlimentoRepository;
        public IPorcaoDeAlimentoRepository PorcaoDeAlimentoRepository
        {
            get
            {
                return porcaoDeAlimentoRepository = porcaoDeAlimentoRepository ?? new PorcaoDeAlimentoRepository(_ctx);
            }
        }


        private IRefeicoesRepository refeicoesRepository;
        public IRefeicoesRepository RefeicoesRepository
        {
            get
            {
                return refeicoesRepository = refeicoesRepository ?? new RefeicoesRepository(_ctx);
            }
        }


        private IUsuarioRepository usuarioRepository;
        public IUsuarioRepository UsuarioRepository
        {
            get
            {
                return usuarioRepository = usuarioRepository ?? new UsuarioRepository(_ctx);
            }
        }


        public void Commit()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
