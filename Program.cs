using System;

namespace lb1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            TETriangle defoultTriagle = new TETriangle();
            Console.WriteLine($"Трикутник за замовчуванням: {defoultTriagle}");

            Console.WriteLine("Введiть сторону трикутника:");
            double side = double.Parse(Console.ReadLine());
            TETriangle userTriangle = new TETriangle(side);
            Console.WriteLine($"Трикутник введений користувачем: {userTriangle}");

            TETriangle dublicateTriangle = new TETriangle(userTriangle);
            Console.WriteLine($"Копiя введеного користувачем: {dublicateTriangle}");

            Console.WriteLine("Введiть цiле число:");
            int num = int.Parse(Console.ReadLine());
            TETriangle triangle1 = num * userTriangle;
            TETriangle triangle2 = userTriangle * num;
            Console.WriteLine($"Число помножене на трикутник введений користувачем: {triangle1}");
            Console.WriteLine($"Введений користувачем трикутник помножений на число: {triangle2}");

            Console.WriteLine("Порiвняння трикуткика за замовчуванням та введеного користувачем:");
            if (defoultTriagle == userTriangle) Console.WriteLine("Однаковi");
            else Console.WriteLine("Рiзнi");



            TEPiramid defoultPiramid = new TEPiramid();
            Console.WriteLine($"Пiрамiда за замовчуванням: {defoultPiramid}");

            Console.WriteLine("Введiть сторону основи:");
            double sideBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть висоту пiрамiди:");
            double height = double.Parse(Console.ReadLine());
            TEPiramid userPiramid = new TEPiramid(sideBase, height);
            Console.WriteLine($"Пiрамiда введена користувачем: {userPiramid}");

            TEPiramid dublicatePiramid = new TEPiramid(userPiramid);
            Console.WriteLine($"Копiя введеної користувачем пiрамiди: {dublicatePiramid}");

            Console.WriteLine("Введiть цiле число:");
            int n = int.Parse(Console.ReadLine());
            TEPiramid piramid1 = n * userPiramid;
            TEPiramid piramid2 = userPiramid * n;
            Console.WriteLine($"Число помножене на пiрамiду введену користувачем: {piramid1}");
            Console.WriteLine($"Введена користувачем пiрамiда помножена на число: {piramid2}");

            Console.WriteLine("Порiвняння пiрамiди за замовчуванням та введеної користувачем:");
            if (defoultPiramid == userPiramid) Console.WriteLine("Однаковi");
            else Console.WriteLine("Рiзнi");
        }
    }
}
