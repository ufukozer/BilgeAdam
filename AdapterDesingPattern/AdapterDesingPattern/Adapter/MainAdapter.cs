
using System.Collections.Generic;
using System.Linq;

using AdapterDesingPattern.Interface;

namespace AdapterDesingPattern.Adapter
{
    public class MainAdapter : ICrud
    {
        public void Delete<T>(int id) where T : class
        {
            T model = Find<T>(id);
            using (AdapterDesingPatternContext adapterDesingPatternContext = new AdapterDesingPatternContext())
            {
                adapterDesingPatternContext.Set<T>().Remove(model);
                adapterDesingPatternContext.SaveChanges();
            }
        }

        public T Find<T>(int id) where T : class
        {
            T main;
            using (AdapterDesingPatternContext adapterDesingPatternContext = new AdapterDesingPatternContext())
            {
                main = adapterDesingPatternContext.Set<T>().Find(id);
            }
            return main;
        }

        public IQueryable<T> Get<T>() where T : class
        {
            IQueryable<T> models;
            using (AdapterDesingPatternContext adapterDesingPatternContext = new AdapterDesingPatternContext())
            {
                models = adapterDesingPatternContext.Set<T>();
            }
            return models;
        }

        public T Insert<T>(T model) where T : class
        {
            using (AdapterDesingPatternContext adapterDesingPatternContext = new AdapterDesingPatternContext())
            {
                adapterDesingPatternContext.Set<T>().Add(model);
                adapterDesingPatternContext.SaveChanges();
            }
            return model;
        }

        public T Update<T>(T model) where T : class
        {
            using (AdapterDesingPatternContext adapterDesingPatternContext = new AdapterDesingPatternContext())
            {
                adapterDesingPatternContext.Set<T>().Update(model);
                adapterDesingPatternContext.SaveChanges();
            }
            return model;
        }
    }
}
