using System;

namespace HowToSpecflow.Models
{
    internal class Agent
    {
        public string Name { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public decimal? Salary { get; set; }
        public bool? IsActive { get; set; }
    }
}
