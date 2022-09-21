using _4_TemplateMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_TemplateMethod.Implementations
{
    public class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Идём в первый класс");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Посещаем уроки, делаем домашние задания");
        }

        public override void Study()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании");
        }
    }
}
