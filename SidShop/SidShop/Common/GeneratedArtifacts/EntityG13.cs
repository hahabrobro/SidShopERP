﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// 沒有可用的模型化描述
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class punitcodeItem : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// 初始化 punitcodeItem 實體的新執行個體。
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public punitcodeItem()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public punitcodeItem(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.punitcodeItem> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.punitcodeItem.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void punitcodeItem_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void punitcodeItem_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// 取得這個應用程式的 Application 物件。Application 物件提供對現用螢幕的存取、開啟螢幕的方法，以及對目前使用者的存取。
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// 取得包含資料工作區。資料工作區提供對應用程式中所有資料來源的存取。
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// 沒有可用的模型化描述
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public short pUnitID
        {
            get
            {
                return global::LightSwitchApplication.punitcodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitID);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitID_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitID_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitID_Changed();

        /// <summary>
        /// 沒有可用的模型化描述
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string pUnitEnDesc
        {
            get
            {
                return global::LightSwitchApplication.punitcodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitEnDesc);
            }
            set
            {
                global::LightSwitchApplication.punitcodeItem.DetailsClass.SetValue(this, global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitEnDesc, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitEnDesc_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitEnDesc_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitEnDesc_Changed();

        /// <summary>
        /// 沒有可用的模型化描述
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string pUnitDesc
        {
            get
            {
                return global::LightSwitchApplication.punitcodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitDesc);
            }
            set
            {
                global::LightSwitchApplication.punitcodeItem.DetailsClass.SetValue(this, global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitDesc, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitDesc_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitDesc_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void pUnitDesc_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.punitcodeItem,
                global::LightSwitchApplication.punitcodeItem.DetailsClass,
                global::LightSwitchApplication.punitcodeItem.DetailsClass.IImplementation,
                global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitID;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass>.Entry
                __punitcodeItemEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass>.Entry(
                    global::LightSwitchApplication.punitcodeItem.DetailsClass.__punitcodeItem_CreateNew,
                    global::LightSwitchApplication.punitcodeItem.DetailsClass.__punitcodeItem_Created,
                    global::LightSwitchApplication.punitcodeItem.DetailsClass.__punitcodeItem_AllowSaveWithErrors);
            private static global::LightSwitchApplication.punitcodeItem __punitcodeItem_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.punitcodeItem> es)
            {
                return new global::LightSwitchApplication.punitcodeItem(es);
            }
            private static void __punitcodeItem_Created(global::LightSwitchApplication.punitcodeItem e)
            {
                e.punitcodeItem_Created();
            }
            private static bool __punitcodeItem_AllowSaveWithErrors(global::LightSwitchApplication.punitcodeItem e)
            {
                bool result = false;
                e.punitcodeItem_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, short> pUnitID
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitID) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, short>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string> pUnitEnDesc
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitEnDesc) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string> pUnitDesc
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties.pUnitDesc) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new short pUnitID { get; }
                new string pUnitEnDesc { get; set; }
                new string pUnitDesc { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, short>.Entry
                    pUnitID = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, short>.Entry(
                        "pUnitID",
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitID_Stub,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitID_ComputeIsReadOnly,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitID_Validate,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitID_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitID_OnValueChanged);
                private static void _pUnitID_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.punitcodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, short>.Data> c, global::LightSwitchApplication.punitcodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._pUnitID, sf);
                }
                private static bool _pUnitID_ComputeIsReadOnly(global::LightSwitchApplication.punitcodeItem e)
                {
                    bool result = false;
                    e.pUnitID_IsReadOnly(ref result);
                    return result;
                }
                private static void _pUnitID_Validate(global::LightSwitchApplication.punitcodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.pUnitID_Validate(r);
                }
                private static short _pUnitID_GetImplementationValue(global::LightSwitchApplication.punitcodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.pUnitID;
                }
                private static void _pUnitID_OnValueChanged(global::LightSwitchApplication.punitcodeItem e)
                {
                    e.pUnitID_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>.Entry
                    pUnitEnDesc = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>.Entry(
                        "pUnitEnDesc",
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitEnDesc_Stub,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitEnDesc_ComputeIsReadOnly,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitEnDesc_Validate,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitEnDesc_GetImplementationValue,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitEnDesc_SetImplementationValue,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitEnDesc_OnValueChanged);
                private static void _pUnitEnDesc_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.punitcodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.punitcodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._pUnitEnDesc, sf);
                }
                private static bool _pUnitEnDesc_ComputeIsReadOnly(global::LightSwitchApplication.punitcodeItem e)
                {
                    bool result = false;
                    e.pUnitEnDesc_IsReadOnly(ref result);
                    return result;
                }
                private static void _pUnitEnDesc_Validate(global::LightSwitchApplication.punitcodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.pUnitEnDesc_Validate(r);
                }
                private static string _pUnitEnDesc_GetImplementationValue(global::LightSwitchApplication.punitcodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.pUnitEnDesc;
                }
                private static void _pUnitEnDesc_SetImplementationValue(global::LightSwitchApplication.punitcodeItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.pUnitEnDesc = v;
                }
                private static void _pUnitEnDesc_OnValueChanged(global::LightSwitchApplication.punitcodeItem e)
                {
                    e.pUnitEnDesc_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>.Entry
                    pUnitDesc = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>.Entry(
                        "pUnitDesc",
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitDesc_Stub,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitDesc_ComputeIsReadOnly,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitDesc_Validate,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitDesc_GetImplementationValue,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitDesc_SetImplementationValue,
                        global::LightSwitchApplication.punitcodeItem.DetailsClass.PropertySetProperties._pUnitDesc_OnValueChanged);
                private static void _pUnitDesc_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.punitcodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.punitcodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._pUnitDesc, sf);
                }
                private static bool _pUnitDesc_ComputeIsReadOnly(global::LightSwitchApplication.punitcodeItem e)
                {
                    bool result = false;
                    e.pUnitDesc_IsReadOnly(ref result);
                    return result;
                }
                private static void _pUnitDesc_Validate(global::LightSwitchApplication.punitcodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.pUnitDesc_Validate(r);
                }
                private static string _pUnitDesc_GetImplementationValue(global::LightSwitchApplication.punitcodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.pUnitDesc;
                }
                private static void _pUnitDesc_SetImplementationValue(global::LightSwitchApplication.punitcodeItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.pUnitDesc = v;
                }
                private static void _pUnitDesc_OnValueChanged(global::LightSwitchApplication.punitcodeItem e)
                {
                    e.pUnitDesc_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, short>.Data _pUnitID;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>.Data _pUnitEnDesc;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.punitcodeItem, global::LightSwitchApplication.punitcodeItem.DetailsClass, string>.Data _pUnitDesc;
            
        }
    
        #endregion
    }
    
    #endregion
}
