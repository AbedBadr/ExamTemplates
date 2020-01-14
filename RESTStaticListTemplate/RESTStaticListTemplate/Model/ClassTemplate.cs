using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTStaticListTemplate.Model
{
    public class ClassTemplate
    {
        public int Id { get; set; }
        public string Test { get; set; }

        public ClassTemplate(int id, string test)
        {
            Id = id;
            Test = test;
        }

        public ClassTemplate()
        {
            
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Test)}: {Test}";
        }
    }
}
