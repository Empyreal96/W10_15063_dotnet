// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IUINavigationController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ExclusiveTo(typeof (UINavigationController))]
  [Guid(3853447133, 62734, 19029, 140, 220, 211, 50, 41, 84, 129, 117)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUINavigationController : IGameController
  {
    UINavigationReading GetCurrentReading();

    GameControllerButtonLabel GetOptionalButtonLabel(
      OptionalUINavigationButtons button);

    GameControllerButtonLabel GetRequiredButtonLabel(
      RequiredUINavigationButtons button);
  }
}
