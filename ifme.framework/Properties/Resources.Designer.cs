﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ifme.framework.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ifme.framework.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Cores={0}
        ///SetMemoryMax(512)
        ///SetMTMode(3,Cores)
        ///PluginPath = &quot;{1}\&quot;
        ///LoadPlugin(PluginPath+&quot;svpflow1.dll&quot;)
        ///LoadPlugin(PluginPath+&quot;svpflow2.dll&quot;)
        ///Import(PluginPath+&quot;InterFrame2.avsi&quot;)
        ///DirectShowSource(&quot;{2}&quot;).ConvertToYV12()
        ///SetMTMode(2)
        ///InterFrame(Cores=Cores, Preset=&quot;{3}&quot;, Tuning=&quot;{4}&quot;, FrameDouble={5}, GPU={6}, InputType=&quot;{7}&quot;).
        /// </summary>
        internal static string AviSynthHFR {
            get {
                return ResourceManager.GetString("AviSynthHFR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap BannerBRight {
            get {
                object obj = ResourceManager.GetObject("BannerBRight", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap BannerCLeft {
            get {
                object obj = ResourceManager.GetObject("BannerCLeft", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap BannerCRight {
            get {
                object obj = ResourceManager.GetObject("BannerCRight", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Bug {
            get {
                object obj = ResourceManager.GetObject("Bug", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Frame {
            get {
                object obj = ResourceManager.GetObject("Frame", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap list_add {
            get {
                object obj = ResourceManager.GetObject("list_add", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap list_clear {
            get {
                object obj = ResourceManager.GetObject("list_clear", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap nagisan {
            get {
                object obj = ResourceManager.GetObject("nagisan", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #!/bin/sh
        ///# Usage:
        ///#   update.sh &quot;parm 1&quot; &quot;parm 2&quot; &quot;parm 3&quot;
        ///# example:
        ///#   update.sh &quot;http://update.example.com/myapp/1.22/file.zip&quot; &quot;/home/me/Desktop/myapp&quot; &quot;myapp.sh&quot;
        ///chmod +x ./7za
        ///echo &quot; &quot;
        ///echo &quot;This terminal will perform IFME update to the latest version.&quot;
        ///echo &quot;Please be patient this may take a while depending your&quot;
        ///echo &quot;internet configuration, you can do other thing while updating.&quot;
        ///echo &quot; &quot;
        ///sleep 5
        ///wget --no-check-certificate -O &quot;./saishin.jp&quot; $1
        ///./7za x -so &quot;./saishin.jp&quot; | tar --over [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ScriptUpdateLinux {
            get {
                return ResourceManager.GetString("ScriptUpdateLinux", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///@title IFME Updater
        ///REM Usage:
        ///REM   update.cmd &quot;parm 1&quot; &quot;parm 2&quot; &quot;parm 3&quot;
        ///REM example:
        ///REM   update.cmd &quot;http://update.example.com/myapp/1.22/file.zip&quot; &quot;C:\Program Files\myapp&quot; &quot;myapp.exe&quot;
        ///echo.
        ///echo This console will perfom IFME update to the latest version.
        ///echo Please be patient this may take a while depending your
        ///echo internet configuration, you can do other thing while updating.
        ///echo.
        ///TIMEOUT /T 5 /NOBREAK
        ///copy %2\unins000.exe .\unins000.exe
        ///copy %2\unins000.dat .\unins000.dat        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ScriptUpdateWindows {
            get {
                return ResourceManager.GetString("ScriptUpdateWindows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap SplashScreenC {
            get {
                object obj = ResourceManager.GetObject("SplashScreenC", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
