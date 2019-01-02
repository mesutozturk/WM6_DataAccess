﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuzey.DAL;

namespace Kuzey.BLL.Repository
{
    public abstract class RepositoryBase<T, TId> where T : class
    {
        protected static MyContext db;

        protected RepositoryBase()
        {
            db = db ?? new MyContext();
        }

        public virtual List<T> GetAll()
        {
            try
            {
                return db.Set<T>().ToList();
            }
            catch
            {
                throw;
            }
        }

        public virtual T GetById(TId id)
        {
            try
            {
                return db.Set<T>().Find(id);
            }
            catch
            {
                throw;
            }
        }

        public virtual int Insert(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public virtual int Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public virtual int Update()
        {
            try
            {
                return db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}