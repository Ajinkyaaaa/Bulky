using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository  //Think of an interface like a contract or a promise. When you have an interface, you're saying, "Hey, any class that wants to use me (the interface) must promise to have certain abilities."
{
    public interface ICategoryRepository : IRepository<Category> //An interface is like a contract that specifies a set of methods that a class implementing the interface must provide.
    {
        void Update(Category obj);
        void Save();
    }
}
