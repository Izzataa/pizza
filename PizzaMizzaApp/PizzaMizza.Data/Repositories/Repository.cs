using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaMizza.Core.Models.Base;

namespace PizzaMizza.Data.Repositories
{
    public class Repository<T> where T : BaseModel
    {
        private readonly List<T> _items = new List<T>();

        public async Task Createasync(T model)
        {
            _items.Add(model);
        }
        public async Task Deleteasync(T model)
        {
            _items.Remove(model);
        }

        public async Task <T> Getasync (Func<T, bool> func)
        {
            return _items.FirstOrDefault(func);
        }


        public async Task <List<T>> GetALlasync()
        {
            return _items;
        }
    }
}
    
