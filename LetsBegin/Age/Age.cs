using System;


class Age
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        int yourAge = DateTime.Now.Year - birthDay.Year;
        if (today.Month < birthDay.Month || ((today.Month == birthDay.Month) && (today.Day < birthDay.Day)))
        {
            yourAge--;
        }
        Console.WriteLine(yourAge);
        int afterTenYears = yourAge + 10;
        Console.WriteLine(afterTenYears);
    }
}

