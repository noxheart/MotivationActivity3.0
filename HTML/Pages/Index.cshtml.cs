using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MotivationLibrary;
using MotivationProgram;
using System.Data.SqlClient;

namespace HTML.Pages
{
    public class IndexModel : PageModel
    {
        public string[] Button {get; set;}
        public void OnGet()
        {
            Button = new string[] {
            "Registrera träning", "Statistik", "Grupp", "Profil", "Logga ut",
            };
        }
    }
}
