// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannelFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (LoggingChannel))]
  [Guid(1323064220, 44928, 19099, 176, 220, 57, 143, 154, 229, 32, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILoggingChannelFactory
  {
    [Deprecated("This constructor creates a LoggingChannel in Windows 8.1 compatibility mode. Prefer the two-parameter constructor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    LoggingChannel Create(string name);
  }
}
