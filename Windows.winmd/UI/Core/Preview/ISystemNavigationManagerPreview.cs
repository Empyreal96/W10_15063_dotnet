// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.ISystemNavigationManagerPreview
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  [Guid(3965650056, 25637, 18295, 165, 54, 203, 86, 52, 66, 127, 13)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SystemNavigationManagerPreview))]
  internal interface ISystemNavigationManagerPreview
  {
    event EventHandler<SystemNavigationCloseRequestedPreviewEventArgs> CloseRequested;
  }
}
