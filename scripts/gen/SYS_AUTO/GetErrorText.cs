﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;



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
internal class GetErrorText {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal GetErrorText() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GetErrorText", typeof(GetErrorText).GetTypeInfo().Assembly);
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
    ///   Looks up a localized string similar to Running commands is prevented by Stop policy settings..
    /// </summary>
    internal static string ActionPreferenceStop {
        get {
            return ResourceManager.GetString("ActionPreferenceStop", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot retrieve the message &quot;{0}&quot; &quot;{1}&quot; &quot;{2}&quot; because an assembly was not registered..
    /// </summary>
    internal static string AssemblyNotRegistered {
        get {
            return ResourceManager.GetString("AssemblyNotRegistered", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot retrieve the message &quot;{0}&quot; &quot;{1}&quot; &quot;{2}&quot;. A template string format is not valid in template string &quot;{3}&quot;..
    /// </summary>
    internal static string BadTemplate {
        get {
            return ResourceManager.GetString("BadTemplate", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot retrieve the message &quot;{0}&quot; &quot;{1}&quot; &quot;{2}&quot;. A template string exists, but its value is empty or blank..
    /// </summary>
    internal static string BlankTemplate {
        get {
            return ResourceManager.GetString("BlankTemplate", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The pipeline failed due to call depth overflow..
    /// </summary>
    internal static string PipelineDepthException {
        get {
            return ResourceManager.GetString("PipelineDepthException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The pipeline has been stopped..
    /// </summary>
    internal static string PipelineStoppedException {
        get {
            return ResourceManager.GetString("PipelineStoppedException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot load a resource with base name &quot;{0}&quot;..
    /// </summary>
    internal static string ResourceBaseNameFailure {
        get {
            return ResourceManager.GetString("ResourceBaseNameFailure", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot load a resource string with ID &quot;{0}&quot;..
    /// </summary>
    internal static string ResourceIdFailure {
        get {
            return ResourceManager.GetString("ResourceIdFailure", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The script failed due to call depth overflow..
    /// </summary>
    internal static string ScriptCallDepthException {
        get {
            return ResourceManager.GetString("ScriptCallDepthException", resourceCulture);
        }
    }
}
