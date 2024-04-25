using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1.Classes
{
    // Класс ArticleConverter считается классом "Директор", отвечает за использование "конкретного строителя" (TXTtoXMLBuilder) для создания объекта "Продукт" (Article)
    public class ArticleConverter
    {
        private ArticleBuilder builder;

        public ArticleConverter(ArticleBuilder builder)
        {
            this.builder = builder;
        }

        public void ConvertTxtToXML(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                builder.SetTitle(lines[0]); // ожидается, что 1 строка в файле - заголовок
                builder.SetAuthor(lines[1]); // ожидается, что 2 строка в файле - автор
                builder.SetText(string.Join("\n", lines, 2, lines.Length - 3)); // ожидается, что 3 и далее строка в файле - содержимое статьи
                builder.SetHashCode(lines[lines.Length - 1]); // ожидается, что последняя строка в файле - хэш-код
            }
            else
            {
                throw new ArgumentException($"Файл не найден по указанному пути.\nТекущий путь: {filePath}");
            }
        }
    }
}
