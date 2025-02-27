﻿using Core.Entities.Base;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CriarEditarService<TEntity> where TEntity : Entity
    {
        private readonly IService<TEntity> _service;
        private readonly TipoDeOperacao _tipoDeOperacao;
        public CriarEditarService(IService<TEntity> service, TipoDeOperacao tipoDeOperacao)
        {
            this._service = service;
            this._tipoDeOperacao = tipoDeOperacao;
        }

        public virtual bool Executar(TEntity entity, out string mensagem)
        {
            var service = _service;
            mensagem = string.Empty;
            if (_tipoDeOperacao == TipoDeOperacao.Criar)
            {
                service.Add(entity);
                mensagem = "Dados Criados Com Sucesso";
                return true;
            }
            else if (_tipoDeOperacao == TipoDeOperacao.Editar)
            {
                service.Update(entity);
                mensagem = $"Dados de {entity.Nome} Alterados Com Sucesso";
                return true;
            }
            else
                throw new NotImplementedException("Tipo de operação não implementada.");
        }

        public virtual bool LoadEntity(ref TEntity entity, int id)
        {
            var service = _service;
            if (_tipoDeOperacao == TipoDeOperacao.Editar && id == 0)
                throw new AccessViolationException("Erro ao carregar dados");
            else if (_tipoDeOperacao == TipoDeOperacao.Editar && id > 0)
            {
                entity = service.Get(id);
                return true;
            }
            return false;
        }
    }
}
