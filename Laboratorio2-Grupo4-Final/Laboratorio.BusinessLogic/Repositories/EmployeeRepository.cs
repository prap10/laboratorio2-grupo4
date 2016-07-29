using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository.EntityFramework;
using Laboratorio.Model;

namespace Laboratorio.BusinessLogic.Repositories
{
    class EmployeeRepository
    {

        private static AdventureWorks2014Entities _myContext = new AdventureWorks2014Entities();

        private IEntityRepository<Employee> _myEmployeeRepository = new EntityRepository<Employee>( _myContext );

        /*public IQueryable<Employee> GetEmployeeByCharacterSet( String characterSet )
        {
            return _myEmployeeRepository.FindBy( x => x.B );
        }*/

    }

}
