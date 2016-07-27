using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository;

namespace Laboratorio.Model.Tablas
{
    [MetadataType(typeof(PersonPhoneMetaData))]
    public partial class PersonPhone : IEntity
    {
        [NotMapped]
        public int Id { get; set; }

    }

    public class PersonPhoneMetaData
    {

    }
}
