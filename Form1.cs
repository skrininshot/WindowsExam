using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsExam
{
    public partial class Form1 : Form
    {
        private double[] typesPrices = new double[5]; //массив цен
        private string[] typesNames = new string[5]; //массив цен
        private double[] serviesPrices = new double[3]; //массив цен
        private int selectedType; //Выбранный тип
        private int sqaure; //Площадь
        private double totalPrice; //Полная стоимость
        private int selectedService; //Выбранная услуга
        private string productName; //Выбранная услуга

        public Form1()
        {
            InitializeComponent();
            cbServices.SelectedIndex = 0;

            //Заполняем массив типов значениями
            typesPrices[0] = 1000; //Глухое
            typesPrices[1] = 3400.5; //Поворотное 
            typesPrices[2] = 2560; //Откидное
            typesPrices[3] = 7900.9; //Фрамужное
            typesPrices[4] = 6210.5; //Раздвижное

            //Заполняем массив услуг значениями
            serviesPrices[0] = 1;
            serviesPrices[1] = 5000;
            serviesPrices[2] = 3000;

            //Заполняем массив имен типов
            typesNames[0] = "Глухое";
            typesNames[1] = "Поворотное";
            typesNames[2] = "Откидное";
            typesNames[3] = "Фрамужное";
            typesNames[4] = "Раздвижное";
        }

        //Добавление картинки на форму
        private void btAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            { 
                pbAddPhoto.ImageLocation = open.FileName;
            }
        }

        //Ввод только цифр
        private void tbDigitInput(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') 
                return;
            else
                e.Handled = true;
        }

        //Рассчёт
        private void Calculation()
        {
            if (numWidth.Value == 0 || numHeight.Value == 0)
                MessageBox.Show("Для ширины или высоты недопустимо значение 0!");

            selectedType = GetSelectedRadioButton();
            sqaure = ((int)numWidth.Value / 100) * ((int)numHeight.Value / 100);
            selectedService = cbServices.SelectedIndex;

            switch (selectedService)
            {
                case 0://Окна
                    productName = typesNames[selectedType];
                    totalPrice = typesPrices[selectedType] * sqaure;
                    tbTotal.Text = $"{typesPrices[selectedType]} * {sqaure} м^2";
                    break;

                case 1: //Балконы
                    productName = "Балконы";
                    totalPrice = serviesPrices[selectedService] * sqaure;
                    tbTotal.Text = $"{serviesPrices[selectedService]} * {sqaure} м^2";
                    break;

                case 2: //Двери
                    productName = "Двери";
                    totalPrice = serviesPrices[selectedService] * sqaure;
                    tbTotal.Text = $"{serviesPrices[selectedService]} * {sqaure} м^2";
                    break;
            }
            
            tbTotal.Text += " Стоимость: " + totalPrice.ToString() + " рублей";
        }

        //Получить выделенный radioButton
        private int GetSelectedRadioButton()
        {
            if (rb1Gluhoe.Checked)
                return 0;

            if (rb2Povorotnoe.Checked)
                return 1;

            if (rb3Otkidnoe.Checked)
                return 2;

            if (rb4Framuzhnoe.Checked)
                return 3;

            if (rb5Razdvizhnoe.Checked)
                return 4;

            return -1;
        }

        //По нажатию на кнопку рассчёт
        private void btRasschet_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        //По нажатию на кнопку "Сформировать отчёт"
        private void FeedReceipt(object sender, EventArgs e)
        {
            Calculation();

            Random rand = new Random();
            string randId = "";

            for (int i = 0; i < 5; i++)
                randId += rand.Next(10).ToString();

            var helper = new WordHelper("report.docx");
            var items = new Dictionary<string, string>
            {
                { "{Уникальный_номер}", randId },
                { "{Дата}", DateTime.Now.ToString("dd.MM.yy") },
                { "{Товар}", productName },
                { "{итог}", totalPrice.ToString() }
            };

            helper.Process(items);
        }
    }
}