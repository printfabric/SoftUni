using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace newWebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://www.introprogramming.info/wp-content/uploads/2015/10/Intro-CSharp-Book-v2015.pdf", "book.pdf");
                Process.Start("book.pdf");
        }
    }
}
