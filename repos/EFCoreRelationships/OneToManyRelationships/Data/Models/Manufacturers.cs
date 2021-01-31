using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OneToManyRelationships.Data.Models
{
    public class Manufacturers
    {
        public Manufacturers()
        {
            this.Models = new HashSet<Model>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime? EstablishedOn { get; set; }

        public virtual ICollection<Model> Models { get; set; }

    }
}
