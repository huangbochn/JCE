﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JCE.Utils {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class R {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal R() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JCE.Utils.R", typeof(R).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 当前操作的数据已被其它人修改，请刷新后重试 的本地化字符串。
        /// </summary>
        internal static string ConcurrencyExceptionMessage {
            get {
                return ResourceManager.GetString("ConcurrencyExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 对不起，不能删除该记录，因为该记录已经关联了相关数据，请删除相关数据后重试 的本地化字符串。
        /// </summary>
        internal static string DataBaseRefrenceError {
            get {
                return ResourceManager.GetString("DataBaseRefrenceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 删除成功 的本地化字符串。
        /// </summary>
        internal static string DeleteSuccess {
            get {
                return ResourceManager.GetString("DeleteSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 电子邮件的格式不正确，请修改 的本地化字符串。
        /// </summary>
        internal static string EmailAddressAttribute_Invalid {
            get {
                return ResourceManager.GetString("EmailAddressAttribute_Invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 名为 {0} 的文件无效 的本地化字符串。
        /// </summary>
        internal static string InvalidFile {
            get {
                return ResourceManager.GetString("InvalidFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 手机号无效 的本地化字符串。
        /// </summary>
        internal static string InvalidMobilePhone {
            get {
                return ResourceManager.GetString("InvalidMobilePhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不能为空 的本地化字符串。
        /// </summary>
        internal static string IsEmpty {
            get {
                return ResourceManager.GetString("IsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 分页查询必须设置排序字段 的本地化字符串。
        /// </summary>
        internal static string PagerOrderIsEmpty {
            get {
                return ResourceManager.GetString("PagerOrderIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 进行该操作后，记得保存 的本地化字符串。
        /// </summary>
        internal static string RememberSave {
            get {
                return ResourceManager.GetString("RememberSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 保存成功 的本地化字符串。
        /// </summary>
        internal static string SaveSuccess {
            get {
                return ResourceManager.GetString("SaveSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 排序号不能为空 的本地化字符串。
        /// </summary>
        internal static string SortIdIsNull {
            get {
                return ResourceManager.GetString("SortIdIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 系统忙，请稍后再试 的本地化字符串。
        /// </summary>
        internal static string SystemError {
            get {
                return ResourceManager.GetString("SystemError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 表名必须设置 的本地化字符串。
        /// </summary>
        internal static string TableIsEmpty {
            get {
                return ResourceManager.GetString("TableIsEmpty", resourceCulture);
            }
        }
    }
}
