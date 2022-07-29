using DevExpress.Xpo;
using Ordering.Shop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering.Views
{
    

    public partial class AddOrderView : UserControl
    {
        public OrdersView ordersView { get; set; }
        UnitOfWork uow;
        public Orders newOrder { get; set; }
        public ObservableCollection<KeyValuePair<Goods, int>> GIO { get; set; } = new ObservableCollection<KeyValuePair<Goods, int>>();
        public AddOrderView(OrdersView view)
        {
            InitializeComponent();
            ordersView = view;
            XpoDefault.DataLayer =
                XpoDefault.GetDataLayer(ConfigurationManager.ConnectionStrings["Shop"].ConnectionString.Replace("|DataDirectory|", Directory.GetCurrentDirectory()),
                DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            uow = new UnitOfWork();
            newOrder = new Orders(uow);
            var goods = uow.Query<Goods>().ToList();
            foreach(var item in goods)
                comboBox8.Items.Add(item.Name);
            var Clients = uow.Query<Client>().ToList();
            foreach (var item in Clients)
                comboBox1.Items.Add(item.ID);
            textEdit3.Text = DateTime.Now.ToShortDateString();
            textEdit19.Text = "0";
            gridControl1.DataSource = GIO;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void addGoodsToOrder(object sender, EventArgs e)
        {
            Goods good = uow.Query<Goods>().FirstOrDefault(s => s.Name == comboBox8.SelectedItem.ToString());
            int amount = 0;
            decimal Summ = 0;
            int.TryParse(textEdit1.Text, out amount);
            if (amount > 0)
            {
                var goods = GIO.FirstOrDefault(s => s.Key.ID == good.ID);
                if (goods.Key != null)
                {
                    if (decimal.TryParse(textEdit19.Text, out Summ))
                    {
                        Summ += amount * good.Price;
                        textEdit19.Text = Summ.ToString();
                    }
                    amount += GIO.First(s => s.Key.ID == good.ID).Value;
                    GIO.Remove(goods);
                    GIO.Add(new KeyValuePair<Goods, int>(goods.Key, amount));
                   
                }
                else
                {
                    GIO.Add(new KeyValuePair<Goods, int>(good, amount));
                    if (decimal.TryParse(textEdit19.Text, out Summ))
                    {
                        Summ += amount * good.Price;
                        textEdit19.Text = Summ.ToString();
                    }
                }
            }
        }

        private void fillClient(object sender, EventArgs e)
        {
            Client client = uow.Query<Client>().FirstOrDefault(s => s.ID.ToString().Equals(comboBox1.SelectedItem.ToString()));
            textEdit4.Text = client.Name;
            newOrder.Client = client;
        }

        private void saveNewOrder(object sender, EventArgs e)
        {

            newOrder.Date = DateTime.Parse(textEdit3.Text).ToShortDateString();
            newOrder.Save();
            uow.CommitChangesAsync();
        }
    }
}
