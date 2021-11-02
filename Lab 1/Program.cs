/// Week 10 Lab 1
/// File Name: week10lab1.cs
/// Author: Lucas Smith
/// Date:  November 1, 2021
///
/// Problem Statement: Define a class named Payment that contains an instance variable of type double that stores the amount of the payment and appropriate getter and setter methods.  Also create a method names PaymentDetails that outputs an English sentence to describe the amount of the payment.


/// 
/// 
/// Overall Plan:
/// 1) Declare public classes for Payment, CashPayment, and CreditCardPayment
/// 2) Declare the methods inside Payment, and the extension methods inside CashPayment and CreditCardPayment
/// 3) Test each child classes inside the Main class
using System;

namespace Lab_1
{
	public class Payment
	{
		public double amount;
		public Payment()
		{
			this.amount = 0;
		}
		public Payment(double amount)
		{
			this.amount = amount;
		}
		public void setPayment(double amount)
		{
			this.amount = amount;
		}
		public double getPayment()
		{
			return this.amount;
		}
		public void paymentDetails()
		{
			Console.WriteLine("The payment amount is " + this.amount.ToString());
		}
	}
	public class CashPayment : Payment
	{
		public CashPayment(double amt)
		{
			this.amount = amt;
		}
		public new void paymentDetails() 
		{
			Console.WriteLine("The cash payment amount is " + getPayment().ToString());
		}
	}
	public class CreditCardPayment : Payment
	{
		private String name;
		private String expiration;
		private String creditcard;
		public CreditCardPayment()
		{
			this.name = " ";
			this.expiration = " ";
			this.creditcard = "";
		}
		public CreditCardPayment(double amt, String name, String expiration, String creditcard)
		{
			this.amount = amt;
			this.name = name;
			this.expiration = expiration;
			this.creditcard = creditcard;
		}
		public new void paymentDetails()
		{
			Console.WriteLine("The credit card payment amount is " + getPayment().ToString());
			Console.WriteLine("The name on the card is: " + name);
			Console.WriteLine("The expiration date is: " + expiration);
			Console.WriteLine("The credit card number is: " + creditcard);
		}
	}
	class Program
	{
		public static void Main(String[] args)
		{
			var cash1 = new CashPayment(50.5);
			var cash2 = new CashPayment(20.45);
			var credit1 = new CreditCardPayment(10.5, "Fred", "10/5/2010", "123456789");
			var credit2 = new CreditCardPayment(100, "Barney", "11/15/2009", "987654321");
			Console.WriteLine("Cash 1 details:");
			cash1.paymentDetails();
			Console.WriteLine();
			Console.WriteLine("Cash 2 details:");
			cash2.paymentDetails();
			Console.WriteLine();
			Console.WriteLine("Credit 1 details:");
			credit1.paymentDetails();
			Console.WriteLine();
			Console.WriteLine("Credit 2 details:");
			credit2.paymentDetails();
			Console.WriteLine();
		}
	}
}
