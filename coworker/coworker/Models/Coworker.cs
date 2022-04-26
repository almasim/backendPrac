using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace coworker.Models
{
    public partial class Coworker
    {
        public Coworker()
        {
            Notebooks = new HashSet<Notebook>();
            Phones = new HashSet<Phone>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public virtual ICollection<Notebook> Notebooks { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
