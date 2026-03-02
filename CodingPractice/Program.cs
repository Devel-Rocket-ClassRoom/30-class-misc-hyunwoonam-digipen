using System;
using System.Drawing;
using System.Numerics;
using System.Text;

{
    Console.WriteLine("1. 부분 클래스 기본 문법");

    Person person = new Person();

    person.Name = "홍길동";
    person.Age = 25;
    person.Print();
}

Console.WriteLine();

{
    Console.WriteLine("2. 부분 클래스 사용 예제");

    Hello hello = new Hello();

    hello.Hi();
    hello.Bye();
}

Console.WriteLine();

{
    Console.WriteLine("3. 정적 클래스 기본 문법");

    Console.WriteLine($"덧셈: {Calculator.Add(10, 20)}");
    Console.WriteLine($"뺄셈: {Calculator.Subtract(30, 10)}");
    Console.WriteLine($"곱셈: {Calculator.Multiply(5, 6)}");
}

Console.WriteLine();

{
    Console.WriteLine("4. 유틸리티 클래스 만들기");

    string text = "  hello world  ";

    Console.WriteLine(StringHelper.CleanAndUpper(text));
    Console.WriteLine(StringHelper.Reverse("Hello"));
    Console.WriteLine(StringHelper.IsNullOrEmpty(""));
}

Console.WriteLine();

{
    Console.WriteLine("5. 닷넷의 정적 클래스 예시");

    Console.WriteLine($"제곱근: {Math.Sqrt(16)}");
    Console.WriteLine($"거듭제곱: {Math.Pow(2, 3)}");
    Console.WriteLine($"최댓값: {Math.Max(10, 20)}");
    Console.WriteLine($"최솟값: {Math.Min(10, 20)}");
}

Console.WriteLine();

{
    Console.WriteLine("6. StringBuilder의 메서드 체이닝");

    StringBuilder sb1 = new StringBuilder();

    sb1.Append("Hello");
    sb1.Append(" ");
    sb1.Append("World");

    string sb2 = new StringBuilder()
        .Append("Hello")
        .Append(" ")
        .Append("World")
        .ToString();

    Console.WriteLine(sb1.ToString());
    Console.WriteLine(sb2.ToString());
}

Console.WriteLine();

{
    Console.WriteLine("7. 메서드 체이닝 직접 구현하기");

    string message = new MessageBuilder()
        .AddText("안녕하세요!")
        .AddNewLine()
        .AddText("반갑습니다.")
        .AddSpace()
        .AddText("좋은 하루 되세요.")
        .Build();

    Console.WriteLine(message);
}

Console.WriteLine();

{
    Console.WriteLine("8. 불변 객체와 메서드 체이닝");

    Point point = new Point(0, 0)
        .MoveBy(10, 10)
        .MoveBy(20, 20)
        .MoveBy(30, 30);

    Console.WriteLine(point);
}

Console.WriteLine();

{
    Console.WriteLine("9. 문자열 메서드 체이닝");

    string text = "  Hello World  ";
    string result = text
        .Trim()
        .ToLower()
        .Replace(" ", "_");

    Console.WriteLine(result);
}

Console.WriteLine();

{
    Console.WriteLine("10. 가변 형식");

    MutableCircle circle = new MutableCircle(10);

    Console.WriteLine($"반지름: {circle.Radius}");

    circle.Radius = 20;

    Console.WriteLine($"반지름: {circle.Radius}");
}

Console.WriteLine();

{
    Console.WriteLine("11. 불변 형식");

    ImmutableCircle circle1 = new ImmutableCircle(10);
    ImmutableCircle circle2 = circle1.WithRadius(20);

    Console.WriteLine($"원본 반지름: {circle1.Radius}");
    Console.WriteLine($"새 원 반지름: {circle2.Radius}");
    Console.WriteLine($"원본 반지름: {circle1.Radius}");
}

Console.WriteLine();

{
    Console.WriteLine("12. readonly 필드를 사용한 불변 형식");

    Player player1 = new Player("용사", 1);
    Player player2 = player1.LevelUp();

    Console.WriteLine($"player1: {player1.Name}, 레벨 {player1.Level}");
    Console.WriteLine($"player2: {player2.Name}, 레벨 {player2.Level}");
}

Console.WriteLine();

{
    Console.WriteLine("13. 닷넷의 불변 형식 예시");

    string original = "Hello";
    string modified = original.ToUpper();

    Console.WriteLine($"원본: {original}");
    Console.WriteLine($"수정본: {modified}");
}

Console.WriteLine();

{
    Console.WriteLine("14. 종합 - 부분 클래스로 게임 캐릭터 구현");

    Character character = new Character("용사");

    Console.WriteLine($"{character.Name} - 레벨: {character.Level}, 체력: {character.Health}");
    
    character.TakeDamage(30);
    character.Heal(10);
}

Console.WriteLine();

{
    Console.WriteLine("15. 종합 - 정적 클래스로 유틸리티 만들기");

    int damage = GameHelper.CalculateDamage(10, 5);
    bool isAlive = GameHelper.IsAlive(50);
    string healthStatus = GameHelper.GetHealthStatus(30, 100);

    Console.WriteLine($"계산된 데미지: {damage}");
    Console.WriteLine($"생존 여부: {isAlive}");
    Console.WriteLine($"체력 상태: {healthStatus}");
}

Console.WriteLine();

{
    Console.WriteLine("16. 종합 - 불변 형식과 메서드 체이닝 결합");

    Vector2D vector = new Vector2D(1, 1)
        .Add(2, 3)
        .Multiply(2)
        .Add(-1, -2);

    Console.WriteLine($"결과 벡터: {vector}");
}
