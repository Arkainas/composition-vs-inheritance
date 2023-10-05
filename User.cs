using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace composition_vs_inheritance;

public class User
{
    public string FirstName;
    public string LastName;
    public readonly string UserName;
    public string Email;
    public string DOB;
    private string _password;

    public User(string username, string email)
    {
        UserName = username;
        Email = email;
    }

    public bool UploadNews(string title, string content)
    {
        
        if (content.Length > 0)
        {
            Console.WriteLine("Uploaded news: " + title);
            return true;
        }
        else
        {
            return false;
        }
    }

    public int Age()
    {
        throw new NotImplementedException();
    }
}
