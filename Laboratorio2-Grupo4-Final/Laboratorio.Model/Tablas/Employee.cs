using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using GenericRepository;


namespace Laboratorio.Model
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee : IEntity
    {

        [NotMapped]
        public int Id { get; set; }

        public int AgeInYears
        {
            get
            {
                int resultado;
                DateTime date1 = new DateTime();
                date1 = this.BirthDate;
                if (date1 != null)
                {
                    int yearTabla = date1.Year;

                    System.DateTime moment = new System.DateTime();
                    int year = moment.Year;

                    resultado = year - yearTabla;
                }
                else
                {
                    // no se pudo realizar la operacion(debido a que date1 no existe en la DB)
                    resultado = 0;
                }
                return (resultado);
            }//Get

        }//MetodoAgeInYears

        public int AdditionalMonths
        {
            get
            {
                int resultado = 0;

                DateTime date1 = new DateTime();
                date1 = this.BirthDate;
                if (date1 != null)
                {
                    int monthTabla = date1.Month;
                    System.DateTime moment = new System.DateTime();

                    int month = moment.Month;
                    int resultado1 = monthTabla - month;
                    resultado = Math.Abs(resultado1);

                }
                else
                {
                    // no se pudo realizar la operacion(debido a que date1 no existe en la DB)
                    resultado = 0;
                }
                return (resultado);
            }//Get

        }//MetodoAgeInYears

        public string MaritalStatusName
        {
            get
            {
                string resultado = null;
                string estadoCivil = this.MaritalStatus;
                if (estadoCivil == "S")
                {
                    resultado = "Single";
                }
                else
                {
                    resultado = "Married";
                }
                return resultado;
            }//get
        }//MetodoMaritalStatusName

        public string GenderName
        {
            get
            {
                string resultado = null;
                string genero = this.Gender;
                if (genero == "M")
                {
                    resultado = "Male";
                }
                else
                {
                    resultado = "Female";
                }
                return resultado;
            }//get
        }//MetodoGenderName

        public string Antiquity
        {
            get
            {
                int resultado;
                DateTime date1 = new DateTime();
                date1 = this.HireDate;
                if (date1 != null)
                {
                    int yearTabla = date1.Year;

                    System.DateTime moment = new System.DateTime();
                    int year = moment.Year;

                    resultado = year - yearTabla;
                }
                else
                {
                    // no se pudo realizar la operacion(debido a que date1 no existe en la DB)
                    resultado = 0;
                }
                return (Convert.ToString(resultado));
            }//Get
        }//MetodoAntiquity

        public int AdditionalAntitiquityMonths
        {
            get
            {
                int resultado = 0;

                DateTime date1 = new DateTime();
                date1 = this.HireDate;
                if (date1 != null)
                {
                    int monthTabla = date1.Month;
                    System.DateTime moment = new System.DateTime();

                    int month = moment.Month;
                    int resultado1 = monthTabla - month;
                    resultado = Math.Abs(resultado1);
                }
                return (resultado);
            }//Get

        }//MetodoAdditionalAntitiquityMonths

        /*
        public string ActualDepartmentName
        {
            get
            {
                var e = new Employee();
                var edh = new EmployeeDepartmentHistory();
                var d = new Department();

                var groupJoinQuery =
                        from Employee in e
                        join EmployeeDepartmentHistory in edh on e.BusinessEntityID equals edh.BusinessEntityID
                        join Department in d on d.DepartmentID equals edh.DepartmentID into result
                        select result;

            }//Get
        }//MetodoActualDepartmentName*/
        
        public string ActualDepartmentName
            {
            get
    {
                EmployeeDepartmentHistory DN = new EmployeeDepartmentHistory();
                Department ED = new Department();
                Employee e = new Employee();


                int IDDepa = DN.DepartmentoID;
                String NombreDepa = ED.DepartmentName;
                int BID = e.BusinessEntityID;

                string name = (IDDepa.Equals( BID)).ToString();

                return name;
    }//Get
}//MetodoActualDepartmentName
    }

    public class EmployeeMetaData
    {

    }
}
