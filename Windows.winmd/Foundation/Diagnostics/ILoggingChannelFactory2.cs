// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannelFactory2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Guid(1282340317, 15143, 19913, 153, 240, 41, 156, 110, 70, 3, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LoggingChannel))]
  internal interface ILoggingChannelFactory2
  {
    LoggingChannel CreateWithOptions(string name, LoggingChannelOptions options);

    LoggingChannel CreateWithOptionsAndId(
      string name,
      LoggingChannelOptions options,
      Guid id);
  }
}
