// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ILoggingChannelFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ILoggingChannelFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class LoggingChannel : ILoggingChannel, IClosable, ILoggingChannel2, ILoggingTarget
  {
    [MethodImpl]
    public extern LoggingChannel(string name, LoggingChannelOptions options);

    [MethodImpl]
    public extern LoggingChannel(string name, LoggingChannelOptions options, Guid id);

    [Deprecated("This constructor creates a LoggingChannel in Windows 8.1 compatibility mode. Prefer the two-parameter constructor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern LoggingChannel(string name);

    public extern string Name { [MethodImpl] get; }

    public extern bool Enabled { [MethodImpl] get; }

    public extern LoggingLevel Level { [MethodImpl] get; }

    [Overload("LogMessage")]
    [MethodImpl]
    public extern void LogMessage(string eventString);

    [Overload("LogMessageWithLevel")]
    [MethodImpl]
    public extern void LogMessage(string eventString, LoggingLevel level);

    [Overload("LogValuePair")]
    [MethodImpl]
    public extern void LogValuePair(string value1, int value2);

    [Overload("LogValuePairWithLevel")]
    [MethodImpl]
    public extern void LogValuePair(string value1, int value2, LoggingLevel level);

    public extern event TypedEventHandler<ILoggingChannel, object> LoggingEnabled;

    [MethodImpl]
    public extern void Close();

    public extern Guid Id { [MethodImpl] get; }

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
