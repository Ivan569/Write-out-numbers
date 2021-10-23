using System;

class Program
{
    static void Main() => Console.WriteLine(Number2Words(int.Parse(Console.ReadLine())));

    public static string Number2Words(int n) => n.ToString().Length switch
    {
        1 => CountOnesNums(n.ToString()),
        2 => CountTwoNums(n.ToString()),
        3 => CountsThreeNums(n.ToString()),
        4 => CountFourNums(n.ToString()),
        5 => CountFiftyNums(n.ToString()),
        6 => CountSixNums(n.ToString()),
        _ => "",
    };

    static string CountSixNums(string s) => CountOnesNums(s[0].ToString()) + " hundred " + CountFiftyNums(s[1] + "" + s[2] + "" + s[3] + "" + s[4] + "" + s[5]);

    static string CountFiftyNums(string s) => s[2] + "" + s[3] + "" + s[4] == "000"
            ? CountTwoNums(s[0] + "" + s[1]) + " thousand"
            : s[2] == '0'
            ? CountTwoNums(s[0] + "" + s[1]) + " thousand " + CountTwoNums(s[3] + "" + s[4])
            : CountTwoNums(s[0] + "" + s[1]) + " thousand " + CountsThreeNums(s[2] + "" + s[3] + "" + s[4]);

    static string CountFourNums(string s) => s[1] + "" + s[2] + "" + s[3] == "000"
            ? CountOnesNums(s[0].ToString()) + " thousand"
            : s[1] + "" + s[2] == "00"
            ? CountOnesNums(s[0].ToString()) + " thousand " + CountOnesNums(s[3].ToString())
            : s[1].ToString() == "0"
            ? CountOnesNums(s[0].ToString()) + " thousand " + CountTwoNums(s[2] + "" + s[3])
            : CountOnesNums(s[0].ToString()) + " thousand " + CountsThreeNums(s[1] + "" + s[2] + "" + s[3]);

    static string CountsThreeNums(string s) => s[1] + "" + s[2] == "00"
            ? CountOnesNums(s[0].ToString()) + " hundred"
            : s[1].ToString() == "0"
            ? CountOnesNums(s[0].ToString()) + " hundred " + CountOnesNums(s[2].ToString())
            : CountOnesNums(s[0].ToString()) + " hundred " + CountTwoNums(s[1] + "" + s[2]);

    static string CountOnesNums(string s) => s switch
    {
        "0" => "zero",
        "1" => "one",
        "2" => "two",
        "3" => "three",
        "4" => "four",
        "5" => "five",
        "6" => "six",
        "7" => "seven",
        "8" => "eight",
        "9" => "nine",
        _ => "",
    };

    static string CountTwoNums(string s)
    {
        return s switch
        {
            "10" => "ten",
            "11" => "eleven",
            "12" => "twelve",
            "13" => "thirteen",
            _ => int.Parse(s) > 13 && int.Parse(s) < 20
            ? s == "15" ? "fifteen" : CountOnesNums(s[1].ToString()) + "teen"
            : s == "20"
            ? "twenty"
            : int.Parse(s) > 20 && int.Parse(s) < 30
            ? "twenty-" + CountOnesNums(s[1].ToString())
            : s == "30"
            ? "thirty"
            : int.Parse(s) > 30 && int.Parse(s) < 40
            ? "thirty-" + CountOnesNums(s[1].ToString())
            : s == "40"
            ? "forty"
            : int.Parse(s) > 40 && int.Parse(s) < 50
            ? "forty-" + CountOnesNums(s[1].ToString())
            : s == "50"
            ? "fifty"
            : int.Parse(s) > 50 && int.Parse(s) < 60
            ? "fifty-" + CountOnesNums(s[1].ToString())
            : s == "60"
            ? "sixty"
            : int.Parse(s) > 60 && int.Parse(s) < 70
            ? "sixty-" + CountOnesNums(s[1].ToString())
            : s == "70"
            ? "seventy"
            : int.Parse(s) > 70 && int.Parse(s) < 80
            ? "seventy-" + CountOnesNums(s[1].ToString())
            : s == "80"
            ? "eighty"
            : int.Parse(s) > 80 && int.Parse(s) < 90
            ? "eighty-" + CountOnesNums(s[1].ToString())
            : s == "90" ? "ninety" : int.Parse(s) > 90 && int.Parse(s) < 100 ? "ninety-" + CountOnesNums(s[1].ToString()) : "",
                    };
    }
}
