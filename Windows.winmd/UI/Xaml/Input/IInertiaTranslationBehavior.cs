// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInertiaTranslationBehavior
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ExclusiveTo(typeof (InertiaTranslationBehavior))]
  [Guid(1171498258, 15154, 18562, 164, 194, 236, 250, 45, 75, 109, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInertiaTranslationBehavior
  {
    double DesiredDeceleration { get; set; }

    double DesiredDisplacement { get; set; }
  }
}
