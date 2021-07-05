using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Movies.Models;

namespace Movies.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity:IEntity,new()//tentity buraya böyle bir tip gelecek -- new instance alınabilir olacak

    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        IList<TEntity> GetWithCriteria(Expression<Func<TEntity, bool>> criteria);
        TEntity Add(IEntity entity);



    }
}
