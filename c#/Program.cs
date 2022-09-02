using System;
using c_;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario("Jango", "batatinha123");
            Usuario q = new Usuario("Luiz", "123");
            Usuario r = new Usuario("henrique", "batatinha");
            Console.WriteLine(u.Serialize());
            UserBase myBase = new UserBase("userbase.txt");
            myBase.AddUser(u);
            myBase.AddUser(q);
            myBase.AddUser(r);
            myBase.Save();
        }       
    }
}
