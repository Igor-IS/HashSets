using AcessSystem.Services;
using System;

namespace AcessSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FilesReader fileRead = new FilesReader();

            string file = @"C:\Git\HashSets\logs.txt";
            fileRead.OpenAndRead(file);
            fileRead.DisplayUsers();
        }
    }
}
