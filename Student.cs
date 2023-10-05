using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition_vs_inheritance;

public class Student : User
{
    public string Klass;
    public Student(string username, string email, string klass) : base(username, email)
    {
        Klass = klass;
    }
}
