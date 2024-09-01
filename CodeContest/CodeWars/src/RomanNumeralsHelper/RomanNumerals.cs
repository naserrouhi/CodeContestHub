namespace RomanNumeralsHelper;

public class RomanNumerals
{
    private static Dictionary<string, int> _romanNumerals = new Dictionary<string, int>
    {
        { "M", 1000 },
        { "CM", 900 },
        { "D", 500 },
        { "CD", 400 },
        { "C", 100 },
        { "XC", 90 },
        { "L", 50 },
        { "XL", 40 },
        { "X", 10 },
        { "IX", 9 },
        { "V", 5 },
        { "IV", 4 },
        { "I", 1 }
    };

    public static string ToRoman(int n)
    {
        var romanString = string.Empty;
        var numbers = _romanNumerals.Select(rn => rn.Value);

        foreach (var number in numbers)
        {
            var divisionResult = n / number;
            var romanSymbol = _romanNumerals.First(r => r.Value == number).Key;

            for (var i = 1; i <= divisionResult; i++)
                romanString += romanSymbol;

            n %= number;
        }

        return romanString;
    }

    public static int FromRoman(string romanNumeral)
    {
        var decimalNumber = 0;

        for (var i = 0; i < romanNumeral.Length; i++)
        {
            if (i == romanNumeral.Length - 1)
            {
                var oneCharacter = romanNumeral[i].ToString();

                decimalNumber += _romanNumerals[oneCharacter];

                break;
            }

            var twoCharacter = romanNumeral.Substring(i, 2);

            if (_romanNumerals.Keys.Contains(twoCharacter))
            {
                decimalNumber += _romanNumerals[twoCharacter];

                i += 1;
            }
            else
            {
                var oneCharacter = twoCharacter[0].ToString();

                decimalNumber += _romanNumerals[oneCharacter];
            }
        }

        return decimalNumber;
    }
}