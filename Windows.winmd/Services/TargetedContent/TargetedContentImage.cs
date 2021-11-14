// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentImage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Services.TargetedContent
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  public sealed class TargetedContentImage : ITargetedContentImage, IRandomAccessStreamReference
  {
    public extern uint Height { [MethodImpl] get; }

    public extern uint Width { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();
  }
}
