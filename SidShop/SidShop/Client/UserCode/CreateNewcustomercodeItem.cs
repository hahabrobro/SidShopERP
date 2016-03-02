using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewcustomercodeItem
    {
        partial void CreateNewcustomercodeItem_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // 在這裡撰寫程式碼。
            this.customercodeItemProperty = new customercodeItem();

            this.customercodeItemProperty.buildDate = DateTime.Now;

        }
        partial void CreateNewcustomercodeItem_Saving(ref bool handled)
        {
            // 在這裡撰寫程式碼。
            if (String.IsNullOrEmpty(customercodeItemProperty.companyName))
            {
                //Hold住並且不讓程式繼續儲存。
                this.ShowMessageBox("尚未輸入公司全民");
                handled = true;
            }

        }
        partial void CreateNewcustomercodeItem_Saved()
        {
            // 在這裡撰寫程式碼。
            this.Close(false);
            Application.Current.ShoweorderItemDetail(eorder.SelectedItem.odID);
        }

        partial void eorderAddNew_CanExecute(ref bool result)
        {
            // 在這裡撰寫程式碼。

        }

        partial void eorderAddNew_Execute()
        {
            eorder.AddNew();

            eorder.SelectedItem.isClose = "N";
            eorder.SelectedItem.isMerger = "N";
            eorder.SelectedItem.isPayment = "N";
            eorder.SelectedItem.isTax = "Y";

            //語系關聯欄位預設值
            eorder.SelectedItem.langID = 2;

            //訂單狀態自訂下拉預設值
            eorder.SelectedItem.eStatusID = 4;

            //幣值自訂下拉預設值
            eorder.SelectedItem.curID = 1;

            //經辦人員關聯欄位預設值
            eorder.SelectedItem.eoClerk = Application.Empid;

            //var v = from n in DataWorkspace.inikierpData.employeecode where n.empAcc == Application.EmpUserAcc select new { n.empID };
            //foreach (var h in v)
            //{
            //    var t = h;

            //}

        }

        
    }
}