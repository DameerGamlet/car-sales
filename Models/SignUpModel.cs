using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

public class SignUpModel : PageModel {
  [BindProperty]
  public string? Name { get; set; }

  [BindProperty]
  public string? Email {
    get; set;
  }

  [BindProperty]
  public string? Password {
    get; set;
  }

  [BindProperty]
  public string? ConfirmPassword {
    get; set;
  }

  private readonly ILogger<SignUpModel> log;
  private readonly IModelExpressionProvider _modelExpressionProvider;
  private readonly IAccounts accounts;

  public SignUpModel(ILogger<SignUpModel> logger,
                     IModelExpressionProvider modelExpressionProvider,
                     IAccounts accounts) {
    log = logger;
    _modelExpressionProvider = modelExpressionProvider;
    this.accounts = accounts;
  }

  public void OnPost() {
    string? name = Request.Form["Name"];
    string? email = Request.Form["Email"];
    string? password = Request.Form["Password"];
    string? confirmPassword = Request.Form["ConfirmPassword"];

    bool isPasswordsMatch = string.Equals(password, confirmPassword);

    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) &&
        !string.IsNullOrEmpty(password) &&
        !string.IsNullOrEmpty(confirmPassword)) {
      log.LogInformation("Входные данные:" + "Name: " + (name ?? "null") +
                         ", Email: " + (email ?? "null") +
                         ", Password: " + (password ?? "null") +
                         ", Confirm Password: " + (confirmPassword ?? "null"));

      Console.WriteLine();

      if (isPasswordsMatch) {
        if (accounts.IsEmailUnique(email)) {
          Account account =
              new Account { Name = name, Email = email, Password = password };

          accounts.AddAccount(account);

          log.LogInformation(
              "Пользователь с именем '{name}' и почтовым адресом '{email}' зарегистрирован!",
              name, email);

          RedirectToPage("/Login");
        } else {
          log.LogWarning("Пользователь с email: '{email}' уже имеется", email);
        }
      } else {
        log.LogWarning("Пароли не совпадают. Доступ запрещен!");
        ViewData["ErrorMessage"] = "Пароли не совпадают. Доступ запрещен!";
      }
    }
  }
}