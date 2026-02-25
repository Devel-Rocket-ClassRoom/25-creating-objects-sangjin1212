using System;

BankAccount[] accounts = new BankAccount[2]
    {
        new BankAccount { OwnerName = "홍길동", AccountNumber = "1001"},
        new BankAccount { OwnerName = "이순신", AccountNumber = "1002"}
    };
foreach (BankAccount account in accounts)
{
    Console.WriteLine(account);
}

class BankAccount
{
    public static int TotalAccounts;

    public string AccountNumber;
    public string OwnerName;
    public int Balance;

    public static void ShowTotalAccounts()
    {
       
        TotalAccounts++;
    }
}