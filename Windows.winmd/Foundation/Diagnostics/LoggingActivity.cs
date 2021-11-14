// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingActivity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Activatable(typeof (ILoggingActivityFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class LoggingActivity : 
    ILoggingActivity,
    IClosable,
    ILoggingActivity2,
    ILoggingTarget
  {
    [MethodImpl]
    public extern LoggingActivity(string activityName, ILoggingChannel loggingChannel);

    [MethodImpl]
    public extern LoggingActivity(
      string activityName,
      ILoggingChannel loggingChannel,
      LoggingLevel level);

    public extern string Name { [MethodImpl] get; }

    public extern Guid Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    public extern LoggingChannel Channel { [MethodImpl] get; }

    [Overload("StopActivity")]
    [MethodImpl]
    public extern void StopActivity(string stopEventName);

    [Overload("StopActivityWithFields")]
    [MethodImpl]
    public extern void StopActivity(string stopEventName, LoggingFields fields);

    [Overload("StopActivityWithFieldsAndOptions")]
    [MethodImpl]
    public extern void StopActivity(
      string stopEventName,
      LoggingFields fields,
      LoggingOptions options);

    [Overload("IsEnabled")]
    [MethodImpl]
    public extern bool IsEnabled();

    [Overload("IsEnabledWithLevel")]
    [MethodImpl]
    public extern bool IsEnabled(LoggingLevel level);

    [Overload("IsEnabledWithLevelAndKeywords")]
    [MethodImpl]
    public extern bool IsEnabled(LoggingLevel level, long keywords);

    [Overload("LogEvent")]
    [MethodImpl]
    public extern void LogEvent(string eventName);

    [Overload("LogEventWithFields")]
    [MethodImpl]
    public extern void LogEvent(string eventName, LoggingFields fields);

    [Overload("LogEventWithFieldsAndLevel")]
    [MethodImpl]
    public extern void LogEvent(string eventName, LoggingFields fields, LoggingLevel level);

    [Overload("LogEventWithFieldsAndOptions")]
    [MethodImpl]
    public extern void LogEvent(
      string eventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);

    [Overload("StartActivity")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(string startEventName);

    [Overload("StartActivityWithFields")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields);

    [Overload("StartActivityWithFieldsAndLevel")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields,
      LoggingLevel level);

    [Overload("StartActivityWithFieldsAndOptions")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);
  }
}
