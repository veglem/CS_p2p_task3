using Translit;

namespace CS_module_2;

using System.Text.RegularExpressions;

public class Employee
{
    // ФИО
    // Все последующие выкрутасы сделаны, чтобы можно было хранить людей с несколькими именами/фамилиями или отсутствием отчества
    private string _firstName = "";
    private string _surname = "";
    private string? _middleName;

    public string FullName => _middleName is null
        ? $"{_surname} {_firstName}"
        : $"{_surname} {_firstName} {_middleName}";

    public string ShortName => _middleName is null
        ? $"{_surname} {_firstName[0]}."
        : $"{_surname} {_firstName[0]}. {_middleName[0]}.";

    public string FirstName
    {
        set
        {
            if (IsNameValid(value))
            {
                _firstName = value;
            }
            else
            {
                throw new ArgumentException("Unexpected FirstName");
            }
        }
        get => _firstName;
    }

    public string Surname
    {
        set
        {
            if (IsNameValid(value))
            {
                _surname = value;
            }
            else
            {
                throw new ArgumentException("Unexpected Surname");
            }
        }
        get => _surname;
    }

    public string? MiddleName
    {
        set
        {
            if (value is null || IsNameValid(value))
            {
                _middleName = value;
            }
            else
            {
                throw new ArgumentException("Unexpected MiddleName");
            }
        }
        get => _middleName;
    }

    // Имена должны начинаться с большой буквы, содержат только символы алфавита, пробелы и тире.
    private bool IsNameValid(string name)
    {
        const string pattern = @"^[A-ZА-ЯЁ][a-z а-яA-ZА-ЯЁё-]*$";
        return Regex.IsMatch(name, pattern);
    }

    // Должность
    public string Position { get; set; }

    // email
    private string _email = "";

    public string Email
    {
        set
        {
            const string pattern = @"^[a-zA-Z\.-]+@([a-zA-Z-]+\.)+[a-zA-Z-]{2,4}$";
            if (Regex.IsMatch(value, pattern, RegexOptions.CultureInvariant))
            {
                _email = value;
            }
            else
            {
                throw new ArgumentException("Unexpected Email");
            }
        }
        get => _email;
    }

    // Телефон
    private string _phoneNum = "";

    public string Phone
    {
        set
        {
            const string pattern = @"^(([+][7])|[8])[- ]?[\d]{3}[- ]?[\d]{3}[- ]?[\d]{2}[- ]?[\d]{2}$";
            if (Regex.IsMatch(value, pattern))
            {
                _phoneNum = value;
            }
            else
            {
                throw new ArgumentException("Unexpected Phone");
            }
        }
        get => _phoneNum;
    }

    public uint Salary { get; set; }

    public byte Age { get; set; }

    public Employee(string firstName, string surname, string? middleName, string position, string? email,
        string phoneNumber, uint salary, byte age)
    {
        FirstName = firstName;
        Surname = surname;
        MiddleName = middleName;
        Position = position;
        if (email is null)
        {
            var translator = new TranslitMethods.Translitter();
            // тут я лишний раз прогоняю через транслит, тк добавлять тут проверку на присутствие кириллицы смысла осбо нет
            // если в строке её нет - она не поменяется, а по времени выйдет так же как и обычная проверка фором или регексом.
            Email = translator.Translit(surname.Replace(" ", "") + FirstName[0] +
                                        (MiddleName is null ? "" : $"{MiddleName[0]}"),
                        TranslitMethods.TranslitType.Iso)
                    + "@company.ru";
        }
        else
        {
            Email = email;
        }

        Phone = phoneNumber;
        Salary = salary;
        Age = age;
    }

    public string Report()
    {
        return $"Name: {ShortName}\n" +
               $"Position: {Position}\n" +
               $"Email: {Email}\n" +
               $"Phone: {Phone}\n" +
               $"Salary: {Salary} р.\n" +
               $"Age: {Age}";
    }
}
