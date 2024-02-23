using System;
using System.Collections.Generic;

namespace Bank.DataModel;

public partial class Client
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string DateOfBirth { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public override string ToString()
    {
        return $"Id: {Id}; \nName: {Name} {Surname}; \nDate of birth: {DateOfBirth}; \nPhone: {Phone}; " +
            $"\nEmail: {Email}";
    }
}
