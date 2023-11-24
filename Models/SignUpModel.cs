using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using System;
using System.Linq.Expressions;
using System.Web.WebPages;

public class SignUpModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }

    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public string Password { get; set; }

    [BindProperty]
    public string ConfirmPassword { get; set; }

    private readonly ILogger<SignUpModel> _logger;
    private readonly IModelExpressionProvider _modelExpressionProvider;

    public SignUpModel(ILogger<SignUpModel> logger, IModelExpressionProvider modelExpressionProvider)
    {
        _logger = logger;
        _modelExpressionProvider = modelExpressionProvider;
    }

    public void OnPost()
    {
        // Получение значения из входных полей по их именам
        string? nameValue = Request.Form["Name"];
        string? emailValue = Request.Form["Email"];
        string? passwordValue = Request.Form["Password"];
        string? confirmPasswordValue = Request.Form["ConfirmPassword"];

        bool isPasswordsMatch = string.Equals(passwordValue, confirmPasswordValue);

        if (!string.IsNullOrEmpty(nameValue) && !string.IsNullOrEmpty(emailValue) && !string.IsNullOrEmpty(passwordValue) && !string.IsNullOrEmpty(confirmPasswordValue))
        {
            Console.WriteLine("Name: " + (nameValue ?? "null") + ", Email: " + (emailValue ?? "null") + ", Password: " + (passwordValue ?? "null") + ", Confirm Password: " + (confirmPasswordValue ?? "null"));

            Console.WriteLine();

            if (isPasswordsMatch)
            {
                // Пароли совпадают, выполняется регистрация

                // TODO: добавить регистрацию в БД

                Console.WriteLine("Пользователь успешно зарегистрирован!");
            }
            else
            {
                Console.WriteLine("Пароли не совпадают. Доступ запрещен!");
                ViewData["ErrorMessage"] = "Пароли не совпадают. Доступ запрещен!";
            }
        }
    }

}
