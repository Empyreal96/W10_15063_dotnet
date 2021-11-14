// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ISizeHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SizeHelper))]
  [Guid(1652999602, 53112, 18709, 170, 64, 118, 0, 74, 22, 95, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISizeHelperStatics
  {
    Size Empty { get; }

    Size FromDimensions(float width, float height);

    bool GetIsEmpty(Size target);

    bool Equals(Size target, Size value);
  }
}
