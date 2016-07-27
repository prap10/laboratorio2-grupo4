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
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee : IEntity
    {
        
        [NotMapped]
        public int Id { get; set; }


    }

    public class EmployeeMetaData
    {
    }
}
