using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo.Model;
using GenericRepository.EntityFramework;

namespace Ejemplo.BL.Repositorios
{
    public class ProductRepository
    {
        // contexto estático
        private static AdventureWorks2014Entities _myContext = new AdventureWorks2014Entities();
        
        // repositorio privado
        private IEntityRepository<Product> _myProductRepository = new EntityRepository<Product>(_myContext);

        public IQueryable <Product> GetAllByColor (string colorName)
        {
            return _myProductRepository.FindBy(x => x.Color == colorName);
        }

        public IQueryable<Product> GetAllProducts()
        {
            return _myProductRepository.GetAll();
        }

    }
}
