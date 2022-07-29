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
    public partial class EditGoodsView : UserControl
    {
        private GoodsView parentView;
        public Goods curientGoods { get; set; }
        public EditGoodsView(Goods goods, GoodsView view)
        {
            InitializeComponent();
            parentView = view;
            curientGoods = goods;
            textEdit1.Text = goods.Name;
            textEdit2.Text = goods.Price.ToString();
        }

        private void saveGoods(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                curientGoods = uow.Query<Goods>().FirstOrDefault(s => s.ID == curientGoods.ID);
                if (curientGoods != null)
                {
                    curientGoods.Name = textEdit1.Text;
                    decimal sum;
                    if (Decimal.TryParse(textEdit2.Text, out sum))
                    {
                        curientGoods.Price = sum;
                        curientGoods.Save();
                        uow.CommitChanges();
                    }      
                }
                parentView.updateDatasource();
            }
        }

        private void deleteGoods(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                curientGoods = uow.Query<Goods>().FirstOrDefault(s => s.ID == curientGoods.ID);
                if (curientGoods != null)
                {
                    curientGoods.Delete();
                    uow.CommitChanges();
                }
                parentView.updateDatasource();
            }
        }
    }
}
