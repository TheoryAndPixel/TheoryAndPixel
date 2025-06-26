using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TheoryAndPixel.Pages
{
public class ContactModel : PageModel
{
[BindProperty]
public ContactForm Contact { get; set; } = new ContactForm();

public void OnGet() { }

public IActionResult OnPost()
{
if (!ModelState.IsValid)
return Page();

// You can handle the form submission here.
return RedirectToPage("ThankYou"); // or stay on the same page
}
}

public class ContactForm
{
[Required]
public string Name { get; set; }

[Required, EmailAddress]
public string Email { get; set; }

[Required]
public string Message { get; set; }
}
}
