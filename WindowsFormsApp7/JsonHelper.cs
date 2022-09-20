using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace WindowsFormsApp7
{
    public static class JsonHelper
    {
        public static void Serialize(Person person)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("person.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, person);
                }
            }

        }
    }
}
