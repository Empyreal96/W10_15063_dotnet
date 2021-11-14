// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreImmersiveApplication
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplication))]
  [WebHostHidden]
  [Guid(450498110, 58530, 16675, 180, 81, 220, 150, 191, 128, 4, 25)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreImmersiveApplication
  {
    IVectorView<CoreApplicationView> Views { get; }

    [DefaultOverload]
    [Overload("CreateNewView")]
    CoreApplicationView CreateNewView(string runtimeType, string entryPoint);

    CoreApplicationView MainView { get; }
  }
}
