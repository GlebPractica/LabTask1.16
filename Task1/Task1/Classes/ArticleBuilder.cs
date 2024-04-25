using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{

    // Класс ArticleBuilder считается классом Builder, он может быть как абстрактным, так и интерфейсом, содержит базовые методы для работы с "Продуктом" (Article)
    public abstract class ArticleBuilder
    {
        protected Article article;

        public Article Article => article;

        public abstract void SetTitle(string title);
        public abstract void SetAuthor(string author);
        public abstract void SetText(string text);
        public abstract void SetHashCode(string hashCode);
    }
}
