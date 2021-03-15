//
// 
// CREATED BY 70K51K GANG (K15K4)
//
// ДЕДЛАЙН СРЕДА

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KAPTUNO4KA
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
            panelka.ReadOnly = true; //Значение текстбокса только для чтения
        }

        public void InsertButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                int x, y;
                x =LoadedImage.Size.Width; //Ширина картинки
                y = LoadedImage.Size.Height; // Высота картинки
                LoadedImage.Image = new Bitmap(ofd.FileName);
                LoadedImage.SizeMode = PictureBoxSizeMode.Zoom; //Задает размер изображения в форме
                this.Size = new System.Drawing.Size(x, y+30); //Форма подстраивается под картинку
                this.BackgroundImage = new Bitmap(LoadedImage.Image); //Ставит картинку на фон формы
                LoadedImage.Visible = false; //Скрывает picture box
            }
        }
       
        private void ColorForm_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(LoadedImage.Image);
            panelka.BackColor = image.GetPixel(Control.MousePosition.X - Location.X - 8,
                                Control.MousePosition.Y - Location.Y - 30); // Определяет цвет пикселя и закрашивает этим цветом текст бокс
            int color = panelka.BackColor.ToArgb(); //Считывает цвет текст бокса и записывает в переменную 
            RGB.Text = Convert.ToString(Color.FromArgb(color)); //Переводит значение цвета в стринг и присваивает его текстовое значение лейблу
        }   
    }
}
