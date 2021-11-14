// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITargetedContentContainerStatics), 65536, "Windows.Services.TargetedContent.TargetedContentContract")]
  public sealed class TargetedContentContainer : ITargetedContentContainer
  {
    public extern string Id { [MethodImpl] get; }

    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern TargetedContentAvailability Availability { [MethodImpl] get; }

    public extern TargetedContentCollection Content { [MethodImpl] get; }

    [MethodImpl]
    public extern TargetedContentObject SelectSingleObject(string path);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<TargetedContentContainer> GetAsync(
      string contentId);
  }
}
