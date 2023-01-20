using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Tiunov
{
    public partial class Statistics : Form
    {
        private Word.Application application;
        Word.Document document;
        Word.Paragraph wordparagraph;
        public Statistics()
        {
            InitializeComponent();
        }
        private void exportToWord_Click(object sender, EventArgs e)
        {
            //Создание нового документа Word
            document = application.Documents.Add();
            //Добавление нового параграфа документа Word
            wordparagraph = document.Paragraphs.Add();
            wordparagraph.Range.Text = "Статистика реставраций";
            //Красный цвет шрифта
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorDarkRed;
            //Размер 20, Тип шрифта Arial, курсив и полужирный
            wordparagraph.Range.Font.Size = 18;
            wordparagraph.Range.Font.Name = "Arial";
            wordparagraph.Range.Font.Italic = 1;
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph = document.Paragraphs.Add();
            wordparagraph = document.Paragraphs[2];
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorBlack;
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph.Range.Font.Italic = 0;
            Word.Range wordrange = wordparagraph.Range;
            var row = tiunovDataSet.StatRest.Rows.Count;
            var col = tiunovDataSet.StatRest.Columns.Count;
            Word.Table wordtable1 = document.Tables.Add(wordrange, row+1, col);
            Word.Range wordcellrange = document.Tables[1].Cell(1, 2).Range;
            wordtable1.Range.Font.Size = 12;
            wordtable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
            wordtable1.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            wordtable1.Rows[1].Range.Font.Color = Word.WdColor.wdColorBlue;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    //Занести заголовки полей в ячейку
                    wordcellrange = document.Tables[1].Cell(1, i + 1).Range;
                    wordcellrange.Text = tiunovDataSet.StatRest.Columns[i].ToString();
                    //Занести данные в ячейки
                    wordcellrange = document.Tables[1].Cell(j+2, i+1).Range;
                    wordcellrange.Text = tiunovDataSet.StatRest.Rows[j][i].ToString();
                }
            }
        }
        private void exportToWord_2_Click(object sender, EventArgs e)
        {
            application = new Word.Application
            {
                Visible = true
            };
            //Создание нового документа Word
            document = application.Documents.Add();
            //Добавление нового параграфа документа Word
            wordparagraph = document.Paragraphs.Add();
            wordparagraph.Range.Text = "Статистика приобретения экспонатов";
            //Красный цвет шрифта
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorDarkRed;
            //Размер 18, Тип шрифта Arial, курсив и полужирный
            wordparagraph.Range.Font.Size = 18;
            wordparagraph.Range.Font.Name = "Arial";
            wordparagraph.Range.Font.Italic = 1;
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph = document.Paragraphs.Add();
            wordparagraph = document.Paragraphs[2];
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorBlack;
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph.Range.Font.Italic = 0;
            Word.Range wordrange = wordparagraph.Range;
            var row = tiunovDataSet.StatExp.Rows.Count;
            var col = tiunovDataSet.StatExp.Columns.Count;
            Word.Table wordtable1 = document.Tables.Add(wordrange, row + 1, col);
            Word.Range wordcellrange = document.Tables[1].Cell(1, 2).Range;
            wordtable1.Range.Font.Size = 12;
            wordtable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
            wordtable1.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            wordtable1.Rows[1].Range.Font.Color = Word.WdColor.wdColorBlue;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    //Занести заголовки полей в ячейку
                    wordcellrange = document.Tables[1].Cell(1, i + 1).Range;
                    wordcellrange.Text = tiunovDataSet.StatExp.Columns[i].ToString();
                    //Занести данные в ячейки
                    wordcellrange = document.Tables[1].Cell(j + 2, i + 1).Range;
                    wordcellrange.Text = tiunovDataSet.StatExp.Rows[j][i].ToString();
                }
            }
        }
        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.StatExp". При необходимости она может быть перемещена или удалена.
            this.statExpTableAdapter.Fill(this.tiunovDataSet.StatExp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.StatRest". При необходимости она может быть перемещена или удалена.
            this.statRestTableAdapter.Fill(this.tiunovDataSet.StatRest);
        }
    }
}
