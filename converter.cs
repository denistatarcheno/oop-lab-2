using System;

public class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;
    public Converter(double usd, double eur, double pln)
    {
        this.usdRate = usd;
        this.eurRate = eur;
        this.plnRate = pln;
    }
    public double ConvertFromUah(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount / usdRate;
            case "EUR":
                return amount / eurRate;
            case "PLN":
                return amount / plnRate;
            default:
                throw new ArgumentException("Unsupported currency");
        }
    }
    public double ConvertToUah(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount * usdRate;
            case "EUR":
                return amount * eurRate;
            case "PLN":
                return amount * plnRate;
            default:
                throw new ArgumentException("Unsupported currency");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(28.0, 32.0, 7.5);
        double amountInUah = 1000.0;
        double amountInUsd = converter.ConvertFromUah(amountInUah, "USD");
        Console.WriteLine($"{amountInUah} UAH = {amountInUsd} USD");
        double amountBackInUah = converter.ConvertToUah(amountInUsd, "USD");
        Console.WriteLine($"{amountInUsd} USD = {amountBackInUah} UAH");
    }
}
