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
    public sealed partial class invtitlecodeItem : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// 初始化 invtitlecodeItem 實體的新執行個體。
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public invtitlecodeItem()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public invtitlecodeItem(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.invtitlecodeItem> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.invtitlecodeItem.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invtitlecodeItem_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invtitlecodeItem_AllowSaveWithErrors(ref bool result);
    
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
        public int invTitleCode
        {
            get
            {
                return global::LightSwitchApplication.invtitlecodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invTitleCode);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invTitleCode_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invTitleCode_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invTitleCode_Changed();

        /// <summary>
        /// 沒有可用的模型化描述
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string invCode
        {
            get
            {
                return global::LightSwitchApplication.invtitlecodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invCode);
            }
            set
            {
                global::LightSwitchApplication.invtitlecodeItem.DetailsClass.SetValue(this, global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invCode, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invCode_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invCode_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invCode_Changed();

        /// <summary>
        /// 沒有可用的模型化描述
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string invTitleDesc
        {
            get
            {
                return global::LightSwitchApplication.invtitlecodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invTitleDesc);
            }
            set
            {
                global::LightSwitchApplication.invtitlecodeItem.DetailsClass.SetValue(this, global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invTitleDesc, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invTitleDesc_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invTitleDesc_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void invTitleDesc_Changed();

        /// <summary>
        /// 沒有可用的模型化描述
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.customercodeItem customercodeItem1
        {
            get
            {
                return global::LightSwitchApplication.invtitlecodeItem.DetailsClass.GetValue(this, global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.customercodeItem1);
            }
            set
            {
                global::LightSwitchApplication.invtitlecodeItem.DetailsClass.SetValue(this, global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.customercodeItem1, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void customercodeItem1_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void customercodeItem1_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void customercodeItem1_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.invtitlecodeItem,
                global::LightSwitchApplication.invtitlecodeItem.DetailsClass,
                global::LightSwitchApplication.invtitlecodeItem.DetailsClass.IImplementation,
                global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invTitleCode;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass>.Entry
                __invtitlecodeItemEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass>.Entry(
                    global::LightSwitchApplication.invtitlecodeItem.DetailsClass.__invtitlecodeItem_CreateNew,
                    global::LightSwitchApplication.invtitlecodeItem.DetailsClass.__invtitlecodeItem_Created,
                    global::LightSwitchApplication.invtitlecodeItem.DetailsClass.__invtitlecodeItem_AllowSaveWithErrors);
            private static global::LightSwitchApplication.invtitlecodeItem __invtitlecodeItem_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.invtitlecodeItem> es)
            {
                return new global::LightSwitchApplication.invtitlecodeItem(es);
            }
            private static void __invtitlecodeItem_Created(global::LightSwitchApplication.invtitlecodeItem e)
            {
                e.invtitlecodeItem_Created();
            }
            private static bool __invtitlecodeItem_AllowSaveWithErrors(global::LightSwitchApplication.invtitlecodeItem e)
            {
                bool result = false;
                e.invtitlecodeItem_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, int> invTitleCode
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invTitleCode) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string> invCode
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invCode) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string> invTitleDesc
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.invTitleDesc) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::LightSwitchApplication.customercodeItem> customercodeItem1
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.customercodeItem1) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::LightSwitchApplication.customercodeItem>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int invTitleCode { get; }
                new string invCode { get; set; }
                new string invTitleDesc { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation customercodeItem1 { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, int>.Entry
                    invTitleCode = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, int>.Entry(
                        "invTitleCode",
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleCode_Stub,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleCode_ComputeIsReadOnly,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleCode_Validate,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleCode_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleCode_OnValueChanged);
                private static void _invTitleCode_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, int>.Data> c, global::LightSwitchApplication.invtitlecodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._invTitleCode, sf);
                }
                private static bool _invTitleCode_ComputeIsReadOnly(global::LightSwitchApplication.invtitlecodeItem e)
                {
                    bool result = false;
                    e.invTitleCode_IsReadOnly(ref result);
                    return result;
                }
                private static void _invTitleCode_Validate(global::LightSwitchApplication.invtitlecodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.invTitleCode_Validate(r);
                }
                private static int _invTitleCode_GetImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.invTitleCode;
                }
                private static void _invTitleCode_OnValueChanged(global::LightSwitchApplication.invtitlecodeItem e)
                {
                    e.invTitleCode_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>.Entry
                    invCode = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>.Entry(
                        "invCode",
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invCode_Stub,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invCode_ComputeIsReadOnly,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invCode_Validate,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invCode_GetImplementationValue,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invCode_SetImplementationValue,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invCode_OnValueChanged);
                private static void _invCode_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.invtitlecodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._invCode, sf);
                }
                private static bool _invCode_ComputeIsReadOnly(global::LightSwitchApplication.invtitlecodeItem e)
                {
                    bool result = false;
                    e.invCode_IsReadOnly(ref result);
                    return result;
                }
                private static void _invCode_Validate(global::LightSwitchApplication.invtitlecodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.invCode_Validate(r);
                }
                private static string _invCode_GetImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.invCode;
                }
                private static void _invCode_SetImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.invCode = v;
                }
                private static void _invCode_OnValueChanged(global::LightSwitchApplication.invtitlecodeItem e)
                {
                    e.invCode_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>.Entry
                    invTitleDesc = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>.Entry(
                        "invTitleDesc",
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleDesc_Stub,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleDesc_ComputeIsReadOnly,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleDesc_Validate,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleDesc_GetImplementationValue,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleDesc_SetImplementationValue,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._invTitleDesc_OnValueChanged);
                private static void _invTitleDesc_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.invtitlecodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._invTitleDesc, sf);
                }
                private static bool _invTitleDesc_ComputeIsReadOnly(global::LightSwitchApplication.invtitlecodeItem e)
                {
                    bool result = false;
                    e.invTitleDesc_IsReadOnly(ref result);
                    return result;
                }
                private static void _invTitleDesc_Validate(global::LightSwitchApplication.invtitlecodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.invTitleDesc_Validate(r);
                }
                private static string _invTitleDesc_GetImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.invTitleDesc;
                }
                private static void _invTitleDesc_SetImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.invTitleDesc = v;
                }
                private static void _invTitleDesc_OnValueChanged(global::LightSwitchApplication.invtitlecodeItem e)
                {
                    e.invTitleDesc_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::LightSwitchApplication.customercodeItem>.Entry
                    customercodeItem1 = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::LightSwitchApplication.customercodeItem>.Entry(
                        "customercodeItem1",
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._customercodeItem1_Stub,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._customercodeItem1_ComputeIsReadOnly,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._customercodeItem1_Validate,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._customercodeItem1_GetCoreImplementationValue,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._customercodeItem1_GetImplementationValue,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._customercodeItem1_SetImplementationValue,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._customercodeItem1_Refresh,
                        global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties._customercodeItem1_OnValueChanged);
                private static void _customercodeItem1_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::LightSwitchApplication.customercodeItem>.Data> c, global::LightSwitchApplication.invtitlecodeItem.DetailsClass d, object sf)
                {
                    c(d, ref d._customercodeItem1, sf);
                }
                private static bool _customercodeItem1_ComputeIsReadOnly(global::LightSwitchApplication.invtitlecodeItem e)
                {
                    bool result = false;
                    e.customercodeItem1_IsReadOnly(ref result);
                    return result;
                }
                private static void _customercodeItem1_Validate(global::LightSwitchApplication.invtitlecodeItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.customercodeItem1_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _customercodeItem1_GetCoreImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d)
                {
                    return d.ImplementationEntity.customercodeItem1;
                }
                private static global::LightSwitchApplication.customercodeItem _customercodeItem1_GetImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.customercodeItem, global::LightSwitchApplication.customercodeItem.DetailsClass>(global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.customercodeItem1, ref d._customercodeItem1);
                }
                private static void _customercodeItem1_SetImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d, global::LightSwitchApplication.customercodeItem v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.customercodeItem1, ref d._customercodeItem1, (i, ev) => i.customercodeItem1 = ev, v);
                }
                private static void _customercodeItem1_Refresh(global::LightSwitchApplication.invtitlecodeItem.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.invtitlecodeItem.DetailsClass.PropertySetProperties.customercodeItem1, ref d._customercodeItem1);
                }
                private static void _customercodeItem1_OnValueChanged(global::LightSwitchApplication.invtitlecodeItem e)
                {
                    e.customercodeItem1_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, int>.Data _invTitleCode;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>.Data _invCode;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, string>.Data _invTitleDesc;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.invtitlecodeItem, global::LightSwitchApplication.invtitlecodeItem.DetailsClass, global::LightSwitchApplication.customercodeItem>.Data _customercodeItem1;
            
        }
    
        #endregion
    }
    
    #endregion
}
