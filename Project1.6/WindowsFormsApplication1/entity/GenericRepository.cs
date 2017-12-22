using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Objects;
namespace WindowsFormsApplication1.entity
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private ObjectContext _context;

        private IObjectSet<T> _objectSet;

        public GenericRepository(ObjectContext context)
        {
            _context = context;
            _objectSet = _context.CreateObjectSet<T>();
        }

        public GenericRepository()
        {
            _context = new cuahangEntities();
            _objectSet = _context.CreateObjectSet<T>();
        }
        //
        public IQueryable<T> GetQuery()
        {
            return _objectSet;
        }
        //
        public IEnumerable<T> GetAll()
        {
            return GetQuery().AsEnumerable();
        }
        //
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.Where<T>(predicate);
        }
        /*
        public T Single(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.Single<T>(predicate);
        }
         */ 
        //
        public T First(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.First<T>(predicate);
        }
        /*
        public bool Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
                _objectSet.Attach(entity);
                _objectSet.DeleteObject(entity);
                _context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Deleted);
                try
                {
                    SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                //finally
                //{
                //    Dispose();
                //}
        }
         */
        //
        public bool Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
                _objectSet.AddObject(entity);
                _context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                try
                {
                    SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                //finally
                //{
                //    Dispose();
                //}
        }
        /*
        public bool Attach(T entity)
        {
            _objectSet.Attach(entity);
            _context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
            try
            {
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            //finally
            //{
            //    Dispose();
            //}
        }
         */
        //
        public bool Update(T entity)
        {
            _context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
            try
            {
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            //finally
            //{
            //    Dispose();
            //}
        }
        //
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

         public void Dispose()
         {
             Dispose(true);
             GC.SuppressFinalize(this);
         }
        
         protected virtual void Dispose(bool disposing)
         {
             if (disposing)
             {
                 if (_context != null)
                 {
                     _context.Dispose();
                     _context = null;
                 }
             }
         }
         
    }
}
