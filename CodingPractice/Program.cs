using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
//1
Dog myDog = new Dog();
myDog.name = "초코";
myDog.Age = 3;
myDog.Bark();
Console.WriteLine($"이름: {myDog.name}, 나이{myDog.Age}");
//2
Monster monster1 = new Monster();
Console.WriteLine(monster1);
var monster2 = new Monster();
Console.WriteLine(monster2);
//3
Calculator calr = new Calculator();
calr.Add(3, 5);
calr.Multply(4, 6);
//4
Counter counter = new Counter();
counter.Incremet();
counter.Incremet();
counter.Incremet();
counter.Reset();
//5
GameManager.TotalPlayer = 10;
GameManager.ShowStatus();

GameManager gameManager = new GameManager();
gameManager.PlayerName = "홍길동";
gameManager.Greet();
//6
Greeting.SayHello();
FareWell.Wave();

Greeting greeting = new Greeting();
greeting.SayGoodbye();
FareWell fareWell = new FareWell();
fareWell.Bow();
//7
Item item = new Item();
item.name = "포션";
item.price = 100;
Console.WriteLine(item);
//8
Item1 item1 = new Item1();
item1.name = "포션";
item1.price = 100;
Console.WriteLine(item1);
//9
Player p1 = new Player();
p1.name = "전사";
p1.Level = 10;
p1.Health = 200;
Console.WriteLine(p1);
Player p2 = new Player();
p2.name = "마법사";
p2.Level = 8;
p2.Health = 120;
Console.WriteLine(p2);
//10
Enemy[] enemies = new Enemy[3];
enemies[0] = new Enemy();
enemies[0].Name = "고블린";
enemies[0].Health = 50;
enemies[1] = new Enemy();
enemies[1].Name = "오크";
enemies[1].Health = 100;
enemies[2] = new Enemy();
enemies[2].Name = "드래곤";
enemies[2].Health = 500;

for (int i = 0; i < enemies.Length; i++)
{
    enemies[i].ShowInfo();   
}
//11
Item2[] inventory = new Item2[3];
inventory[0] = new Item2 { Name = "검", Price = 500 };
inventory[1] = new Item2 { Name = "방패", Price = 300 };
inventory[2] = new Item2 { Name = "포션", Price = 50 };

foreach (Item2 item2 in inventory)
{
    Console.WriteLine(item2);
}
//12
Character ch1 = new Character();
ch1.Name = "홍길동";
ch1.Level = 1;
ch1.Job = "전사";
Character ch2 = new Character
{
    Name = "이순신",
    Level = 5,
    Job = "궁수"
};
Console.WriteLine($"{ch1.Name} - {ch1.Job} Lv.{ch1.Level}");
Console.WriteLine($"{ch2.Name} - {ch2.Job} Lv.{ch2.Level}");
//13
Student[] students = new Student[3]
 {
    new Student { Name = "김철수", Score = 85 },
    new Student { Name = "이영희", Score = 92 },
    new Student { Name = "박민수", Score = 78 },
 };
foreach (Student student in students)
{
    Console.WriteLine(student);
}

//1
class Dog
{
    public string name;
    public int Age;

    public void Bark()
    {
        Console.WriteLine($"{name}: 멍멍!");
    }
}
//2
public class Monster
{
    string name;
}
//3
class Calculator
{
    public void Add(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine($"합계: {sum}");
    }

    public void Multply(int x, int y)
    {
        int product = x * y;
        Console.WriteLine($"곱: {product}");
    }
}

//4
class Counter
{
    public int count = 0;

    public void Incremet()
    {
        count++;
        Console.WriteLine($"현재 카운트: {count}");
    }

    public void Reset()
    { 
        count = 0;
        Console.WriteLine("카운트가 초기화되었습니다.");
    }
}

//5
public class GameManager
{
    public static int TotalPlayer = 0;
    public static void ShowStatus()
    {
        Console.WriteLine($"[정적] 총 플레어수: {TotalPlayer}");
    }
    public string PlayerName;
    public void Greet()
    {
        Console.WriteLine($"[인스턴스] 안녕하세요, {PlayerName}님");
    }
}

//6
class Greeting
{
    public static void SayHello()
    {
        Console.WriteLine("안녕하세요!");
    }
    public void SayGoodbye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

class FareWell
{
    public static void Wave()
    {
        Console.WriteLine("(손을 흔든다)");
    }

    public void Bow()
    {
        Console.WriteLine("(인사한다)");
    }
}

//7
class Item
{
    public string name;
    public int price;

}

//8
class Item1
{
    public string name;
    public int price;

    public override string ToString()
    {
        return $"[아이템] {name} - {price}골드";
    }
}
//9
class Player
{
    public string name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"[{Level}레벨] {name} (HP:{Health})";
    }
}
//10
class Enemy
{
    public string Name;
    public int Health;
    public void ShowInfo()
    {
        Console.WriteLine($"{Name}: HP:{Health}");
    }
}
//11
class Item2
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"{Name}: {Price}골드";
        
    }
}

//12
class Character
{
    public string Name;
    public int Level;
    public string Job;


}

//13
class Student
{
    public string Name;
    public int Score;

    public override string ToString()
    {
        return $"{Name}: {Score}점";
    }
}