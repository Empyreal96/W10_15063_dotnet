// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannelOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Guid(3286779903, 3771, 19027, 140, 84, 222, 194, 73, 38, 203, 44)]
  [ExclusiveTo(typeof (LoggingChannelOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILoggingChannelOptions
  {
    Guid Group { get; set; }
  }
}
