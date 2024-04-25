using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    // Класс TXTtoXMLBuilder считается "конкретным строителем", определенная реализация уже заготовленных методов в "Строителе" (ArticleBuilder)
    public class TXTtoXMLBuilder : ArticleBuilder
    {
        public TXTtoXMLBuilder() 
        {
            article = new Article();
        }

        public override void SetAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
                article.Authors = "Unkown author...";
            else
                article.Authors = author;
        }

        public override void SetHashCode(string hashCode)
        {
            if (string.IsNullOrWhiteSpace(hashCode))
                article.HashCode = "None hashCode...";
            else
                article.HashCode = hashCode;
        }

        public override void SetText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                article.Text = "Unkown or none text...";
            else
                article.Text = text;
        }

        public override void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                article.Title = "Unkown or none title...";
            else
                article.Title = title;
        }
    }
}
