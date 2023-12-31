﻿using System.Diagnostics.CodeAnalysis;

namespace Contacts.Domain.Models;

[ExcludeFromCodeCoverage]
public class Contact
{
    public Contact()
    {
        Addresses = new List<Address>();
        Phones = new List<Phone>();
    }
    
    public int ContactId { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public DateTime Birthday { get; set; }
    public DateTime? Anniversary { get; set; }
    
    public List<Address> Addresses { get; set; }
    public List<Phone> Phones { get; set; }
    
    public string FullName {
        get 
        {
            if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName) &&
                string.IsNullOrEmpty(MiddleName))
            {
                return "Could not determine the contact name";
            }

            if (string.IsNullOrEmpty(MiddleName))
            {
                return $"{FirstName} {LastName}";
            }

            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}