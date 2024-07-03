using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Library
{
    internal class HelpAttribute : Attribute
    {
        private string _url;

        private string _topic;

        public HelpAttribute(string url) => _url = url;


        public string URL => _url;

        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }


    }


    [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features")]
    class Frame
    {

        [Help(url: "https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features", Topic ="Display")]
        public void Display() { }
    }
}
