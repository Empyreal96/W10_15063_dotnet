// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapActualCameraChangingEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapActualCameraChangingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(4068898967, 16556, 20106, 169, 39, 81, 15, 56, 70, 164, 126)]
  [WebHostHidden]
  internal interface IMapActualCameraChangingEventArgs2
  {
    MapCameraChangeReason ChangeReason { get; }
  }
}
