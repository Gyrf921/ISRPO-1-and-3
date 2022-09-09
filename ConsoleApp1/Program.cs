using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    struct orders
    {
        public string itemname;  //наименование
        public int unitCount;       //числоединиц
        public double unitCost; //стоимостьоднойединицы

        public string AllCost()
        {
            return $"Всего товара \"{itemname}\" на скаладе на сумму: {unitCost * unitCount}";
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            Angle angle1 = new Angle(10, (float)0.30, 'W');
            Angle.Print(angle1);

            Console.WriteLine();
            Angle angle2 = new Angle();
            Angle.Print(angle2);
            angle2.EnterCoordinatesAndDirection(50, (float)0.55, 'E');
            Angle.Print(angle2);

            Console.WriteLine("-----------------------");
            orders ObjStructure = new orders();
            ObjStructure.itemname = "Ручка";
            ObjStructure.unitCost = 20.2;
            ObjStructure.unitCount = 10;
            Console.WriteLine(ObjStructure.AllCost());
            Console.ReadKey();



        }
    }

    public class Angle
    {
        public int degrees;
        public float minuts;
        public char direction;

        public Angle()
        {
            degrees = 0;
            minuts = 0;
            direction = 'S';
        }

        public Angle(int _degr, float _min, char _direct)
        {
            degrees = _degr;
            minuts = _min;
            direction = _direct;
        }

        public void EnterCoordinatesAndDirection(int _degr, float _min, char _direct)
        {
            degrees = _degr;
            minuts = _min;
            direction = _direct;
        }

        public static void Print(Angle _angle)
        {
            Console.WriteLine("Координата точки: " + (_angle.degrees + _angle.minuts).ToString() + " | Направление: " + _angle.direction.ToString());
        }

    }
}
