using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string? Input { get; set; }
        public List<string>? Messages { get; set; }

        public void OnPost()
        {
            Messages = [];
            ProcessInput(Input, Messages);
        }

        private void ProcessInput(string? input, List<string> messages)
        {
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int number))
            {
                messages.Add("Invalid Item");
                return;
            }

            if (number % 3 == 0 && number % 5 == 0) {
                FizzBuzz(messages);
                return;
            }

            if (number % 3 == 0 || number % 5 == 0) {
                if (number % 3 == 0) {
                    Fizz(messages);
                    return;
                }
                else {
                    Buzz(messages);
                    return;
                }
            }

            messages.Add($"Divided {number} by 3 ");
            messages.Add($"Divided {number} by 5 ");
        }

        private void Fizz(List<string> messages)
        {
            messages.Add("Fizz");
        }

        private void Buzz(List<string> messages)
        {
            messages.Add("Buzz");
        }

        private void FizzBuzz(List<string> messages)
        {
            messages.Add("FizzBuzz");
        }
    }
}

