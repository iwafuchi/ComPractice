using System;
using System.Runtime.InteropServices;

namespace ComPractice
{
    [Guid("2A6CDF08-1C87-49B6-9058-7AEE529E1594")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface ComPracticeInterface
    {
        int Addition(int num1, int num2);
        int Subtraction(int num1, int num2);
    }
    [Guid("74498E3C-2777-4F9E-A3D1-EC97558EBF44")]
    [ClassInterface(ClassInterfaceType.None)]
    public class ComPractice:ComPracticeInterface
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
