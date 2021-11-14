// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapActualCameraChangedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(2074396645, 4316, 17754, 157, 4, 29, 114, 251, 109, 155, 147)]
  [ExclusiveTo(typeof (MapActualCameraChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMapActualCameraChangedEventArgs2
  {
    MapCameraChangeReason ChangeReason { get; }
  }
}
