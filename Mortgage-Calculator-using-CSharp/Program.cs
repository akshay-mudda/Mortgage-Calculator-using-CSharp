using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortgage_Calculator_using_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mortgage Calculator!");

            double principal = 0;
            double annualInterestRate = 0;
            int loanTermInYears = 0;

            // Prompt user for principal amount
            while (true)
            {
                try
                {
                    Console.Write("Enter the loan amount (principal) in dollars: ");
                    principal = Convert.ToDouble(Console.ReadLine());
                    break; // Exit the loop if input is valid
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid input! Please enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nInvalid input! The number you entered is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAn error occurred: " + ex.Message);
                }
            }

            // Prompt user for annual interest rate
            while (true)
            {
                try
                {
                    Console.Write("Enter the annual interest rate (in percentage): ");
                    annualInterestRate = Convert.ToDouble(Console.ReadLine());
                    break; // Exit the loop if input is valid
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid input! Please enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nInvalid input! The number you entered is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAn error occurred: " + ex.Message);
                }
            }

            // Prompt user for loan term (in years)
            while (true)
            {
                try
                {
                    Console.Write("Enter the loan term (in years): ");
                    loanTermInYears = Convert.ToInt32(Console.ReadLine());
                    break; // Exit the loop if input is valid
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid input! Please enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nInvalid input! The number you entered is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAn error occurred: " + ex.Message);
                }
            }

            // Convert annual interest rate to monthly interest rate
            double monthlyInterestRate = annualInterestRate / 100 / 12;

            // Convert loan term from years to months
            int loanTermInMonths = loanTermInYears * 12;

            // Calculate monthly mortgage payment using the formula
            double monthlyPayment = principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loanTermInMonths)) /
                                    (Math.Pow(1 + monthlyInterestRate, loanTermInMonths) - 1);

            // Display the result
            Console.WriteLine("\nYour monthly mortgage payment is: $" + Math.Round(monthlyPayment, 2));

            Console.WriteLine("Thank You!");
            Console.WriteLine("~By Akshay");
        }
    }
}
