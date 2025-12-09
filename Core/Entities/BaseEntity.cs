using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class BaseEntity<T> : IEntity
    {
        [Key]
        public virtual T Id { get; set; }
        [Required]
        public virtual T CreatedUserId { get; set; }
        [Required]
        public virtual DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public virtual T LastUpdatedUserId { get; set; }
        public virtual DateTime? LastUpdatedDate { get; set; }
        [Required]
        public virtual bool Status { get; set; } = true;
        [Required]
        public virtual bool IsDeleted { get; set; } = false;
    }
    public class BaseEntity : BaseEntity<int> { }
}
