// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3919905603, 4567, 20225, 181, 202, 207, 73, 82, 120, 192, 168)]
  public interface ILoggingChannel : IClosable
  {
    string Name { get; }

    bool Enabled { get; }

    LoggingLevel Level { get; }

    [Overload("LogMessage")]
    void LogMessage(string eventString);

    [Overload("LogMessageWithLevel")]
    void LogMessage(string eventString, LoggingLevel level);

    [Overload("LogValuePair")]
    void LogValuePair(string value1, int value2);

    [Overload("LogValuePairWithLevel")]
    void LogValuePair(string value1, int value2, LoggingLevel level);

    event TypedEventHandler<ILoggingChannel, object> LoggingEnabled;
  }
}
