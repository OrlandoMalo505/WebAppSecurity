using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using WebAppSecurity.Models;

namespace WebAppSecurity.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
      
        public Credential Credential { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
