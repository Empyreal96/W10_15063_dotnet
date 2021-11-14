// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IUINavigationControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(789877514, 63224, 19016, 141, 137, 148, 120, 108, 202, 12, 46)]
  [ExclusiveTo(typeof (UINavigationController))]
  internal interface IUINavigationControllerStatics
  {
    event EventHandler<UINavigationController> UINavigationControllerAdded;

    event EventHandler<UINavigationController> UINavigationControllerRemoved;

    IVectorView<UINavigationController> UINavigationControllers { get; }
  }
}
