using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Base
{
    public abstract class DefaultRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        public virtual void Add(TEntity entity)
        {
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                db.Add(entity);
                ctx.SaveChanges();
            }
        }

        public virtual void Delete(TEntity entity)
        {
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                db.Remove(entity);
                ctx.SaveChanges();
            }

        }

        public virtual List<TEntity> Get(int take = 0, int skip = 0)
        {
            List<TEntity> list = new List<TEntity>();
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                list = db.Take(take)
                    .Skip(skip)
                    .ToList();
            }
            return list;
        }

        public virtual TEntity Get(int id)
        {
            TEntity entity = null;
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                entity = db.Where(x => x.ID == id).FirstOrDefault();
            }
            return entity;
        }

        public virtual TEntity Get(TEntity entity)
        {
            TEntity entityReturn = null;
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                entityReturn = db.Find(entity);
            }
            return entityReturn;
        }

        public List<TEntity> Search(string search)
        {
            List<TEntity> list = new List<TEntity>();
            using (var ctx = new DietCScharpContext())
            {
                ctx.SaveChanges();
                var db = ctx.Set<TEntity>();
                list = db.Where(x => x.Nome.Contains(search) || x.Descricao.Contains(search)).ToList();
            }
            return list;
        }

        public virtual void Update(TEntity entity)
        {
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                db.Update(entity);
                ctx.SaveChanges();
            }
        }
    }
}
