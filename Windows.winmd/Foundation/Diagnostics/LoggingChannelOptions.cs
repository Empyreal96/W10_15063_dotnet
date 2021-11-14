// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingChannelOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ILoggingChannelOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class LoggingChannelOptions : ILoggingChannelOptions
  {
    [MethodImpl]
    public extern LoggingChannelOptions();

    [MethodImpl]
    public extern LoggingChannelOptions(Guid group);

    public extern Guid Group { [MethodImpl] get; [MethodImpl] set; }
  }
}
