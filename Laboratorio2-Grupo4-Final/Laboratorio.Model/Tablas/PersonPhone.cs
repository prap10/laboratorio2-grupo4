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
    [MetadataType(typeof(PersonPhoneMetaData))]
    public partial class PersonPhone : IEntity
    {
        [NotMapped]
        public int Id { get; set; }

    }

    public enum PhoneNumberType
    {     
        Cell = 1,  
        Home = 2,
        Work = 3,   
    }

    public class PersonPhoneMetaData
    {

    }
}
