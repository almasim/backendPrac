using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace coworker.Models
{
    public partial class Notebook
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int CoworkerId { get; set; }
        [JsonIgnore]
        public virtual Coworker Coworker { get; set; }
    }
}
