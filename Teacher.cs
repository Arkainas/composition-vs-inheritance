using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition_vs_inheritance;

public class Teacher : User
{
    public Teacher(string username, string email) : base(username, email)
    {

    }
}
