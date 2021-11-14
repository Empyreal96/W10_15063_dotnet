// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingTarget
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1710320693, 58248, 20006, 177, 122, 245, 28, 211, 168, 57, 22)]
  public interface ILoggingTarget
  {
    [Overload("IsEnabled")]
    bool IsEnabled();

    [Overload("IsEnabledWithLevel")]
    bool IsEnabled(LoggingLevel level);

    [Overload("IsEnabledWithLevelAndKeywords")]
    bool IsEnabled(LoggingLevel level, long keywords);

    [Overload("LogEvent")]
    void LogEvent(string eventName);

    [Overload("LogEventWithFields")]
    void LogEvent(string eventName, LoggingFields fields);

    [Overload("LogEventWithFieldsAndLevel")]
    void LogEvent(string eventName, LoggingFields fields, LoggingLevel level);

    [Overload("LogEventWithFieldsAndOptions")]
    void LogEvent(
      string eventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);

    [Overload("StartActivity")]
    LoggingActivity StartActivity(string startEventName);

    [Overload("StartActivityWithFields")]
    LoggingActivity StartActivity(string startEventName, LoggingFields fields);

    [Overload("StartActivityWithFieldsAndLevel")]
    LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields,
      LoggingLevel level);

    [Overload("StartActivityWithFieldsAndOptions")]
    LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);
  }
}
