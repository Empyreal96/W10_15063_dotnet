// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreWindow))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(851578328, 64239, 17269, 162, 171, 50, 100, 14, 72, 21, 199)]
  internal interface ICoreWindow3
  {
    event TypedEventHandler<CoreWindow, ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested;

    string GetCurrentKeyEventDeviceId();
  }
}
