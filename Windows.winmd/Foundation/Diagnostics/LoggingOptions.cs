// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ILoggingOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class LoggingOptions : ILoggingOptions
  {
    [MethodImpl]
    public extern LoggingOptions();

    [MethodImpl]
    public extern LoggingOptions(long keywords);

    public extern long Keywords { [MethodImpl] get; [MethodImpl] set; }

    public extern int Tags { [MethodImpl] get; [MethodImpl] set; }

    public extern short Task { [MethodImpl] get; [MethodImpl] set; }

    public extern LoggingOpcode Opcode { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid ActivityId { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid RelatedActivityId { [MethodImpl] get; [MethodImpl] set; }
  }
}
