using System.ComponentModel.DataAnnotations;

namespace MarriageRegistrationApp.Models
{
    public class Marriage
    {
        public int Id { get; set; }

        public required string PartnerOne { get; set; }

        public required string PartnerTwo { get; set; }

        [Required]
        public DateTime MarriageDate { get; set; }

        public required string Status { get; set; }
    }

}
