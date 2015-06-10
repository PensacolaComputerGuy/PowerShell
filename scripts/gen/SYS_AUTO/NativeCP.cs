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
internal class NativeCP {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal NativeCP() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NativeCP", typeof(NativeCP).GetTypeInfo().Assembly);
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
    ///   Looks up a localized string similar to Cannot process the XML from the &apos;{0}&apos; stream of &apos;{1}&apos;: {2}.
    /// </summary>
    internal static string CliXmlError {
        get {
            return ResourceManager.GetString("CliXmlError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to ScriptBlock should only be specified as a value of the Command parameter..
    /// </summary>
    internal static string IncorrectValueForCommandParameter {
        get {
            return ResourceManager.GetString("IncorrectValueForCommandParameter", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A value that is not valid ({6}) was specified for the {7} parameter. Valid values are Text and Xml..
    /// </summary>
    internal static string IncorrectValueForFormatParameter {
        get {
            return ResourceManager.GetString("IncorrectValueForFormatParameter", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to No value was specified for the Command parameter..
    /// </summary>
    internal static string NoValueForCommandParameter {
        get {
            return ResourceManager.GetString("NoValueForCommandParameter", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to No value was specified for the InputFormat parameter. Valid values are Text and Xml..
    /// </summary>
    internal static string NoValueForInputFormatParameter {
        get {
            return ResourceManager.GetString("NoValueForInputFormatParameter", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to No value was specified for the OutputFormat parameter. Valid values are text and XML..
    /// </summary>
    internal static string NoValueForOutputFormatParameter {
        get {
            return ResourceManager.GetString("NoValueForOutputFormatParameter", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to No value was specified for the Args parameter..
    /// </summary>
    internal static string NoValuesSpecifiedForArgs {
        get {
            return ResourceManager.GetString("NoValuesSpecifiedForArgs", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The {6} parameter was already specified..
    /// </summary>
    internal static string ParameterSpecifiedAlready {
        get {
            return ResourceManager.GetString("ParameterSpecifiedAlready", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The {6} parameter requires a string value..
    /// </summary>
    internal static string StringValueExpectedForFormatParameter {
        get {
            return ResourceManager.GetString("StringValueExpectedForFormatParameter", resourceCulture);
        }
    }
}
