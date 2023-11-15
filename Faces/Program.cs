// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Net.Mime;
using Faces;

namespace BettingOddsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Finder finder = new Finder();
            List<string> paths = finder.DownloadPictures(3);
            
            //Bitmap image = new Bitmap(@"Photos/Photo0.png");
        }
    }
}