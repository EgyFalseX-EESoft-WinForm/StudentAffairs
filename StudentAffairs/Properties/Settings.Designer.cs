﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentAffairs.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=StudentAffairs;Integrated Security=True")]
        public string StudentAffairsConnectionString {
            get {
                return ((string)(this["StudentAffairsConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<configuration>\r\n    <configSections>\r\n " +
            "     <section name=\"log4net\"\r\n          type=\"log4net.Config.Log4NetConfiguratio" +
            "nSectionHandler, log4net\" />\r\n    </configSections>\r\n    <log4net>\r\n\r\n      <app" +
            "ender name=\"RemotingAppender\" type=\"log4net.Appender.RemotingAppender\" >\r\n      " +
            "  <sink value=\"tcp://localhost:1983/LoggingSink\" />\r\n        <lossy value=\"false" +
            "\" />\r\n        <bufferSize value=\"1\" />\r\n        <onlyFixPartialEventData value=\"" +
            "true\" />\r\n      </appender>\r\n\r\n      <appender name=\"LogFileAppender\" type=\"log4" +
            "net.Appender.FileAppender\">\r\n        <param name=\"File\" value=\"Log4Net\\NICSQLToo" +
            "lsLog4Net.txt\" />\r\n        <param name=\"AppendToFile\" value=\"true\" />\r\n        <" +
            "layout type=\"log4net.Layout.PatternLayout\">\r\n          <param name=\"Header\" valu" +
            "e=\"[Header]\\r\\n\" />\r\n          <param name=\"Footer\" value=\"[Footer]\\r\\n\" />\r\n   " +
            "       <param name=\"ConversionPattern\" value=\"%d [%t] %-5p %c %m%n\" />\r\n        " +
            "</layout>\r\n      </appender>\r\n\r\n      <appender name=\"ConsoleAppender\" type=\"log" +
            "4net.Appender.ConsoleAppender\" >\r\n        <layout type=\"log4net.Layout.PatternLa" +
            "yout\">\r\n          <param name=\"Header\" value=\"[Header]\\r\\n\" />\r\n          <param" +
            " name=\"Footer\" value=\"[Footer]\\r\\n\" />\r\n          <param name=\"ConversionPattern" +
            "\" value=\"%d [%t] %-5p %c %m%n\" />\r\n        </layout>\r\n      </appender>\r\n\r\n     " +
            " <appender name=\"UdpAppender\" type=\"log4net.Appender.UdpAppender\">\r\n        <rem" +
            "oteAddress value=\"localhost\" />\r\n        <remotePort value=\"7071\" />\r\n        <l" +
            "ayout type=\"log4net.Layout.XmlLayoutSchemaLog4j\" />\r\n      </appender>\r\n\r\n      " +
            "<root>\r\n        <level value=\"Debug\" />\r\n        <appender-ref ref=\"UdpAppender\"" +
            " />\r\n        <appender-ref ref=\"RemotingAppender\" />\r\n        <appender-ref ref=" +
            "\"LogFileAppender\" />\r\n      </root>\r\n    </log4net>\r\n</configuration>")]
        public string L4N {
            get {
                return ((string)(this["L4N"]));
            }
            set {
                this["L4N"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("جاري الحفظ ...")]
        public string msg_SavingInProgress {
            get {
                return ((string)(this["msg_SavingInProgress"]));
            }
            set {
                this["msg_SavingInProgress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("تم الحفظ ...")]
        public string msg_SaveSuccess {
            get {
                return ((string)(this["msg_SaveSuccess"]));
            }
            set {
                this["msg_SaveSuccess"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("لم يتم الحفظ ...")]
        public string msg_SavingFailed {
            get {
                return ((string)(this["msg_SavingFailed"]));
            }
            set {
                this["msg_SavingFailed"] = value;
            }
        }
    }
}
