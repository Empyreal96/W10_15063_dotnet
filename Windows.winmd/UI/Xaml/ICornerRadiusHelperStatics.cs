// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ICornerRadiusHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4104255065, 54484, 17695, 163, 135, 214, 191, 75, 36, 81, 212)]
  [ExclusiveTo(typeof (CornerRadiusHelper))]
  internal interface ICornerRadiusHelperStatics
  {
    CornerRadius FromRadii(
      double topLeft,
      double topRight,
      double bottomRight,
      double bottomLeft);

    CornerRadius FromUniformRadius(double uniformRadius);
  }
}
