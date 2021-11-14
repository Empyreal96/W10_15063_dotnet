// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILineGeometry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(820892834, 36805, 16559, 167, 162, 194, 127, 231, 170, 19, 99)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LineGeometry))]
  [WebHostHidden]
  internal interface ILineGeometry
  {
    Point StartPoint { get; set; }

    Point EndPoint { get; set; }
  }
}
