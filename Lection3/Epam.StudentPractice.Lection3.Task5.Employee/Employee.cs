using Epam.StudentPractice.Lection3.Task3.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employee
{
    public class Employee : User
    {
        private int quality;
        public string Post { get; set; } = "Junior";

        public int Quality
        {
            get => quality;
            set
            {
                if(value > 0)
                {
                    quality = value;
                }
                else
                {
                    throw new Exception("Quality should be possitive number");
                }
            }
        }
        public Employee():base() { }

        public Employee(string post, int quality, string secondName, string name, string patronymic, DateTime birthDay) : base(secondName, name, patronymic, birthDay)
        {
            Post = post;
            Quality = quality;
        }
        public Employee(string post, int quality, string secondName, string name, string patronymic) : base(secondName, name, patronymic)
        {
            Post = post;
            Quality = quality;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Quality = {Quality}, Post = {Post}");
        }
    }
}
