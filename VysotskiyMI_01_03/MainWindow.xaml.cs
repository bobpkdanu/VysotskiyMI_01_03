using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VysotskiyMI_01_03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        MobileOperatorP mob = new MobileOperatorP();

        private void addBtn_Click(object sender, RoutedEventArgs e)//События при нажатии кнопки
        {
            try
            {
                if (nameText.Text == "" || priceText.Text == "" || ploshText.Text == "")//Проверка на пустоту
                {
                    MessageBox.Show("Обнаружены пустые поля");
                    return;
                }

                foreach (char ch in priceText.Text)//Проверка на числа
                {
                    if (!char.IsDigit(ch))
                    {
                        MessageBox.Show("Допускаются только цифры");
                        return;
                    }
                }

                foreach (char ch in ploshText.Text)
                {
                    if (!char.IsDigit(ch))
                    {
                        MessageBox.Show("Допускаются только цифры");
                        return;
                    }
                }

                mob.Qfunc(nameText.Text, double.Parse(priceText.Text), double.Parse(ploshText.Text));//Вызов функции для вычисления Q
                QText.Text = $"Q оператора: {mob.operQ.ToString()}";

                bool checkP;

                if ((bool)checkPay.IsChecked)//Проверка checkBox, для вычисления Qp
                {
                    checkP = true;
                    mob.QPFunc(checkP);
                    QpText.Text = $"Qp оператора: {mob.Qp.ToString()}";
                }
                else
                {
                    checkP = false;
                    mob.QPFunc(checkP);
                    QpText.Text = $"Qp оператора: {mob.Qp.ToString()}";
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
                return;
            }
        }
    }
}
