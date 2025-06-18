using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string EmailAddress { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string PhoneNumber { get; set; }
        public required string AddressFirstLine { get; set; }
        public required string AddressSecondLine { get; set; }
        public required string AddressCity { get; set; }
        public required string PostCode { get; set; }
    }
}
