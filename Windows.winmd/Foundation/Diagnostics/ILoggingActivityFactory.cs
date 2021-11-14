// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingActivityFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1798550659, 57610, 19544, 151, 213, 16, 251, 69, 16, 116, 251)]
  [ExclusiveTo(typeof (LoggingActivity))]
  internal interface ILoggingActivityFactory
  {
    LoggingActivity CreateLoggingActivity(
      string activityName,
      ILoggingChannel loggingChannel);

    LoggingActivity CreateLoggingActivityWithLevel(
      string activityName,
      ILoggingChannel loggingChannel,
      LoggingLevel level);
  }
}
