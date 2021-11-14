// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [DualApiPartition(version = 167772163)]
  public sealed class TargetedContentChangedEventArgs : ITargetedContentChangedEventArgs
  {
    [MethodImpl]
    public extern Deferral GetDeferral();

    public extern bool HasPreviousContentExpired { [MethodImpl] get; }
  }
}
