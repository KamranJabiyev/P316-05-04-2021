using System;
using System.Text;
using Demo;
using Demo2.DemoInDemo2;
namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers

            #region Public - class & all class members(field,property,method)
            //Car car = new Car();
            //car.Brend = "Mercedes";
            //Console.WriteLine(car.Brend);
            #endregion

            #region Private-all class members
            //Car car = new Car();
            //car.Speed = 300;
            //Console.WriteLine(car.Speed);
            //car.SetSpeed(300);
            //Console.WriteLine(car.GetSpeed());
            //Console.WriteLine(car.Color);
            #endregion

            #region Protected - all class members
            //Car car = new Car();
            //car.harsePower = 300;
            #endregion

            #region public readonly,private readonly - field
            //Car car = new Car();
            //Console.WriteLine(car.Price);
            #endregion

            #endregion

            #region Namespace
            Demo.Car car = new Demo.Car();
            Test car1 = new Test();
            Person person = new Person();
            Console.WriteLine();
            #endregion
        }
    }
}
