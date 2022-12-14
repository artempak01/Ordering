//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Ordering.Shop
{

    public partial class Goods : XPLiteObject
    {
        long fID;
        [Key(true)]
        public long ID
        {
            get { return fID; }
            set { SetPropertyValue<long>(nameof(ID), ref fID, value); }
        }
        string fName;
        [Size(SizeAttribute.Unlimited)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        decimal fPrice;
        [ColumnDbDefaultValue("'0,0'")]
        public decimal Price
        {
            get { return fPrice; }
            set { SetPropertyValue<decimal>(nameof(Price), ref fPrice, value); }
        }
        [Association(@"GoodsInOrdersReferencesGoods")]
        public XPCollection<GoodsInOrders> GoodsInOrdersCollection { get { return GetCollection<GoodsInOrders>(nameof(GoodsInOrdersCollection)); } }
    }

}
