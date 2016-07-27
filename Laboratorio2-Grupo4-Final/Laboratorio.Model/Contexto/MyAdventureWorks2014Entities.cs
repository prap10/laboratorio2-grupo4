using GenericRepository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Model
{
    public partial class MyAdventureWorks2014Entities : EntitiesContext
    {
        public virtual IDbSet<Employee> Employee { get; set; }
        public virtual IDbSet<Department> Department { get; set; }
        public virtual IDbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual IDbSet<Person> Person { get; set; }
        public virtual IDbSet<PersonPhone> PersonPhone { get; set; }
    }
}
