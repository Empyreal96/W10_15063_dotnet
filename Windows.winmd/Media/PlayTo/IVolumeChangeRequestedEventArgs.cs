// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IVolumeChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (VolumeChangeRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1862430044, 53109, 19499, 145, 62, 109, 124, 108, 50, 145, 121)]
  internal interface IVolumeChangeRequestedEventArgs
  {
    double Volume { get; }
  }
}
