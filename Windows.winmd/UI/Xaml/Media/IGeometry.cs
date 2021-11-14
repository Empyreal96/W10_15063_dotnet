// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeometry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(4195498121, 2765, 16763, 182, 45, 92, 161, 191, 77, 252, 14)]
  [ExclusiveTo(typeof (Geometry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IGeometry
  {
    Transform Transform { get; set; }

    Rect Bounds { get; }
  }
}
