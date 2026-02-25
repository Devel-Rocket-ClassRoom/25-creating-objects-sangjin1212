using System;
Console.WriteLine("=== 계좌 개설 ===");
BankAccount acc1 = new BankAccount("1001", "홍길동", 100000);
BankAccount acc2 = new BankAccount("1002", "이순신", 50000);
BankAccount.ShowTotalAccounts();
Console.WriteLine();

Console.WriteLine("=== 거래 ===");
acc1.Deposit(50000);
acc2.Deposit(30000);
acc1.Withdraw(200000);
acc1.Withdraw(100000);
Console.WriteLine();

Console.WriteLine("=== 최종 계좌 정보 ===");
acc1.ShowInfo();
acc2.ShowInfo();
class BankAccount
{
    public static int TotalAccounts;

    public string AccountNumber;
    public string OwnerName;
    public int Balance;

    public BankAccount(string AccountNumber,string OwnerName,int Balance)
    {
        this.AccountNumber = AccountNumber;
        this.OwnerName = OwnerName;
        this.Balance = Balance;
        TotalAccounts++;

        Console.WriteLine($"[{AccountNumber}] {OwnerName} 계좌가 개설 되었습니다.");
    }
    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"[{AccountNumber}] {amount}운 입금 완료. 잔액: {Balance}원");
    }
    public void Withdraw(int amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 실패. 잔액이 부족합니다.");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"[{AccountNumber}] {amount}원 출금 완료. 잔액: {Balance}원");

    }
    public void ShowInfo()
    {
        Console.WriteLine($"계좌번호: {AccountNumber}, 예금주: {OwnerName}, 잔액 {Balance}원");
    }
    public static void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌수: {TotalAccounts}");
    }
}