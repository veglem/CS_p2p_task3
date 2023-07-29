using System.Text.RegularExpressions;

namespace CS_module_3;

public class Phonebook
{
    private Dictionary<string, List<string>> _dictionary = new Dictionary<string, List<string>>();
    
    public void AddNumber(string surname, string number)
    {
        if (!Regex.IsMatch(surname, @"^[A-ZА-ЯЁ][a-z а-яA-ZА-ЯЁё-]*$") ||
            !Regex.IsMatch(number, @"^(([+][7])|[8])[- ]?[\d]{3}[- ]?[\d]{3}[- ]?[\d]{2}[- ]?[\d]{2}$"))
        {
            return;
        }

        if (_dictionary.ContainsKey(surname))
        {
            if (!_dictionary[surname].Contains(number))
            {
                _dictionary[surname].Add(number);
            }
        }
        else
        {
            _dictionary.Add(surname, new List<string>(){number});
        }
    }

    public List<string> GetNumbers(string surname)
    {
        return _dictionary.TryGetValue(surname, out var numbers) ? numbers : new List<string>() { };
    }
}
