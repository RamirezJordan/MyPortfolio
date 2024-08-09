using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactFormModel ContactForm { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Lógica para manejar el formulario de contacto (por ejemplo, enviar un correo electrónico)
                TempData["SuccessMessage"] = "Tu mensaje ha sido enviado exitosamente!";
                return RedirectToPage();
            }

            return Page();
        }
    }

    public class ContactFormModel
    {
        [Required]
        [Display(Name = "Nombre Completo de la Empresa")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Nombre y Cargo del Contacto")]
        public string ContactName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Dirección de Correo Electrónico")]
        public string Email { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Número de Teléfono")]
        public string Phone { get; set; }

        [Display(Name = "Mensaje o Comentario Adicional")]
        public string Message { get; set; }
    }
}
