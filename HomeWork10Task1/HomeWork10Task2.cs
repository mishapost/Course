using System;
using System.Reflection;
using MyAttributeFoHomeWork10;

namespace HomeWork10Task2
{
    public class HomeWork10Task2
    {

        public void Task2()
        {
            var atr = new MyAttributeExample();

            var myMethods = atr.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic  );

            Console.WriteLine("Только объявленные мною приватные методы");
            foreach (var method in myMethods)
            foreach (var attributeData in method.CustomAttributes)
                Console.WriteLine($"Метод: {method} имеет атрибут: {attributeData}");

            var myMembers = atr.GetType().GetMembers(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("Только объявленные мною члены класса");
            foreach (var member in myMembers)
              Console.WriteLine($" Член класса: {member}");

        }
    }
}
