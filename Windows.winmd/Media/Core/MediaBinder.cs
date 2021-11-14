// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaBinder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaBinder : IMediaBinder
  {
    [MethodImpl]
    public extern MediaBinder();

    public extern event TypedEventHandler<MediaBinder, MediaBindingEventArgs> Binding;

    public extern string Token { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaSource Source { [MethodImpl] get; }
  }
}
