using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InspectorLib
{

    public class FunctionInsp
    {
        static public string glav = ("Васильев Василий Иванович");
        static public string chita = ("Автоинспекция г. Чита");
        static public string List = ("Иванов И.И.Зиронов Т.А.Миронов А.В. Васильев В.И. ");
        static public string[] List2;
        static public string newglav;


       
         /// <summary>
        /// Метод 1 - Выводит ФИО главного инспектора.
       /// </summary>
    static public  void GetInspector()
        {
            Console.WriteLine($"Главный инспектор – {glav}");
        }



          /// <summary>
         ///  Метод 2 - Вывлоит название автвоинспекции.
        /// </summary>
        static public void GetСarInspection()
        {
            Console.WriteLine($"Название – {chita}");
        }



          /// <summary>
         /// Метод 3 - Изменяет ФИО главного инспектора
        /// </summary>
        static public void SetInspector()
        {
            Console.WriteLine($"ФИО нового главного инспектора");
            string fn = "Васильев Василий Иванович";
            fn = fn.Replace(fn, Console.ReadLine());
            Console.WriteLine($"Главный инспектор {fn}");
        }



          /// <summary>
         ///Метод 4 - Выводит на госномер но если введен не правильные госномер то присходит ошибка
        /// </summary>
        public string GenerateNumber(string number, string symbol, string code)
        {
            string answer = string.Empty;
            if (code == "75")
            {
                answer = symbol + number + code;
            }
            else
            {
                answer = "Введен не правильный регион ";
            }
            return answer;
        }



          /// <summary>
         /// Метод 5 - Выводит список сотрудников.
        /// </summary>
        static public void GetWorker()
        {
                List2 = List.Split(new Char[] { ';' });
                Console.WriteLine($"Cотрудники автоинспекции: {List}");
        }
        


          /// <summary>
         /// Метод 6 - Добавляет нового сотрудника в список сотрудников.
        /// </summary>
        public string AddWdorker()
        {

            Console.WriteLine("Введите ФИО нового сотрудника");
            string nw = Console.ReadLine();
            List = String.Concat(List + " Новый сотрудник:" + nw);
            return List;
        }

    }
}
