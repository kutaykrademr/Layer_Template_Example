using Core_Layer.DataAccess;
using Core_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.MongoDB
{
    public class MongoEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : IEntity, new()
    where TContext : DbContext, new()
    {
        private readonly IMongoCollection<TEntity> _collection;

        public MongoEntityRepositoryBase(IMongoDatabase database)
        {
            _collection = database.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _collection.Find(_ => true).FirstOrDefault()
                : _collection.Find(filter).FirstOrDefault();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _collection.Find(_ => true).ToList()
                : _collection.Find(filter).ToList();
        }

        public void Add(TEntity entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(TEntity entity)
        {
            _collection.ReplaceOne(e => e.Id == entity.Id, entity);
        }

        public void Delete(TEntity entity)
        {
            _collection.DeleteOne(e => e.Id == entity.Id);
        }
    }
}
