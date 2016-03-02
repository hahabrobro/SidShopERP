using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Collections.Specialized;
using Microsoft.LightSwitch.Threading;
using System.Runtime.InteropServices.Automation;

namespace LightSwitchApplication
{
    public partial class eorderItemDetail
    {
        partial void eorderItem_Loaded(bool succeeded)
        {
            // 在這裡撰寫程式碼。
            this.SetDisplayNameFromEntity(this.eorderItem);
        }

        partial void eorderItem_Changed()
        {
            // 在這裡撰寫程式碼。
            this.SetDisplayNameFromEntity(this.eorderItem);
        }

        partial void eorderItemDetail_Saved()
        {
            // 在這裡撰寫程式碼。
            this.SetDisplayNameFromEntity(this.eorderItem);
        }

        partial void eorderItemDetail_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // 在這裡撰寫程式碼。
            
        }

        partial void eorderItemDetail_Activated()
        {
            // 撈出顧客預設的抬頭跟統編
            var v = this.DataWorkspace.inikierpData.invtitlecode.Where(o => o.customercodeItem1.cusID == eorderItem.customercodeItem1.cusID);
            this.發票抬頭選擇 = v.FirstOrDefault();
        }

        partial void eorderitem1_Changed(NotifyCollectionChangedEventArgs e)
        {

        }

        partial void eorderitem1_SelectionChanged()
        {
            this.SetDisplayNameFromEntity(this.eorderItem);
            //讓使用者點一下就會撈出單位跟品名
            try
            {
                //string s = eorderitem1.SelectedItem.ProdDesc;
                //double? ss = eorderitem1.SelectedItem.unitPrice * eorderitem1.SelectedItem.qty;

                //this.ShowMessageBox(eorderitem1.SelectedItem.unitPrice+"+" + eorderitem1.SelectedItem.qty.ToString());
            }
            catch
            {

            }
        }

        partial void 列印條碼_全__Execute()
        {
            Dispatchers.Main.BeginInvoke(() =>
            {
                Uri uri = new Uri("http://localhost:55724/Default.aspx?ODID="+eorderItem.odID+"&&ALL=YES", UriKind.RelativeOrAbsolute);

                if (AutomationFactory.IsAvailable)
                {
                    var shell = AutomationFactory.CreateObject("shell.application");
                    shell.shellExecute(uri.ToString());
                }
                else if (!System.Windows.Application.Current.IsRunningOutOfBrowser)
                {
                    System.Windows.Browser.HtmlPage.Window.Navigate(uri, "_blank");
                }
            });
        }

        partial void 列印條碼_挑選__Execute()
        {
            this.Save();
            Dispatchers.Main.BeginInvoke(() =>
            {
                Uri uri = new Uri("http://localhost:55724/Default.aspx?ODID=" + eorderItem.odID + "&&ALL=NO", UriKind.RelativeOrAbsolute);

                if (AutomationFactory.IsAvailable)
                {
                    var shell = AutomationFactory.CreateObject("shell.application");
                    shell.shellExecute(uri.ToString());
                }
                else if (!System.Windows.Application.Current.IsRunningOutOfBrowser)
                {
                    System.Windows.Browser.HtmlPage.Window.Navigate(uri, "_blank");
                }
            });
        }

        partial void eorderItemDetail_Saving(ref bool handled)
        {
            

        }

        
    }
}