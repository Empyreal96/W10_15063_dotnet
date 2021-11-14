// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingOptionsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (LoggingOptions))]
  [Guid(3608397515, 39083, 17995, 159, 34, 163, 38, 132, 120, 54, 138)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILoggingOptionsFactory
  {
    LoggingOptions CreateWithKeywords(long keywords);
  }
}
