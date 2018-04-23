using System.Collections.Generic;
using System.Windows.Controls;

namespace AgBook_CreatingTemplates {
    public class Order {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            List<Order> orderList = new List<Order>();

            orderList.Add(new Order() { CompanyName = "Rancho grande",
                City = "Buenos Aires", Country = "Argentina",
                Quantity = 92, UnitPrice = 576.55 });
            orderList.Add(new Order() { CompanyName = "Hanari Carnes",
                City = "Rio de Janeiro", Country = "Brazil",
                Quantity = 839, UnitPrice = 1396.10 });
            orderList.Add(new Order() { CompanyName = "Blondel père et fils",
                City = "Strasbourg", Country = "France",
                Quantity = 700, UnitPrice = 848.75 });
            orderList.Add(new Order() { CompanyName = "Blauer See Delikatessen",
                City = "Mannheim", Country = "Germany",
                Quantity = 140, UnitPrice = 347.05 });
            orderList.Add(new Order() { CompanyName = "Antonio Moreno Taquería",
                City = "México D.F.", Country = "Mexico",
                Quantity = 359, UnitPrice = 369.23 });

            book.DataSource = orderList;
        }
    }
}
