// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoTrackOpenFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1987699249, 1273, 19586, 164, 238, 134, 2, 200, 187, 71, 84)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (VideoTrackOpenFailedEventArgs))]
  internal interface IVideoTrackOpenFailedEventArgs
  {
    HResult ExtendedError { get; }
  }
}
