using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Durlston_CV.Models
{
    public class Candidate
    {
        [Key]
        public int CandidateID { get; set; }

        [Required]
        [Display(Name = "First Name"), StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name"), StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Display(Name = "Mobile Number"), StringLength(50, MinimumLength = 1)]
        public string MobileNumber { get; set; }

        [Display(Name = "Home Number"), StringLength(50, MinimumLength = 1)]
        public string AlterNumber { get; set; }

        [Range(0, 52)]
        public System.Nullable<int> WeeksNotice { get; set; }

        [Range(0, 10)]
        public System.Nullable<int> Rating { get; set; }

        [Display(Name = "Current Company"), StringLength(50, MinimumLength = 0)]
        public string CurrentCompany { get; set; }

        [Display(Name = "Current Salary"), StringLength(50, MinimumLength = 0)]
        public string Current_Salary { get; set; }

        [Display(Name = "Desired Salary"), StringLength(50, MinimumLength = 0)]
        public string Desired_Salary { get; set; }

        [Display(Name = "Profile"), StringLength(20000, MinimumLength = 0)]
        public string Profile { get; set; }

        [Display(Name = "CV"), StringLength(400, MinimumLength = 0)]
        public string CV { get; set; }


        [Display(Name = "Profile/Summary"), StringLength(2000, MinimumLength = 0)]
        public string Summary { get; set; }


        [Display(Name = "Role"), StringLength(100, MinimumLength = 0)]
        public string Role { get; set; }

        [Display(Name = "Experience"), StringLength(2000, MinimumLength = 0)]
        public string Experience { get; set; }

        [Display(Name = "Education"), StringLength(1000, MinimumLength = 0)]
        public string Education { get; set; }

        [Display(Name = "Tech Stack"), StringLength(1000, MinimumLength = 0)]
        public string Tech { get; set; }

        [Display(Name = "University"), StringLength(1000, MinimumLength = 0)]
        public string University { get; set; }

        [Display(Name = "Notes"), StringLength(2000, MinimumLength = 0)]
        public string Notes { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [Display(Name = "Last Contact")]
        public Nullable<DateTime> LastContact { get; set; }

        [ForeignKey("User")]
        [Required(ErrorMessage = "A name is required")]
        public int UserID { get; set; }

    }
}