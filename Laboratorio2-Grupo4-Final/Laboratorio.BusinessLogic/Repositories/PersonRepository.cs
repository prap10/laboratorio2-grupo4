﻿using Laboratorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository.EntityFramework;


namespace Laboratorio.BusinessLogic.Repositories
{
    public class PersonRepository
    {
        private static AdventureWorks2014Entities _myContext = new AdventureWorks2014Entities();

        private IEntityRepository<Person> _myPersonRepository = new EntityRepository<Person>(_myContext);

        public IQueryable<Person> GetPersonByCharacterSet( String characterSet )
        {
            return _myPersonRepository.FindBy(x => x.FullName.Contains( characterSet ));
        }

        public IQueryable<Person> GetPhone(int phoneSet)
        {
            return _myPersonRepository.FindBy(x => x.PersonPhone.ToString().Contains(phoneSet.ToString()));
        }
    }
}
