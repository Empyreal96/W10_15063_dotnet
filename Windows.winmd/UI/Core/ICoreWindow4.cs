// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(902492368, 18416, 17260, 175, 151, 13, 216, 143, 111, 95, 2)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreWindow))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICoreWindow4
  {
    event TypedEventHandler<CoreWindow, object> ResizeStarted;

    event TypedEventHandler<CoreWindow, object> ResizeCompleted;
  }
}
