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
    public partial class eorderitemItemDetail
    {
        partial void eorderitemItem_Loaded(bool succeeded)
        {
            // 在這裡撰寫程式碼。
            this.SetDisplayNameFromEntity(this.eorderitemItem);
        }

        partial void eorderitemItem_Changed()
        {
            // 在這裡撰寫程式碼。
            this.SetDisplayNameFromEntity(this.eorderitemItem);
        }

        partial void eorderitemItemDetail_Saved()
        {
            // 在這裡撰寫程式碼。
            this.SetDisplayNameFromEntity(this.eorderitemItem);
        }
    }
}