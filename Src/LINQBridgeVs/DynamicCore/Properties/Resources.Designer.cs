﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQBridgeVs.DynamicCore.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LINQBridgeVs.DynamicCore.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to linqbridge@gmail.com.
        /// </summary>
        internal static string EmailAddress {
            get {
                return ResourceManager.GetString("EmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to smtp.gmail.com.
        /// </summary>
        internal static string EmailSmtpClient {
            get {
                return ResourceManager.GetString("EmailSmtpClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 587.
        /// </summary>
        internal static string EmailSmtpPort {
            get {
                return ResourceManager.GetString("EmailSmtpPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -run.
        /// </summary>
        internal static string LINQPadCommands {
            get {
                return ResourceManager.GetString("LINQPadCommands", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LINQPad.exe.
        /// </summary>
        internal static string LINQPadExe {
            get {
                return ResourceManager.GetString("LINQPadExe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LINQPad Queries\LINQBridge.
        /// </summary>
        internal static string LINQPadQuery {
            get {
                return ResourceManager.GetString("LINQPadQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LINQBridge Visualizer.
        /// </summary>
        internal static string VisualizerName {
            get {
                return ResourceManager.GetString("VisualizerName", resourceCulture);
            }
        }
    }
}
