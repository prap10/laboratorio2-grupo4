using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository;

namespace Laboratorio.Model
{
    [MetadataType(typeof(EmployeeDepartmentHistoryMetaData))]
    public partial class EmployeeDepartmentHistory : IEntity
    {

        [NotMapped]
        public int Id { get; set; }


        public int DepartmentoID
        {
            get
            {
                int resultado;
                int DepaID = this.DepartmentID;
                resultado = DepaID;

                return resultado;
            }//get

        }
    }



    public class EmployeeDepartmentHistoryMetaData
    {

    }
}

