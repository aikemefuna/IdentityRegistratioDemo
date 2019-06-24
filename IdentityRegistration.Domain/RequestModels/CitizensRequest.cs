using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityRegistrationDemo.Domain.RequestModels
{
    public class CitizensRequest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "First Name Should be between 2 and 30 characters. Please check again")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Middle Name Should be between 2 and 30 characters. Please check again")]
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Last Name Should be between 2 and 30 characters. Please check again")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("State of Origin")]
        public string StateOfOrigin { get; set; }

        [Required]
        [DisplayName("Local Government Area")]
        public string LGA { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("D.O.B")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Contact address should not be less than 10 and more than 200 characters")]
        [DisplayName("Contact Address")]
        public string ContactAddress { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Reference Name Should be between 2 and 40 characters. Please check again")]
        [DisplayName("Referee Name ")]
        public string ReferenceName { get; set; }


        [Required]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Reference address should not be less than 10 and more than 200 characters")]
        public string ReferenceAddress { get; set; }

        [Required]
        public string ReferencePhoneNumber { get; set; }

        [Required]
        public string Occupation { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "Mothers Maiden Name Should not be greater than 40 characters.")]
        public string MotherMaidenName { get; set; }

        [Required]
        public long BVN { get; set; }
        public string NIN  { get; set; }
    }
}
