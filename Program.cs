public class Converter
{
    decimal DollarExchangeRate;
    decimal EuroExchangeRate;

    public Converter(decimal dollar, decimal euro)
    {
        DollarExchangeRate = dollar;
        EuroExchangeRate = euro;
    }

    public void ConvertCurrencyToDollar(decimal money)
    {
        decimal ConvertedMoney = money / DollarExchangeRate;
        Console.WriteLine("Converted: " + ConvertedMoney + " dollar");
    }

    public void ConvertCurrencyToEuro(decimal money)
    {
        decimal ConvertedMoney = money / EuroExchangeRate;
        Console.WriteLine("Converted: " + ConvertedMoney + " euro");
    }
    public void ConvertDollarToHryvnia(decimal money)
    {
        decimal ConvertedMoney = money*DollarExchangeRate;
        Console.WriteLine("Converted: " + ConvertedMoney + " hryvnia");
    }

    public void ConvertEuroToHryvmia(decimal money)
    {
        decimal ConvertedMoney = money*EuroExchangeRate;
        Console.WriteLine("Converted: " + ConvertedMoney + " hryvnia");
    }


}

class Program
{
    public static void Main(string[] args)
    {
        Converter converter = new Converter(38, 40);
        converter.ConvertCurrencyToDollar(1000);
        converter.ConvertCurrencyToEuro(1000);
        converter.ConvertDollarToHryvnia(25);
        converter.ConvertEuroToHryvmia(30);


    }
}