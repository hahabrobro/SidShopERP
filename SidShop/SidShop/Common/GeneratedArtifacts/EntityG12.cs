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
    public sealed partial class unitcodeItem : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// 初始化 unitcodeItem 實體的新執行個體。
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public unitcodeItem()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public unitcodeItem(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.unitcodeItem> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.unitcodeItem.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitcodeItem_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitcodeItem_AllowSaveWithErrors(ref bool result);
    
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
        public short unitID
        {
            get
            {
                return global::LightSwitchApplication.unitcodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitID);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitID_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitID_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitID_Changed();

        /// <summary>
        /// 沒有可用的模型化描述
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string unitEnDesc
        {
            get
            {
                return global::LightSwitchApplication.unitcodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitEnDesc);
            }
            set
            {
                global::LightSwitchApplication.unitcodeItem.DetailsClass.SetValue(this, global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitEnDesc, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitEnDesc_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitEnDesc_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitEnDesc_Changed();

        /// <summary>
        /// 沒有可用的模型化描述
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string unitDesc
        {
            get
            {
                return global::LightSwitchApplication.unitcodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitDesc);
            }
            set
            {
                global::LightSwitchApplication.unitcodeItem.DetailsClass.SetValue(this, global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitDesc, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitDesc_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitDesc_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void unitDesc_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.unitcodeItem,
                global::LightSwitchApplication.unitcodeItem.DetailsClass,
                global::LightSwitchApplication.unitcodeItem.DetailsClass.IImplementation,
                global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitID;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass>.Entry
                __unitcodeItemEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass>.Entry(
                    global::LightSwitchApplication.unitcodeItem.DetailsClass.__unitcodeItem_CreateNew,
                    global::LightSwitchApplication.unitcodeItem.DetailsClass.__unitcodeItem_Created,
                    global::LightSwitchApplication.unitcodeItem.DetailsClass.__unitcodeItem_AllowSaveWithErrors);
            private static global::LightSwitchApplication.unitcodeItem __unitcodeItem_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.unitcodeItem> es)
            {
                return new global::LightSwitchApplication.unitcodeItem(es);
            }
            private static void __unitcodeItem_Created(global::LightSwitchApplication.unitcodeItem e)
            {
                e.unitcodeItem_Created();
            }
            private static bool __unitcodeItem_AllowSaveWithErrors(global::LightSwitchApplication.unitcodeItem e)
            {
                bool result = false;
                e.unitcodeItem_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, short> unitID
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitID) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, short>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string> unitEnDesc
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitEnDesc) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string> unitDesc
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties.unitDesc) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new short unitID { get; }
                new string unitEnDesc { get; set; }
                new string unitDesc { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, short>.Entry
                    unitID = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, short>.Entry(
                        "unitID",
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitID_Stub,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitID_ComputeIsReadOnly,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitID_Validate,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitID_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitID_OnValueChanged);
                private static void _unitID_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.unitcodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, short>.Data> c, global::LightSwitchApplication.unitcodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._unitID, sf);
                }
                private static bool _unitID_ComputeIsReadOnly(global::LightSwitchApplication.unitcodeItem e)
                {
                    bool result = false;
                    e.unitID_IsReadOnly(ref result);
                    return result;
                }
                private static void _unitID_Validate(global::LightSwitchApplication.unitcodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.unitID_Validate(r);
                }
                private static short _unitID_GetImplementationValue(global::LightSwitchApplication.unitcodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.unitID;
                }
                private static void _unitID_OnValueChanged(global::LightSwitchApplication.unitcodeItem e)
                {
                    e.unitID_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>.Entry
                    unitEnDesc = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>.Entry(
                        "unitEnDesc",
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitEnDesc_Stub,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitEnDesc_ComputeIsReadOnly,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitEnDesc_Validate,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitEnDesc_GetImplementationValue,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitEnDesc_SetImplementationValue,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitEnDesc_OnValueChanged);
                private static void _unitEnDesc_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.unitcodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.unitcodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._unitEnDesc, sf);
                }
                private static bool _unitEnDesc_ComputeIsReadOnly(global::LightSwitchApplication.unitcodeItem e)
                {
                    bool result = false;
                    e.unitEnDesc_IsReadOnly(ref result);
                    return result;
                }
                private static void _unitEnDesc_Validate(global::LightSwitchApplication.unitcodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.unitEnDesc_Validate(r);
                }
                private static string _unitEnDesc_GetImplementationValue(global::LightSwitchApplication.unitcodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.unitEnDesc;
                }
                private static void _unitEnDesc_SetImplementationValue(global::LightSwitchApplication.unitcodeItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.unitEnDesc = v;
                }
                private static void _unitEnDesc_OnValueChanged(global::LightSwitchApplication.unitcodeItem e)
                {
                    e.unitEnDesc_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>.Entry
                    unitDesc = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>.Entry(
                        "unitDesc",
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitDesc_Stub,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitDesc_ComputeIsReadOnly,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitDesc_Validate,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitDesc_GetImplementationValue,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitDesc_SetImplementationValue,
                        global::LightSwitchApplication.unitcodeItem.DetailsClass.PropertySetProperties._unitDesc_OnValueChanged);
                private static void _unitDesc_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.unitcodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.unitcodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._unitDesc, sf);
                }
                private static bool _unitDesc_ComputeIsReadOnly(global::LightSwitchApplication.unitcodeItem e)
                {
                    bool result = false;
                    e.unitDesc_IsReadOnly(ref result);
                    return result;
                }
                private static void _unitDesc_Validate(global::LightSwitchApplication.unitcodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.unitDesc_Validate(r);
                }
                private static string _unitDesc_GetImplementationValue(global::LightSwitchApplication.unitcodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.unitDesc;
                }
                private static void _unitDesc_SetImplementationValue(global::LightSwitchApplication.unitcodeItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.unitDesc = v;
                }
                private static void _unitDesc_OnValueChanged(global::LightSwitchApplication.unitcodeItem e)
                {
                    e.unitDesc_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, short>.Data _unitID;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>.Data _unitEnDesc;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.unitcodeItem, global::LightSwitchApplication.unitcodeItem.DetailsClass, string>.Data _unitDesc;
            
        }
    
        #endregion
    }
    
    #endregion
}