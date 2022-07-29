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
    public partial class EditClientView : UserControl
    {
        public Client curientClient { get; set; }
        private ClientsView parentView;
        public EditClientView(Client client, ClientsView parentView)
        {
            InitializeComponent();
            this.parentView = parentView;
            curientClient = client;
            textEdit1.Text = curientClient.Name;
            textEdit2.Text = curientClient.email;
            textEdit3.Text = curientClient.Sum.ToString();
        }

        private void saveClient(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                curientClient = uow.Query<Client>().FirstOrDefault(s => s.ID == curientClient.ID);
                if (curientClient != null)
                {
                    curientClient.Name = textEdit1.Text;
                    curientClient.email = textEdit2.Text;
                    decimal sum;
                    if (Decimal.TryParse(textEdit3.Text, out sum))
                    {
                        curientClient.Sum = sum;
                    }

                    curientClient.Save();
                    uow.CommitChanges();
                }
                parentView.updateDatasource();
            }
        }

        private void delateClient(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                curientClient = uow.Query<Client>().FirstOrDefault(s => s.ID == curientClient.ID);
                if (curientClient != null)
                {
                    curientClient.Delete();
                    uow.CommitChanges();
                }
                parentView.updateDatasource();
            }
        }
    }
}
