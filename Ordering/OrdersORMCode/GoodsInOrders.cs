using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Ordering.Shop
{

    public partial class GoodsInOrders
    {
        public GoodsInOrders(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
