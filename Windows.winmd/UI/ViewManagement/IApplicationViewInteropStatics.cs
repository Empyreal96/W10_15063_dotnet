// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewInteropStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(3292986205, 18323, 18582, 168, 226, 190, 87, 168, 187, 15, 80)]
  [WebHostHidden]
  internal interface IApplicationViewInteropStatics
  {
    int GetApplicationViewIdForWindow(ICoreWindow window);
  }
}
