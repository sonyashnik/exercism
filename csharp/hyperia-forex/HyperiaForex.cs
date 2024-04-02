using System;
using System.Numerics;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }
	public static bool operator ==(CurrencyAmount firstCurrencyAmount, CurrencyAmount secondCurrencyAmount) => firstCurrencyAmount.currency == secondCurrencyAmount.currency ?
        firstCurrencyAmount.amount == secondCurrencyAmount.amount : throw new ArgumentException();

	public static bool operator !=(CurrencyAmount firstCurrencyAmount, CurrencyAmount secondCurrencyAmount) => firstCurrencyAmount.currency == secondCurrencyAmount.currency ?
		!(firstCurrencyAmount.amount == secondCurrencyAmount.amount) : throw new ArgumentException();
	public static bool operator >(CurrencyAmount firstCurrencyAmount, CurrencyAmount secondCurrencyAmount) => firstCurrencyAmount.currency == secondCurrencyAmount.currency ?
			firstCurrencyAmount.amount > secondCurrencyAmount.amount : throw new ArgumentException();

	public static bool operator <(CurrencyAmount firstCurrencyAmount, CurrencyAmount secondCurrencyAmount) => firstCurrencyAmount.currency == secondCurrencyAmount.currency ?
		firstCurrencyAmount.amount < secondCurrencyAmount.amount : throw new ArgumentException();

	public static decimal operator +(CurrencyAmount firstCurrencyAmount, CurrencyAmount secondCurrencyAmount) => firstCurrencyAmount.currency == secondCurrencyAmount.currency ?
			firstCurrencyAmount.amount + secondCurrencyAmount.amount : throw new ArgumentException();

	public static decimal operator -(CurrencyAmount firstCurrencyAmount, CurrencyAmount secondCurrencyAmount) => firstCurrencyAmount.currency == secondCurrencyAmount.currency ?
			firstCurrencyAmount.amount - secondCurrencyAmount.amount : throw new ArgumentException();

	public static decimal operator *(CurrencyAmount firstCurrencyAmount, CurrencyAmount secondCurrencyAmount) => firstCurrencyAmount.currency == secondCurrencyAmount.currency ?
			firstCurrencyAmount.amount * secondCurrencyAmount.amount : throw new ArgumentException();
	public static decimal operator /(CurrencyAmount firstCurrencyAmount, CurrencyAmount secondCurrencyAmount) => firstCurrencyAmount.currency == secondCurrencyAmount.currency ?
			firstCurrencyAmount.amount / secondCurrencyAmount.amount : throw new ArgumentException();

	public static explicit operator double(CurrencyAmount currencyAmount) => (double)currencyAmount.amount;

	public static implicit operator decimal(CurrencyAmount currencyAmount) => currencyAmount.amount;

}
