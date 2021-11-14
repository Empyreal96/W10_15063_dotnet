// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IGridLengthHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2638576539, 415, 16998, 136, 114, 33, 95, 25, 143, 106, 157)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GridLengthHelper))]
  [WebHostHidden]
  internal interface IGridLengthHelperStatics
  {
    GridLength Auto { get; }

    GridLength FromPixels(double pixels);

    GridLength FromValueAndType(double value, GridUnitType type);

    bool GetIsAbsolute(GridLength target);

    bool GetIsAuto(GridLength target);

    bool GetIsStar(GridLength target);

    bool Equals(GridLength target, GridLength value);
  }
}
