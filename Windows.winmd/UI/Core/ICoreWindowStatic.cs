// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindowStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreWindow))]
  [Guid(1294176261, 15402, 16817, 144, 34, 83, 107, 185, 207, 147, 177)]
  [WebHostHidden]
  internal interface ICoreWindowStatic
  {
    CoreWindow GetForCurrentThread();
  }
}
