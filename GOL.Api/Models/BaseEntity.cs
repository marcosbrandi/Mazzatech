using System;
using System.ComponentModel.DataAnnotations;

namespace GOL.Api.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual Guid Id { get; set; }
    }
}
