using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Task1.Classes;

namespace Task1
{
    public partial class Form1 : Form
    {
        private TXTtoXMLBuilder _builder;
        private ArticleConverter _converter;
        private Article _article;

        private string _filePath;
        private string _saveFilePath;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
        }

        private void BttnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            _filePath = openFileDialog1.FileName;

            richTextBox1.Text = File.ReadAllText(_filePath);

            label1.Text = $"Путь файла: {_filePath}";
        }

        private void BttnTxtToXml_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            _saveFilePath = saveFileDialog1.FileName;

            if (_builder == null)
                _builder = new TXTtoXMLBuilder();

            if (_converter == null)
                _converter = new ArticleConverter(_builder);

            _article = _builder.Article;

            try
            {
                _converter.ConvertTxtToXML(_filePath);
                string xmlContent = _article.ToString();

                WriteToXml(_saveFilePath, xmlContent);
                MessageBox.Show($"Успешно сохранено по пути {_saveFilePath}.", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void WriteToXml(string filePath, string xmlContent)
        {
            using (XmlWriter writer = XmlWriter.Create(filePath))
            {
                writer.WriteRaw(xmlContent);
            }
        }
    }
}
