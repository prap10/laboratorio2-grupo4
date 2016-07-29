using System;
using Laboratorio.Model;
using Laboratorio.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Laboratorio.Testing
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void TestFullNameWithOnlyFirstNameAndLastName()
        {
            Person testPerson = new Person();
            testPerson.FirstName = "Pablo";
            testPerson.LastName = "Arroyo";

            Console.WriteLine( testPerson.FullName );
        }

        [TestMethod]
        public void TestingFetchingAllPersonWithMatInTheirFullNmae()
        {
            var repositorio = new Laboratorio.BusinessLogic.Repositories.PersonRepository();

            int expectedResultSize = 57;

            var resultList = repositorio.GetPersonByCharacterSet( "mat" ).ToList();
            var resultSize = resultList.Count();

            Assert.AreEqual(expectedResultSize, resultSize);
        }

    }
}
