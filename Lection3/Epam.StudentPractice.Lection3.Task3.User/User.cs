using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task3.User
{
    public class User
    {
        #region fields

        private string secondName;

        private string name;

        private string patronymic;

        public string SecondName 
        {
            get => this.secondName;
            set
            {
                if (value.Length < 2 || value.Length > 55)
                {
                    throw new Exception($"SecondName can't be {value.Length} length.");
                }
                else
                {
                    this.secondName = value;
                }
            }
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 2 || value.Length > 55)
                {
                    throw new Exception($"Name can't be {value.Length} length.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Patronymic
        {
            get => this.patronymic;
            set
            {
                if (value.Length < 2 || value.Length > 55)
                {
                    throw new Exception($"Patronymic can't be {value.Length} length.");
                }
                else
                {
                    this.patronymic = value;
                }
            }
        }


        public DateTime BirthDay { get; set; } = DateTime.Parse("1960 01 01");
        public int Age
        {
            get
            {
                int years = DateTime.Now.Year - BirthDay.Year;

                if ((BirthDay.Month > DateTime.Now.Month) || (BirthDay.Month == DateTime.Now.Month && BirthDay.Day > DateTime.Now.Day))
                    years--;

                return years;
            }
        }
        #endregion fields

        #region ctors
        public User() { }
        public User(string secondName, string name, string patronymic, DateTime birthDay)
        {
            SecondName = secondName;
            Name = name;
            Patronymic = patronymic;
            BirthDay = birthDay;
        }
        public User(string secondName, string name, string patronymic)
        {
            SecondName = secondName;
            Name = name;
            Patronymic = patronymic;
        }
        #endregion ctors

        #region methods
        private static bool IsLetterString(string str)
        {
            char[] arrayOfString = str.ToCharArray();
            foreach (char symbol in arrayOfString)
            {
                if (!char.IsLetter(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        public static User InitUser()
        {
            User user;
            do
            {
                Console.WriteLine("Enter name.");
                string name = Console.ReadLine();
                if (IsLetterString(name))
                {
                    Console.WriteLine("Enter second name.");
                    string secondName = Console.ReadLine();
                    if (IsLetterString(secondName))
                    {
                        Console.WriteLine("Enter patronymic.");
                        string patronymic = Console.ReadLine();
                        if (IsLetterString(patronymic))
                        {
                            Console.WriteLine("Enter date of birth: yyyy mm dd  or enter something to pick default date.");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime birth))
                            {
                                user = new User(name, secondName, patronymic, birth);
                                break;
                            }
                            else
                            {
                                user = new User(name, secondName, patronymic);
                                break;
                            }
                        }
                    }
                }
            } while (true);

            return user;
        }
        public virtual void Show() => Console.WriteLine($"Name = {Name}, SecondName = {SecondName}, Patronymic = {Patronymic}, BirthDay = {BirthDay}, Age = {Age}.");
        #endregion methods
    }
}
