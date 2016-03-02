using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class inikierpDataService
    {

        partial void eorder_Inserted(eorderItem entity)
        {
            entity.orderNo = DateTime.Now.ToString("yyyyMMdd")+ entity.odID;
        }

        partial void eorderitem_Inserting(eorderitemItem entity)
        {
            //entity.iunitDesc = entity.Unit;
            //if (entity.unitPrice == null)
            //{
            //    entity.unitPrice = entity.Price * entity.qty;
            //}
            //else
            //{
                
            //}
        }

        

    }
}
