using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 기본 쿼리 ===");
string query1 = new QueryBuilder()
                    .Select("*")
                    .From("Users")
                    .Build();
Console.WriteLine(query1);

Console.WriteLine("=== 조건 쿼리 ===");
string query2 = new QueryBuilder()
                    .Select("Name, Age")
                    .From("Users")
                    .Where("Age > 18")
                    .Build();
Console.WriteLine(query2);

Console.WriteLine("=== 정렬 쿼리 ===");
string query3 = new QueryBuilder()
                    .Select("*")
                    .From("Products")
                    .Where("Price > 1000")
                    .OrderBy("Price")
                    .Build();
Console.WriteLine(query3);