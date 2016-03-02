using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class eorderitemItem
    {
        public short? PUnitID;
        public short? BUnitID;
        partial void ProdDesc_Compute(ref string result)
        {
            // TODO:利用ProdID去Productcode表去撈出條碼來
            //var v = this.DataWorkspace.inikierpData.productcode.Where(o => o.prodID == productcodeItem.prodID).Execute().Select(o => new { o.prodDesc }).FirstOrDefault();

            result = productcodeItem.prodDesc;
        }
        partial void SubTotal_Compute(ref int result)
        {
            //TODO:數量*稅後金額=小計
            result = Convert.ToInt32(qty * unitPrice);
        }
        //TODO:eorderitem有新增或變更的時後重新去產品資料表撈商品的價格，
        //簡單來講就是打完條碼想讓其他欄位自動填入該填的值，來這裡撈，來這裡寫就對了
        partial void productcodeItem_Changed()
        {
            //撈出對應條碼的商品價格
            var v = DataWorkspace.inikierpData.productcode.Where(o => o.prodID == productcodeItem.prodID);
            foreach (var y in v.Execute())
            {
                //把撈出來的商品價格值給入對應欄位
                this.unitPrice = y.prodSellPrice;

                //讓數量值預設為1 20160108拿掉
                //this.qty = 1;

                //先撈出對應商品單位的fk欄位值

                //PUNITID==包裝單位
                PUnitID = y.pUnitID;

                //BUINTID==基本單位
                BUnitID = y.bUnitID;
            }
            //撈出對應條碼的商品單位

            //如果包裝單位的資料是0，給予此商品基本單位的值
            if (PUnitID == 0)
            {
                var g = DataWorkspace.inikierpData.unitcode.Where(o => o.unitID == BUnitID).Execute();
                foreach (var z in g)
                {
                    //把撈出來的商品單位值給入對應欄位
                    this.iunitDesc = z.unitDesc;
                }
            }
            //如果包裝單位不等於0，給予此商品"包"的包裝單位
            else
            {
                //var g = DataWorkspace.inikierpData.punitcode.Where(o => o.pUnitID == PUnitID).Execute();
                //foreach (var z in g)
                //{
                this.iunitDesc = "包";
                //}
            }
        }
    }
}
