using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class eorderItem
    {
        partial void CountTotal_Compute(ref int result)
        {
            // TODO:先用Lambda撈出對印該筆主檔的資料，抓到各商品細項的數量與稅後金額，跑Foreach不斷累加，得到稅後總金額放入result

            var v = DataWorkspace.inikierpData.eorderitem.Where(o => o.eorderItem1.odID == this.odID).Execute().Select(o => new { o.unitPrice, o.qty });
            //var v = (from n in DataWorkspace.inikierpData.eorderitem where n.eorderItem1.odID == this.odID select new { n.unitPrice, n.qty }).Execute().ToList() ;

            foreach (var g in v)
            {
                result += Convert.ToInt32(g.unitPrice * g.qty);
            }
        }

        partial void CountNoTax_Compute(ref int result)
        {
            //TODO:把稅後金額/1.05=未稅價
            result = Convert.ToInt32(CountTotal / 1.05);
        }

        partial void CountTax_Compute(ref int result)
        {
            //TODO:未稅價*0.05=稅額
            result = Convert.ToInt32(CountNoTax * 0.05);
        }
    }
}
