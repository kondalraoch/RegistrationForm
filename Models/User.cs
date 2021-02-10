using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Registration
    {
        [Key]  
        public int UserId { get; set; }  
  
        [Required(ErrorMessage ="Please Enter Username..")]        
        public string UserName { get; set; }  

        [Required(ErrorMessage ="Please Enter Age..")]          
        public int Age{get;set;}
        [Required(ErrorMessage ="Please Enter PhoneNumber..")]       
        public string PhoneNumber {get;set;}
         [Required(ErrorMessage ="Please Enter Email..")]  
        public string EmailId{get;set;}

    }
   
}