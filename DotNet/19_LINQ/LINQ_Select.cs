﻿using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_Select
{
    static void Main()
    {
        var names = new List<string> { "홍길동", "백두산", "임꺽정" };

        // Select() 확장 메서드에서 익명 형식을 사용하기에
        // var로 받아야 함
        var nameObject = names.Select(n => new { Name = n });

        foreach (var name in nameObject)
        {
            Console.WriteLine(name.Name);
        }
    }
}
