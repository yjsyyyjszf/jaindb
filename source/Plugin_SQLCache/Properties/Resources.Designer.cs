﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plugin_SQLCache.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Plugin_SQLCache.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to USE [JCache]
        ///
        ///SET ANSI_NULLS ON
        ///
        ///SET QUOTED_IDENTIFIER ON
        ///
        ///CREATE TABLE [dbo].[JCache] (
        ///    [Id]                         NVARCHAR (449)     COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
        ///    [Value]                      VARBINARY (MAX)    NOT NULL,
        ///    [ExpiresAtTime]              DATETIMEOFFSET (7) NOT NULL,
        ///    [SlidingExpirationInSeconds] BIGINT             NULL,
        ///    [AbsoluteExpiration]         DATETIMEOFFSET (7) NULL
        ///);
        ///
        ///CREATE NONCLUSTERED INDEX [Index_ExpiresAtTime]
        ///    ON [dbo].[JCac [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateTable {
            get {
                return ResourceManager.GetString("CreateTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;ReadOnly&quot;: false,
        ///  &quot;ContinueAfterWrite&quot;: true,
        ///  &quot;CacheFull&quot;: true,
        ///  &quot;CacheKeys&quot;: true,
        ///  &quot;SQLConnectionString&quot;: &quot;Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JCache;Integrated Security=true&quot;,
        ///  &quot;SQLTable&quot;: &quot;JCache&quot;,
        ///  &quot;SlidingExpiration&quot;: 2678400
        ///}.
        /// </summary>
        internal static string Plugin_SQLCache {
            get {
                return ResourceManager.GetString("Plugin_SQLCache", resourceCulture);
            }
        }
    }
}
