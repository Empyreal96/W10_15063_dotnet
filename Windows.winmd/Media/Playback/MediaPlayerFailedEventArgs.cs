// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayerFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaPlayerFailedEventArgs : IMediaPlayerFailedEventArgs
  {
    public extern MediaPlayerError Error { [MethodImpl] get; }

    public extern HResult ExtendedErrorCode { [MethodImpl] get; }

    public extern string ErrorMessage { [MethodImpl] get; }
  }
}
