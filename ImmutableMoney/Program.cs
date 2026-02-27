using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Money m = new Money(100, 50);
int firstG = m.Gold;
int firstS = m.Silver;

Console.WriteLine("=== 초기 화폐 ===");
Console.WriteLine($"지갑: {m}\n");

Console.WriteLine("=== 화폐 추가 ===");
Console.WriteLine($"추가 후: {m.Add(50, 30)}");
Console.WriteLine($"원본 지갑: {m}\n");

Console.WriteLine("=== 화폐 차감 ===");
Console.WriteLine($"차감 후: {m.Subtract(20, 30)}");
Console.WriteLine($"원본 지갑: {m}\n");

Console.WriteLine("=== 메서드 체이닝 ===");
Console.WriteLine($"결과: {m.Add(40, 30).Subtract(20, 50)}");
