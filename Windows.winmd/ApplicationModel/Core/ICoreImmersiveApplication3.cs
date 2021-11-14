// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreImmersiveApplication3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [WebHostHidden]
  [Guid(882924335, 60941, 16869, 131, 20, 207, 16, 201, 27, 240, 175)]
  [ExclusiveTo(typeof (CoreApplication))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreImmersiveApplication3
  {
    [Overload("CreateNewViewWithViewSource")]
    CoreApplicationView CreateNewView(IFrameworkViewSource viewSource);
  }
}
