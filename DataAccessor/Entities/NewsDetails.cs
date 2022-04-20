    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessor.Entities
{
    [Table("NewsDetails")]
    public class NewsDetails: BaseEntity
    {
        public string NewsID { get; set; }
        public News News { get; set; }
        public string TypeID { get; set; }
        public Type NewsType { get; set; }
    }
}
