// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioTrackOpenFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AudioTrackOpenFailedEventArgs))]
  [Guid(4007508409, 47996, 16658, 191, 118, 147, 132, 103, 111, 130, 75)]
  internal interface IAudioTrackOpenFailedEventArgs
  {
    HResult ExtendedError { get; }
  }
}
