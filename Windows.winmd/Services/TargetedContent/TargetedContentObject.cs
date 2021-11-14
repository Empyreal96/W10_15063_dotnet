// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TargetedContentObject : ITargetedContentObject
  {
    public extern TargetedContentObjectKind ObjectKind { [MethodImpl] get; }

    public extern TargetedContentCollection Collection { [MethodImpl] get; }

    public extern TargetedContentItem Item { [MethodImpl] get; }

    public extern TargetedContentValue Value { [MethodImpl] get; }
  }
}
