//Compound interest calculator app

// this app calculates the compund interest for a savings account


//variables
double initialInvestment = 1000.00;
double interestRate = 0.01;
double yearlyInterestEarned;
double totalInvestedOneYear;
double newTotal;


//gives the interest earned the first year
yearlyInterestEarned = initialInvestment * interestRate;
Console.WriteLine("Interest earned the first year is {0} dollars.", yearlyInterestEarned);
Console.WriteLine();

//gives total after first year
totalInvestedOneYear = initialInvestment + yearlyInterestEarned;
Console.WriteLine("So, after the first year you will have {0}", totalInvestedOneYear);
Console.WriteLine();

//gives the total savings after 5 years
Console.WriteLine("Here is the next 5 years calculated for you");
newTotal = initialInvestment * Math.Pow(1 + interestRate, 5);
Console.WriteLine("Your compound interest is " + newTotal);
Console.WriteLine();

//gives the total savings after 10 years
Console.WriteLine("Here is the next 10 years calculated for you");
newTotal = initialInvestment * Math.Pow(1 + interestRate, 10);
Console.WriteLine("Your compound interest is " + newTotal);


