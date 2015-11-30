﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityServer3.Core.Resources {
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
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IdentityServer3.Core.Resources.Messages", typeof(Messages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 客户端标识不能为空 的本地化字符串。
        /// </summary>
        public static string ClientIdRequired {
            get {
                return ResourceManager.GetString("ClientIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 这是一个外部支持错误，错误信息：{0} 的本地化字符串。
        /// </summary>
        public static string ExternalProviderError {
            get {
                return ResourceManager.GetString("ExternalProviderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 客户端应用程序请求无效。 的本地化字符串。
        /// </summary>
        public static string invalid_request {
            get {
                return ResourceManager.GetString("invalid_request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 客户端应用程序试图访问它没有访问的资源。 的本地化字符串。
        /// </summary>
        public static string invalid_scope {
            get {
                return ResourceManager.GetString("invalid_scope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 用户名或密码错误 的本地化字符串。
        /// </summary>
        public static string InvalidUsernameOrPassword {
            get {
                return ResourceManager.GetString("InvalidUsernameOrPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 client_id丢失 的本地化字符串。
        /// </summary>
        public static string MissingClientId {
            get {
                return ResourceManager.GetString("MissingClientId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 令牌丢失 的本地化字符串。
        /// </summary>
        public static string MissingToken {
            get {
                return ResourceManager.GetString("MissingToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 必须至少选择一个权限。 的本地化字符串。
        /// </summary>
        public static string MustSelectAtLeastOnePermission {
            get {
                return ResourceManager.GetString("MustSelectAtLeastOnePermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未提供外部登录提供程序。 的本地化字符串。
        /// </summary>
        public static string NoExternalProvider {
            get {
                return ResourceManager.GetString("NoExternalProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 无效帐户 的本地化字符串。
        /// </summary>
        public static string NoMatchingExternalAccount {
            get {
                return ResourceManager.GetString("NoMatchingExternalAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 你要登录的的应用程序有一个确切的错误，请返回应用程序重试。 的本地化字符串。
        /// </summary>
        public static string NoSignInCookie {
            get {
                return ResourceManager.GetString("NoSignInCookie", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 外部认证出错 的本地化字符串。
        /// </summary>
        public static string NoSubjectFromExternalProvider {
            get {
                return ResourceManager.GetString("NoSubjectFromExternalProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 密码不能为空 的本地化字符串。
        /// </summary>
        public static string PasswordRequired {
            get {
                return ResourceManager.GetString("PasswordRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 SSL不能为空 的本地化字符串。
        /// </summary>
        public static string SslRequired {
            get {
                return ResourceManager.GetString("SslRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 客户端应用程序未知的或未被授权。 的本地化字符串。
        /// </summary>
        public static string unauthorized_client {
            get {
                return ResourceManager.GetString("unauthorized_client", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 这是一个未知错误 的本地化字符串。
        /// </summary>
        public static string UnexpectedError {
            get {
                return ResourceManager.GetString("UnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 授权服务器不支持请求的响应类型。 的本地化字符串。
        /// </summary>
        public static string unsupported_response_type {
            get {
                return ResourceManager.GetString("unsupported_response_type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不支持的媒体类型 的本地化字符串。
        /// </summary>
        public static string UnsupportedMediaType {
            get {
                return ResourceManager.GetString("UnsupportedMediaType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 用户名不能为空 的本地化字符串。
        /// </summary>
        public static string UsernameRequired {
            get {
                return ResourceManager.GetString("UsernameRequired", resourceCulture);
            }
        }
    }
}
