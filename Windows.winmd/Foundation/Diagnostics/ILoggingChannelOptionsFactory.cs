// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannelOptionsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2838581722, 32687, 16785, 135, 85, 94, 134, 220, 101, 216, 150)]
  [ExclusiveTo(typeof (LoggingChannelOptions))]
  internal interface ILoggingChannelOptionsFactory
  {
    LoggingChannelOptions Create(Guid group);
  }
}
