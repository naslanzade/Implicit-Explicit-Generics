using Implicit_Explicit_Generics.Models;
using System;
using static Implicit_Explicit_Generics.Book;

namespace Implicit_Explicit_Generics
{
    class Program
    {
        public static object GetProductsByDate { get; private set; }

        static void Main(string[] args)
        {


            #region ImplicitOperatorForCelsius

            //Celsius celsius = new Celsius(500);

            //Kelvin kelvin = celsius;

            //Console.WriteLine(kelvin.Degree1);

            #endregion


            //Employee1<DateTime> employee1 = new Employee1<DateTime>(new DateTime(1988,12,31));

            ////Console.WriteLine(employee1.Birthdaydate());
            //employee1.GetCountOfEmployee();
            
           



            
            



            #region ClassWork


            //Manat manat = new Manat(100);

            //Dollar dollar = manat;

            //Console.WriteLine(dollar.Usd);



            //DateTime date = DateTime.Now;

            //Console.WriteLine(date.ToString("MM/dd/yyyy"));



            //StringList list = new StringList();

            //list.Add("Qoshqar");
            //list.Add("Ramil");
            //list.Add("Resul");
            //list.Add("Novreste");
            //list.Add("Gultac");
            //list.Add("Lale");

            //list.GetAll();


            //IntList age = new IntList();

            //age.Add(29);
            //age.Add(25);
            //age.Add(19);
            //age.Add(25);
            //age.Add(18);
            //age.Add(27);

            //age.GetAll();


            //BookList book = new BookList();
            //book.Add(new Book { Name = "CSS" });
            //book.Add(new Book { Name = "C#" });
            //book.Add(new Book { Name = "JS" });

            //book.GetAll();


            //DataList<int> age1 = new DataList<int>();

            //age1.Add(29);
            //age1.Add(25);
            //age1.Add(19);
            //age1.Add(25);
            //age1.Add(18);
            //age1.Add(27);

            //age1.GetAll();


            //DataList<string> name1 = new DataList<string>();

            //name1.Add("Qoshqar");
            //name1.Add("Ramil");
            //name1.Add("Resul");
            //name1.Add("Novreste");
            //name1.Add("Gultac");
            //name1.Add("Lale");

            //name1.GetAll();


            //DataList<bool> marries = new DataList<bool>();

            //marries.Add(true);
            //marries.Add(false);
            //marries.Add(false);

            //marries.GetAll();



            //Repository<int> number = new Repository<int>();

            //Repository<string> name = new Repository<string>();

            //Repository<Student> student = new Repository<Student>();

            //Repository<Employee> employee = new Repository<Employee>();

            //Repository<Student,Person> person = new Repository<Student,Person>();

            //Repository<Employee, Common> person1 = new Repository<Employee, Common>();

            //DateTime start = DateTime.Now;

            //DateTime end = DateTime.Now.AddDays(10);

            //Console.WriteLine($"Start date :{start} - End date{end}");

            //GetProductsByDates(start, end);

            #endregion







        }



        #region ClassWork

        //private static void GetProductsByDates(DateTime start, DateTime end)
        //{
        //    if (start > end)
        //    {
        //        Console.WriteLine("Yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No");
        //    }
        //}
        #endregion
    }

    #region ClassWork

    //public class StringList
    //{
    //    private string[] _arr;

    //    public StringList()
    //    {
    //        _arr = new string[0];
    //    }


    //    public void Add(string str)
    //    {
    //        Array.Resize(ref _arr,_arr.Length+1);

    //        _arr[_arr.Length - 1] = str;
    //    }


    //    public void GetAll()
    //    {
    //        for (int i = 0; i < _arr.Length; i++)
    //        {
    //            Console.WriteLine(_arr[i]);
    //        }
    //    }
    //}


    //public class IntList
    //{
    //    private int[] _arr;

    //    public IntList()
    //    {
    //        _arr = new int[0];
    //    }


    //    public void Add(int num)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);

    //        _arr[_arr.Length - 1] = num;

    //    }


    //    public void GetAll()
    //    {
    //        for (int i = 0; i < _arr.Length; i++)
    //        {
    //            Console.WriteLine(_arr[i]);
    //        }
    //    }
    //}


    //public class DataList<T>
    //{
    //    private T[] _datas;

    //    public DataList()
    //    {

    //        _datas = new T[0];

    //    }

    //    public void Add(T data)
    //    {
    //        Array.Resize(ref _datas, _datas.Length + 1);

    //        _datas[_datas.Length - 1] = data;
    //    }


    //    public void GetAll()
    //    {
    //        //for (int i = 0; i < _datas.Length; i++)
    //        //{
    //        //    Console.WriteLine(_datas[i]);
    //        //}

    //        foreach (var item in _datas)
    //        {
    //            Console.WriteLine(item);
    //        }

    //    }



    //}

    //public class Dollar
    //{
    //    public double Usd { get; set; }

    //    public Dollar(double usd)
    //    {
    //        Usd = usd;


    //    }
    //}



    //public class Manat
    //{
    //    public double Azn { get; set; }

    //    public Manat(double azn)
    //    {
    //        Azn = azn;
    //    }

    //    public static implicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.Azn/1.7);
    //    }

    //}












    #endregion


}
