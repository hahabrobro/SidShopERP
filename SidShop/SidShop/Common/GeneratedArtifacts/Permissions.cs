﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    /// <summary>
    /// Defines the names of the application permissions.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static class Permissions
    {
        /// <summary>
        /// 提供管理應用程式安全性的功能。
        /// </summary>
        public const string SecurityAdministration = global::Microsoft.LightSwitch.Security.ApplicationPermissions.SecurityAdministration;

        /// <summary>
        /// 取得為應用程式定義的所有權限。這包括系統和使用者定義權限。
        /// </summary>
        public static global::System.Collections.ObjectModel.ReadOnlyCollection<string> AllPermissions { get { return global::Microsoft.LightSwitch.Security.ApplicationPermissions.AllPermissions; } }
    }
}
