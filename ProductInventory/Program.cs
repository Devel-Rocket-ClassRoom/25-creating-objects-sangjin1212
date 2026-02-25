using System;
using System.Net;
using System.Numerics;
Product[] products = new Product[3]
    {
    new Product { Name = "노트북", Price = 1500000, Stock = 5},
    new Product { Name = "마우스", Price = 35000, Stock = 20},
    new Product { Name = "키보드", Price = 89000, Stock = 15}
    };
Console.WriteLine("=== 상품 목록 ===");
foreach (Product product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine();
Console.WriteLine("=== 거래 ===");
products[0].Sell(2);
products[1].Sell(5);
products[2].Sell(20);
products[2].AddStock(10);
Console.WriteLine();
Console.WriteLine("=== 최종 상품 목록===");
foreach (Product product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine();
Console.WriteLine("=== 총 재고 가치 ===");
products[0].GetTotalValue();
products[1].GetTotalValue();
products[2].GetTotalValue();
Console.WriteLine("---");
int total = 0;
foreach (Product product in products)
{
    total += product.Stock * product.Price;
}
Console.WriteLine($"전체 재고 총 가치: {total}");

class Product
{
    public string Name;
    public int Price;
    public int Stock;

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{Name} {quantity}개 판매 완료 남은 재고: {Stock}개");

        }

        else 
        {
            Console.WriteLine($"{Name} {quantity}개 판매 실패, 재고가 부족합니다. (현재 재고: {Stock})");
           
        }

    }
    public void AddStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"{Name} {quantity}개 재고 추가, 현재 재고{Stock}");
    }

    public void GetTotalValue()
    {
        int TotalValue = Price * Stock;
        Console.WriteLine($"{Name}: {TotalValue}");
    }

    public override string ToString()
    {
        return $"[{Name}] {Price}원 (재고: {Stock}원)";
    }
}

