// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(4208906423, 47180, 18580, 135, 170, 143, 37, 170, 95, 40, 139)]
  [ExclusiveTo(typeof (RadialController))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRadialControllerStatics
  {
    bool IsSupported();

    RadialController CreateForCurrentView();
  }
}
