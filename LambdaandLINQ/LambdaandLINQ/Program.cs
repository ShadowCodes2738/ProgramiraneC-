using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaandLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(45, "Ivan Ivanov", 765.56);
            Person p2 = new Person(35, "Stojan Dimov", 1365.6);
            Person p3 = new Person(65, "Kiril Marinov", 1765.56);
            Person p4 = new Person(59, "Kosta Kamenov", 985.56);
            Person p5 = new Person(35, "Anton Dimov", 1065.6);

            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };

            double maxsalary = people.Max(x=>x.Salary);
            Console.WriteLine("Nai visokata zaplata vuv firmata e:"+maxsalary);//1.Каква е най-високата заплата във фирмата
            int youngest = people.Min(x => x.Age);
            Console.WriteLine("Nai mladdiq rabotnik vuv frimata e na "+youngest+" godini");//2.На колко години е най-младият работник във фирмата
            double companysum = people.Sum(x => x.Salary);
            Console.WriteLine("Sumata za zaplati na cqlata firma e:"+companysum);//3.Каква е сумата за заплати на цялата фирма
            double avrsalary = people.Average(x => x.Salary);
            Console.WriteLine("Srednata stoinost na zaplatata vuv fimrata e:"+avrsalary);//4.Каква е средната заплата във фирмата
            double avrage = people.Average(x => x.Age);
            Console.WriteLine("Srednata vuzrast na rabotnicite vuv firmata e:"+avrage);//5.Каква е средната възраст на работниците във фирмата
            List<Person> abcperson = people.OrderBy(x => x.Name).ToList();//6.Изведете списък с работниците по азбучен ред 
            List<Person> agesalaryperson = people.OrderBy(x => x.Age).ThenBy(x => x.Name).ToList();//7.Изведете списък с работниците сортирани по възраст в намаляващ ред и по заплата в нарастваш ред
            List<Person> agedescsalaryperson = people.OrderBy(x => x.Age).ThenByDescending(x => x.Name).ToList();//8.Изведете списък с работниците сортирани по възраст в намаляващ ред и по заплата в намаляващ 
            List<Person> aboveavrsalary = people.Where(x=>x.Salary > 1189.576).ToList();//9.Изведете  списък с работниците със заплати над средната
            List<Person> topthreesalary = people.OrderBy(x=>x.Salary).Take(3).ToList();//10.Изведете списък с работниците с трите най-високи заплати във фирмата
            for (int i = 0; i < abcperson.Count; i++)
            {
                Console.WriteLine(abcperson.ToString());
            }
        }
    }
}
