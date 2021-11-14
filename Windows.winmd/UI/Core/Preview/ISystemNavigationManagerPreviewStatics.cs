// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.ISystemNavigationManagerPreviewStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  [ExclusiveTo(typeof (SystemNavigationManagerPreview))]
  [Guid(244781920, 57204, 19406, 132, 203, 189, 17, 129, 172, 10, 113)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISystemNavigationManagerPreviewStatics
  {
    SystemNavigationManagerPreview GetForCurrentView();
  }
}
