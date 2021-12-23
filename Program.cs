using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP_F
{
    public class SomeRef { public int x; }
    public struct SomeVal { public int x; }
    class Program
    {
        static void Main(string[] args)
        {
            SomeRef r1 = new SomeRef(); // Heap에 할당
            SomeVal v1 = new SomeVal(); // Stack에 할당
            r1.x = 5;
            v1.x = 5;

            Console.WriteLine(r1.x);
            Console.WriteLine(v1.x);

            SomeRef r2 = r1; // 참조(포인터)만 복사
            SomeVal v2 = v1; // 스택에 신규 메모리 공간 할당 후 복사
            r1.x = 8;
            v1.x = 8;
            Console.WriteLine(r1.x);
            Console.WriteLine(r2.x);
            Console.WriteLine(v1.x);
            Console.WriteLine(v2.x);
        }
    }
}