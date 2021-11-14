// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindowResizeManagerLayoutCapability
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreWindowResizeManager))]
  [Guid(3145003643, 42308, 17153, 128, 230, 10, 224, 51, 239, 69, 54)]
  internal interface ICoreWindowResizeManagerLayoutCapability
  {
    bool ShouldWaitForLayoutCompletion { set; get; }
  }
}
