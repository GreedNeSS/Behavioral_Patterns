using _4_TemplateMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_TemplateMethod.Implementations
{
    public class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
        }

        public override void PassExams()
        {
            Console.WriteLine("Сдаем экзамен по специальности");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем диплом о высшем образовании");
        }
    }
}
