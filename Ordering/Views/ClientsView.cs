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
    public partial class ClientsView : UserControl
    {
        public Client curientClient { get; set; }
        public ClientsView()
        {
            InitializeComponent();
            XpoDefault.DataLayer =
                            XpoDefault.GetDataLayer(ConfigurationManager.ConnectionStrings["Shop"].ConnectionString.Replace("|DataDirectory|", Directory.GetCurrentDirectory()),
                            DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);

            gridControl2.DataSource = new UnitOfWork().Query<Client>();

        }

        private void addClient(object sender, EventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            splitContainerControl1.Panel2.Controls.Add(new AddClientView(this));
        }
        public void updateDatasource()
        {
            gridControl2.DataSource = new UnitOfWork().Query<Client>();
        }


        private void chooseClient(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int selectedClient = gridView2.FocusedRowHandle;
            curientClient = gridView2.GetRow(selectedClient) as Client;
            splitContainerControl1.Panel2.Controls.Clear();
            splitContainerControl1.Panel2.Controls.Add(new EditClientView(curientClient, this));
              
        }
    }
}
