// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTargetCameraChangedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2545988402, 62134, 17931, 141, 145, 172, 2, 10, 35, 131, 221)]
  [ExclusiveTo(typeof (MapTargetCameraChangedEventArgs))]
  [WebHostHidden]
  internal interface IMapTargetCameraChangedEventArgs2
  {
    MapCameraChangeReason ChangeReason { get; }
  }
}
