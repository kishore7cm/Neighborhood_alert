using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neighbourhood_Alert.Models
{
    public class CrimesReported
    {
        [Key]
        public int IncidentNo { get; set; }
        public DateTime Date { get; set; }
        public string Offense { get; set; }
        public string Weapons { get; set; }
        public string Neighborhood { get; set; }
        public string Address { get; set; }
        public int TotalNumberOfSuspects { get; set; }
        public string RaceOfSuspect { get; set; }
    }
}
