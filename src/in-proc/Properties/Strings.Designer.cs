﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DarkLoop.Azure.Functions.Authorization.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DarkLoop.Azure.Functions.Authorization.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Authorization through FunctionAuthorizeAttribute is disabled at the application level. Skipping authorization for {0}..
        /// </summary>
        internal static string DisabledAuthorization {
            get {
                return ResourceManager.GetString("DisabledAuthorization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure.Functions.Cli.Actions.HostActions.WebHost.Security.CliAuthenticationHandler`1.
        /// </summary>
        internal static string Func_ClieAuthHandler {
            get {
                return ResourceManager.GetString("Func_ClieAuthHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AddWebJobsScriptHostAuthentication.
        /// </summary>
        internal static string WJH_AddAuthentication {
            get {
                return ResourceManager.GetString("WJH_AddAuthentication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AddWebJobsScriptHostAuthorization.
        /// </summary>
        internal static string WJH_AddAuthorization {
            get {
                return ResourceManager.GetString("WJH_AddAuthorization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft.Azure.WebJobs.Script.WebHost.Security.Authentication.ArmAuthenticationOptions.
        /// </summary>
        internal static string WJH_ArmAuthOptions {
            get {
                return ResourceManager.GetString("WJH_ArmAuthOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft.Azure.WebJobs.Script.WebHost.
        /// </summary>
        internal static string WJH_Assembly {
            get {
                return ResourceManager.GetString("WJH_Assembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft.Azure.WebJobs.Script.WebHost.Authentication.AuthenticationLevelOptions.
        /// </summary>
        internal static string WJH_AuthLevelOptions {
            get {
                return ResourceManager.GetString("WJH_AuthLevelOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft.Azure.WebJobs.Script.WebHost.Features.IFunctionExecutionFeature.
        /// </summary>
        internal static string WJH_FuncExecFeature {
            get {
                return ResourceManager.GetString("WJH_FuncExecFeature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft.Extensions.DependencyInjection.ScriptJwtBearerExtensions.
        /// </summary>
        internal static string WJH_JWTExtensions {
            get {
                return ResourceManager.GetString("WJH_JWTExtensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft.Azure.WebJobs.Script.WebHost.WebHostServiceCollectionExtensions.
        /// </summary>
        internal static string WJH_WebJovsSvcsExtensions {
            get {
                return ResourceManager.GetString("WJH_WebJovsSvcsExtensions", resourceCulture);
            }
        }
    }
}
