// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextSubformat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class TimedTextSubformat : ITimedTextSubformat
  {
    [MethodImpl]
    public extern TimedTextSubformat();

    public extern int StartIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern int Length { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextStyle SubformatStyle { [MethodImpl] get; [MethodImpl] set; }
  }
}
