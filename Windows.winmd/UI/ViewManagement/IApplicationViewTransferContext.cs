// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewTransferContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2239020131, 15383, 16526, 148, 8, 138, 26, 158, 168, 27, 250)]
  [ExclusiveTo(typeof (ApplicationViewTransferContext))]
  internal interface IApplicationViewTransferContext
  {
    int ViewId { get; set; }
  }
}
