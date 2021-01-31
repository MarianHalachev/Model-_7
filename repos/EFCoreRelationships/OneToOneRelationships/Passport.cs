namespace OneToOneRelationships
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Passport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

        public virtual Person Person { get; set; }
    }
}
