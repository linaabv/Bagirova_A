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

namespace Bagirova_A
{
    /// <summary>
    /// Логика взаимодействия для Catalog_1.xaml
    /// </summary>
    public partial class Catalog_1 : Page
    {
        public Catalog_1()
        {
            InitializeComponent();
        }
        
        List<NewUser> Archive = new List<NewUser>();

        public void NewBudget(NewUser budget)
            {
                Archive.Add(budget);
                budget_box.Text = Archive.ToString();
            }

        private void go_button_Click(object sender, RoutedEventArgs e)
        {
            /*List<NewUser> Archive = new List<NewUser>();
            NewUser User = new NewUser(int.Parse(budget.Text));
            Archive.Add(User);*/
            try
            {
                int p = int.Parse(budget_box.Text);
                MessageBox.Show("Ваш бюджет - " + budget_box.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Введите бюджет");
            }
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int p = int.Parse(budget_box.Text);
                int result = p - 500;
                if (result>=0)
                {
                    MessageBox.Show("Ваш бюджет - " + result.ToString());
                    budget_box.Text = result.ToString();
                }
                else { MessageBox.Show("Невозможно произвести оплату"); }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно произвести оплату");
            }
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Catalog_2());
        }
    }
}
