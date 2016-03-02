using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Threading;
using System.Runtime.InteropServices.Automation;
namespace LightSwitchApplication
{
    public partial class SearchProductCodeQuery
    {
        partial void Search_Execute()
        {
            // 在這裡撰寫程式碼。
            this.ProductCodeQuery.Load();
        }

        partial void PrintBarcode_Execute()
        {
            if (String.IsNullOrEmpty(Count) || String.IsNullOrEmpty(ProductCodeQuery.SelectedItem.prodDesc))
            {
                this.ShowMessageBox("尚未輸入列印數量");
            }else
            {
                dynamic MsgResult =this.ShowMessageBox("確定要列印" + ProductCodeQuery.SelectedItem.prodDesc+Count+"張", "注意!", MessageBoxOption.YesNo);
                //this.ShowMessageBox(Count+ProductCodeQuery.SelectedItem.prodDesc);
                if (MsgResult == System.Windows.MessageBoxResult.Yes)
                {
                    Dispatchers.Main.BeginInvoke(() =>
                    {
                        Uri uri = new Uri("http://localhost:55724/PrintProductBarcode.aspx?prodid=" + ProductCodeQuery.SelectedItem.prodID + "&&count=" + Count, UriKind.RelativeOrAbsolute);

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
                else
                {
                    
                }
            }
        }
    }
}
