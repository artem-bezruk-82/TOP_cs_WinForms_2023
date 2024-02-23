using System;
using System.Collections.Generic;

namespace Bank.DataModel;

public partial class Account
{
    public int Id { get; set; }

    public double Balance { get; set; }

    public int? ClientId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public delegate void BalanceNotificatioHandler(string message);
    public delegate void BalanceChanged(double value, double balance);
    public event BalanceNotificatioHandler? Notify;
    public event BalanceChanged? OnBalanceChanged;

    public void Put(double value)
    {
        if (value >= 0)
        {
            Balance += value;
            Notify?.Invoke($"Balance increased: {value}; Current balance: {Balance}");
            OnBalanceChanged?.Invoke(value, this.Balance);
        }
        else
        {
            Notify?.Invoke($"Value you are trying to add is below zero: {value}");
        }
    }

    public void Take(double value)
    {
        if (value <= Balance)
        {
            Balance = Balance - value;
            Notify?.Invoke($"Balance decreased: {value}; Current balance: {Balance}");
            OnBalanceChanged?.Invoke(value*(-1), this.Balance);
        }
        else
        {
            Notify?.Invoke($"Not enough money. Current balance: {Balance}");
        }
    }


    public override string ToString()
    {
        return $"Account Id: {Id};\nBalance: {Balance}";
    }
}
