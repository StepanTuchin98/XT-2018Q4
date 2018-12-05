using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task4.MyString
{
    public class MyString
    {
        public char[] Str { get; set; }
        #region ctors
        public MyString()
        {
        }
        public MyString(int length)
        {
            this.Str = new char[length];
        }
        public MyString(string str)
        {
            this.Str = str.ToCharArray();
        }
        public MyString(char[] str)
        {
            this.Str = str;
        }
        #endregion ctors

        #region methods

        public static MyString operator +(MyString s1, MyString s2)
        {
            var result = new MyString(s1.Str.Length + s2.Str.Length);
            s1.Str.CopyTo(result.Str, 0);
            s2.Str.CopyTo(result.Str, s1.Str.Length);
            return result;
        }

        public int Length => Str.Length;
        public MyString SubString(int firstPos, int secondPos)
        {
            MyString res = new MyString(this.Str.Length);
            if (Str.Length > secondPos && firstPos <= secondPos && firstPos >= 0)
            {
                for (int i = firstPos, j = 0; i <= secondPos; i++)
                {
                    res.Str[j] = this.Str[i];
                    j++;
                }
            }
            else
            {
                Console.WriteLine("Invalid indexs");
                return null;
            }

            return res;
        }

        public static bool operator !=(MyString s1, MyString s2)
        {
            if (s1.Str.Length != s2.Str.Length)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < s1.Str.Length; i++)
                {
                    if (s1.Str[i] != s2.Str[i])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator ==(MyString s1, MyString s2)
        {
            if (s1.Str.Length != s2.Str.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < s1.Str.Length; i++)
                {
                    if (s1.Str[i] != s2.Str[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static explicit operator MyString(string str)
        {
            return new MyString(str);
        }

        public static explicit operator string(MyString str)
        {
            return str.ToString();
        }

        public int? FirstIndexOf(char letter)
        {
            for (var i = 0; i < Str.Length; i++)
            {
                if (Str[i] == letter)
                {
                    return i;
                }
            }
            return null;
        }

        public int? LastIndexOf(char letter)
        {
            for (var i = Str.Length - 1; i >= 0 ; i--)
            {
                if (Str[i] == letter)
                {
                    return i;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return string.Concat(this.Str);
        }

        public override bool Equals(object obj)
        {
            var @string = obj as MyString;
            return @string != null &&
                   EqualityComparer<char[]>.Default.Equals(Str, @string.Str);
        }

        public override int GetHashCode()
        {
            return -197932880 + EqualityComparer<char[]>.Default.GetHashCode(Str);
        }
        #endregion methods
    }
}
