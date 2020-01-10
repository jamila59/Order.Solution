using Microsoft.AspNetCore.Mvc;

namespace Template.Models
{
  public class Class
  {
    public string Test1 { get; set; }
    public string Test2 { get; set; }

    public Class(string test1, string test2)
    {
        Test1 = test1;
        Test2 = test2;
    }
    //Here we have the constructors that will be passed into our route then to our main page
  }
}