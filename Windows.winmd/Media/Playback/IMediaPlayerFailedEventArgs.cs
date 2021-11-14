// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(658827705, 42979, 20246, 186, 196, 121, 20, 235, 192, 131, 1)]
  [ExclusiveTo(typeof (MediaPlayerFailedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayerFailedEventArgs
  {
    MediaPlayerError Error { get; }

    HResult ExtendedErrorCode { get; }

    string ErrorMessage { get; }
  }
}
