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
    public partial class AddGoodsView : UserControl
    {
        private GoodsView parentView { get; set; }
        public AddGoodsView(GoodsView parent)
        {
            InitializeComponent();
            parentView = parent;
        }

        private void AddGoods(object sender, EventArgs e)
        {

            using (var uow = new UnitOfWork())
            {
                var newGoods = new Goods(uow);
                newGoods.Name = textEdit1.Text;
                decimal sum;
                if (Decimal.TryParse(textEdit3.Text, out sum))
                {
                    newGoods.Price = sum;
                    uow.CommitChanges();
                }
                    parentView.updateDatasource();
                
            }
            textEdit1.Text = String.Empty;
            textEdit3.Text = String.Empty;
        }
    }
}
