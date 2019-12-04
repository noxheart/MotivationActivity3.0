using Microsoft.AspNetCore.Mvc.RazorPages;

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
