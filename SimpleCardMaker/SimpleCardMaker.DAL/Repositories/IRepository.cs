﻿using SimpleCardMaker.DAL.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCardMaker.DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        bool Exists(int id);
        Task CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
    }
}
