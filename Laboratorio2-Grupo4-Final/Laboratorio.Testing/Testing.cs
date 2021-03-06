﻿using System;
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

            Console.WriteLine(testPerson.FullName);
        }

        [TestMethod]
        public void TestAgeInYears()
        {
            Employee testEmployee = new Employee();
            testEmployee.BirthDate = Convert.ToDateTime("1996-06-22");
       

            Console.WriteLine(testEmployee.AgeInYears);
        }


        [TestMethod]
        public void TestingFetchingAllPersonWithMatInTheirFullNmae()
        {
            var repositorio = new Laboratorio.BusinessLogic.Repositories.PersonRepository();

            int expectedResultSize = 57;

            var resultList = repositorio.GetPersonByCharacterSet("mat").ToList();
            var resultSize = resultList.Count();

            Assert.AreEqual(expectedResultSize, resultSize);
        }


        [TestMethod]
        public void TestingFetchingAllPersonWithMatInTheirPhoneNumber()
        {
            var repositorio = new Laboratorio.BusinessLogic.Repositories.PersonRepository();

            int expectedResultSize = 736;

            var resultList = repositorio.GetPhone(3).ToList();
            var resultSize = resultList.Count();

            Assert.AreEqual(expectedResultSize, resultSize);
        }



        [TestMethod]
        public void TestFullDepartmetnName()
        {
            var Tabla1 = new Laboratorio.Model.Department();
            var Tabla2 = new Laboratorio.Model.EmployeeDepartmentHistory();
            var Tabla3 = new Laboratorio.Model.Employee();

            int expectedResultSize = 57;

            var resultList = Tabla3.ActualDepartmentName.ToList();
            var resultSize = resultList.Count();

            Assert.AreEqual(expectedResultSize, resultSize);

        }
    }


        
    }
