﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionAppService.Entities;

namespace TransactionAppService.Repo
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
