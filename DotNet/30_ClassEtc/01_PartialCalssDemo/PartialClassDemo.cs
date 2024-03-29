﻿//[?] 부분 클래스를 사용하여 하나의 프로젝트 또는 cs 파일에
//    동일한 이름의 클래스를 하나 이상 두고 개발할 때 partial 키워드 사용
using System;

namespace PartialClassDemo
{
    class PartialClass
    {
        static void Main()
        {
            //[A] Hello 클래스의 객체로 서로 다른 파일의 멤버들 호출 가능
            var hello = new Hello();
            hello.Hi(); 
            hello.Bye();
        }
    }
}
