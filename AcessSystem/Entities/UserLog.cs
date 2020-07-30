using System;
using System.Collections.Generic;
using System.Text;

namespace AcessSystem.Entities
{
    class UserLog : IComparable
    {
        public string Name { get; private set; }
        public DateTime Instant { get; private set; }

        public UserLog(string name, DateTime instant)
        {
            Name = name;
            Instant = instant;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is UserLog))
            {
                throw new ArgumentException("An error occurred: Argument is not an UserLog");
            }
            UserLog other = obj as UserLog;
            return Instant.CompareTo(other.Instant);
        }

        public override string ToString()
        {
            return "User: " + Name + " - " + Instant;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is UserLog))
            {
                return false;
            }
            UserLog other = obj as UserLog;
            return Name.Equals(other.Name);
        }
    }
}
