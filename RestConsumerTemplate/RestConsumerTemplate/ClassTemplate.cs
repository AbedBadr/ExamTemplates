﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestConsumerTemplate
{
    class ClassTemplate
    {
        public int Id { get; set; }

        public ClassTemplate(int id)
        {
            Id = id;
        }

        public ClassTemplate()
        {
            
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}";
        }
    }
}
