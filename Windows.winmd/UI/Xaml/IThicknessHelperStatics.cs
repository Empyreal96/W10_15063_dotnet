// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IThicknessHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3231259260, 1804, 19878, 135, 132, 1, 202, 128, 14, 183, 58)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ThicknessHelper))]
  internal interface IThicknessHelperStatics
  {
    Thickness FromLengths(double left, double top, double right, double bottom);

    Thickness FromUniformLength(double uniformLength);
  }
}
