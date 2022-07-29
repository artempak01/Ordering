using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ordering.Shop;
namespace Ordering.Views
{
    public partial class AddClientView : UserControl
    {
        private ClientsView parentView { get; set; }
        public AddClientView(ClientsView parentView)
        {
            InitializeComponent();
            this.parentView = parentView;
        }

        private void AddClient(object sender, EventArgs e)
        {

            using (var uow = new UnitOfWork())
            {
                var Client = new Client(uow);
                Client.Name = textEdit1.Text;
                Client.email = textEdit2.Text;
                decimal sum;
                if (Decimal.TryParse(textEdit3.Text, out sum))
                {
                    Client.Sum = sum;
                }
                uow.CommitChanges();
                parentView.updateDatasource();
            }
            textEdit1.Text = String.Empty;
            textEdit2.Text = String.Empty;
            textEdit3.Text = String.Empty;
        }
    }
}
