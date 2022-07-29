using DevExpress.Xpo;
using Ordering.Shop;
using System;
using System.Collections.Generic;
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
    public partial class GoodsView : UserControl
    {
        public Goods curientGoods { get; set; }
        public GoodsView()
        {
            InitializeComponent();
            XpoDefault.DataLayer =
                           XpoDefault.GetDataLayer(ConfigurationManager.ConnectionStrings["Shop"].ConnectionString.Replace("|DataDirectory|", Directory.GetCurrentDirectory()),
                           DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);

            gridControl1.DataSource = new UnitOfWork().Query<Goods>();
        }

        private void addGoods(object sender, EventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            splitContainerControl1.Panel2.Controls.Add(new AddGoodsView(this));
        }
        public void updateDatasource()
        {
            gridControl1.DataSource = new UnitOfWork().Query<Goods>();
        }

        private void chooseGoods(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int selectedGoods = gridView1.FocusedRowHandle;
            curientGoods = gridView1.GetRow(selectedGoods) as Goods;
            splitContainerControl1.Panel2.Controls.Clear();
            splitContainerControl1.Panel2.Controls.Add(new EditGoodsView(curientGoods, this));
        }
    }
}
