using AcessSystem.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace AcessSystem.Services
{
    class FilesReader
    {
        public List<UserLog> ListOfLogsOfTheDay = new List<UserLog>();
        public HashSet<UserLog> SetNumberUsers = new HashSet<UserLog>();

        public void OpenAndRead(string file)
        {
            try
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(" ");
                        string name = vect[0];
                        DateTime instant = DateTime.Parse(vect[1]);

                        ListOfLogsOfTheDay.Add(new UserLog(name, instant));
                        SetNumberUsers.Add(new UserLog(name, instant));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DisplayLogs()
        {
            Console.WriteLine("Logs of the day");
            foreach (UserLog log in ListOfLogsOfTheDay)
            {
                Console.WriteLine(log);
            }
            Console.WriteLine();
        }

        public void DisplayUsers()
        {
            Console.WriteLine("Users of the day");
            foreach (UserLog client in SetNumberUsers)
            {
                Console.WriteLine(client);
            }
            Console.WriteLine($"Total users: {SetNumberUsers.Count}");
        }

    }
}
