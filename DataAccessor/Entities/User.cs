
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessor.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Gender { get; set; }
        public bool Status { get; set; }
        public IEnumerable<Comments> Comments { get; set; }


    }
}
