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
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department : IEntity
    {

        [NotMapped]
        public int Id { get; set; }


        public string DepartmentName
        {
            get
            {
                string resultado = null;
                string Departamento = this.Name;
                resultado = Departamento;

                return resultado;
            }//get

        }
    }



    public class DepartmentMetaData
    {

    }
}
