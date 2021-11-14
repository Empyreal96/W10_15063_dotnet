// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPathGeometry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(136027640, 47846, 19403, 129, 60, 189, 224, 228, 109, 200, 183)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PathGeometry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPathGeometry
  {
    FillRule FillRule { get; set; }

    PathFigureCollection Figures { get; set; }
  }
}
