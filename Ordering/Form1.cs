using DevExpress.Xpo;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraBars;
using System.Configuration;
using Ordering.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Ordering.Views;
namespace Ordering
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void showClients(object sender, EventArgs e)
        {
            ViewsStackPanel.Controls.Clear();
              ViewsStackPanel.Controls.Add(new ClientsView());
        }

        private void showOrders(object sender, EventArgs e)
        {
            ViewsStackPanel.Controls.Clear();
            ViewsStackPanel.Controls.Add(new OrdersView());
        }

        private void showGoods(object sender, EventArgs e)
        {
            ViewsStackPanel.Controls.Clear();
            ViewsStackPanel.Controls.Add(new GoodsView());

        }
    }
}
