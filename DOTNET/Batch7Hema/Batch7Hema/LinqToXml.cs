using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch7hema
{
    class LinqToXml
    { 
        public static void Main(string[] args) 
        {
            XDocument xdoc = XDocument.Load("d:\\Countries.xml");

            var countries = from country in xdoc.Descendants("countries").Elements("country").Attributes("name")
                            select country.Value;
            foreach (var country in countries)
            {
                Console.Write(country);
            }

        }
    }
}
