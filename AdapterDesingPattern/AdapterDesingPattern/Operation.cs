using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdapterDesingPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace AdapterDesingPattern
{
    public class Operation
    {
        private static readonly Adapter.MainAdapter mainAdapter = new Adapter.MainAdapter();
        public static void SaveMain(string name, string description)
        {
            Models.Main main = new Models.Main()
            {
                Name = name,
                Description = description

            };
            mainAdapter.Insert<Models.Main>(main);
        }
        public static void UpdateMain(int id, string name, string description)
        {
            using (AdapterDesingPatternContext adapterDesingPatternContext = new AdapterDesingPatternContext())
            {
                Models.Main main = adapterDesingPatternContext.Mains.SingleOrDefault(a => a.Id == id);

                main.Name = name;
                main.Description = description;

                adapterDesingPatternContext.Mains.Update(main);
                adapterDesingPatternContext.SaveChanges();
            }
        }
        public static void RemoveMain(int id)
        {
            mainAdapter.Delete<Models.Main>(id);
        }
    }
}
