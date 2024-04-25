using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{

    // Класс Article считается как класс "Продукт", определяет структуру данных, которая будет создаваться
    public class Article
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Text { get; set; }
        public string HashCode { get; set; }

        public override string ToString()
        {
            return $"\n<Article>\n\t<Title>{Title}</Title>\n\t<Authors>{Authors}</Authors>\n\t<Text>{Text}</Text>\n\t<HashCode>{HashCode}</HashCode>\n</Article>";
        }
    }
}
