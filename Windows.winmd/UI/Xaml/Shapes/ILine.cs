// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.ILine
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [Guid(1185235773, 20475, 18655, 135, 50, 78, 21, 200, 52, 129, 107)]
  [ExclusiveTo(typeof (Line))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ILine
  {
    double X1 { get; set; }

    double Y1 { get; set; }

    double X2 { get; set; }

    double Y2 { get; set; }
  }
}
