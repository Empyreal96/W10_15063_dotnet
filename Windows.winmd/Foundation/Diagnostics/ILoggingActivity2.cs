// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingActivity2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(650287112, 25378, 17770, 175, 130, 128, 200, 100, 47, 23, 139)]
  [ExclusiveTo(typeof (LoggingActivity))]
  internal interface ILoggingActivity2 : ILoggingActivity, IClosable, ILoggingTarget
  {
    LoggingChannel Channel { get; }

    [Overload("StopActivity")]
    void StopActivity(string stopEventName);

    [Overload("StopActivityWithFields")]
    void StopActivity(string stopEventName, LoggingFields fields);

    [Overload("StopActivityWithFieldsAndOptions")]
    void StopActivity(string stopEventName, LoggingFields fields, LoggingOptions options);
  }
}
