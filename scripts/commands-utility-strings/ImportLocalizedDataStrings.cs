﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
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
internal class ImportLocalizedDataStrings {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal ImportLocalizedDataStrings() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ImportLocalizedDataStrings", typeof(ImportLocalizedDataStrings).GetTypeInfo().Assembly);
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
    ///   Looks up a localized string similar to Cannot import localized data. The definition of additional supported commands is not allowed in this language mode..
    /// </summary>
    internal static string CannotDefineSupportedCommand {
        get {
            return ResourceManager.GetString("CannotDefineSupportedCommand", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot find the Windows PowerShell data file &apos;{0}&apos; in directory &apos;{1}&apos;, or in any parent culture directories..
    /// </summary>
    internal static string CannotFindPsd1File {
        get {
            return ResourceManager.GetString("CannotFindPsd1File", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following error occurred while Windows PowerShell was loading the &apos;{0}&apos; script data file:
    ///{1}..
    /// </summary>
    internal static string ErrorLoadingDataFile {
        get {
            return ResourceManager.GetString("ErrorLoadingDataFile", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following error occurred while Windows PowerShell was opening the data file &apos;{0}&apos;:
    ///{1}..
    /// </summary>
    internal static string ErrorOpeningFile {
        get {
            return ResourceManager.GetString("ErrorOpeningFile", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The argument for the FileName parameter should not contain a path..
    /// </summary>
    internal static string FileNameParameterCannotHavePath {
        get {
            return ResourceManager.GetString("FileNameParameterCannotHavePath", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The data file &apos;{0}&apos; cannot be found. .
    /// </summary>
    internal static string FileNotExist {
        get {
            return ResourceManager.GetString("FileNotExist", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The BindingVariable name &apos;{0}&apos; is invalid..
    /// </summary>
    internal static string IncorrectVariableName {
        get {
            return ResourceManager.GetString("IncorrectVariableName", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The FileName parameter was not specified. The FileName parameter is required when Import-LocalizedData is not called from a script file..
    /// </summary>
    internal static string NotCalledFromAScriptFile {
        get {
            return ResourceManager.GetString("NotCalledFromAScriptFile", resourceCulture);
        }
    }
}
