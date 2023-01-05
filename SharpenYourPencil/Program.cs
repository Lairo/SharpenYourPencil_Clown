using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenYourPencil
{
    internal class Program
    {
        static void Main()
        {
            Clown oneClown = new Clown();
            oneClown.Name = "Boffo";
            oneClown.Height = 14;
            oneClown.TalkAboutYourself();

            Clown anotherClown = new Clown();
            anotherClown.Name = "Biff";
            anotherClown.Height = 16;
            anotherClown.TalkAboutYourself();

            Clown clown3 = new Clown();
            clown3.Name = anotherClown.Name;
            clown3.Height = oneClown.Height - 3;
            clown3.TalkAboutYourself();

            anotherClown.Height *= 2;
            anotherClown.TalkAboutYourself();

            oneClown.Height = 70;
            clown3.Height = oneClown.Height - 3;
            oneClown.TalkAboutYourself();
            clown3.TalkAboutYourself();
        }
    }
}
