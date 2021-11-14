// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindowResizeManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [Guid(3102783781, 45904, 18611, 161, 152, 92, 26, 132, 112, 2, 67)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreWindowResizeManager))]
  internal interface ICoreWindowResizeManager
  {
    void NotifyLayoutCompleted();
  }
}
