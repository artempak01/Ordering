using DevExpress.Xpo;
using Ordering.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering.Views
{
    public partial class OrdersView : UserControl
    {
        public OrdersView()
        {
            InitializeComponent();
            gridControl2.DataSource = new UnitOfWork().Query<Orders>();
        }

        private void addOrder(object sender, EventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            splitContainerControl1.Panel2.Controls.Add(new AddOrderView(this));
        }
    }
}
