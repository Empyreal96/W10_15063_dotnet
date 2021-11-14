// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapElement))]
  [WebHostHidden]
  [Guid(3592406239, 45637, 18418, 154, 194, 67, 192, 88, 177, 201, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapElement
  {
    int ZIndex { get; set; }

    bool Visible { get; set; }
  }
}
