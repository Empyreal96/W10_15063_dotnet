// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentItemState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class TargetedContentItemState : ITargetedContentItemState
  {
    public extern bool ShouldDisplay { [MethodImpl] get; }

    public extern TargetedContentAppInstallationState AppInstallationState { [MethodImpl] get; }
  }
}
