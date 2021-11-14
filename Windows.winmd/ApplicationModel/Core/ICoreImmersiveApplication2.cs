// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreImmersiveApplication2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2190351926, 59875, 19708, 155, 102, 72, 183, 142, 169, 187, 44)]
  [ExclusiveTo(typeof (CoreApplication))]
  internal interface ICoreImmersiveApplication2
  {
    [Overload("CreateNewViewFromMainView")]
    CoreApplicationView CreateNewView();
  }
}
