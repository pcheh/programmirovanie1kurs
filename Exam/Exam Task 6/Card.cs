using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Task_6
{
    class Card
    {
        public string Color { get; }
        public string Value { get; }
        public Card(string color, string value)
        {
            Color = color;
            Value = value;
        }
    }
}
