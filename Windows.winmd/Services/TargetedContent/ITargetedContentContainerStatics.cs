// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentContainerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [ExclusiveTo(typeof (TargetedContentContainer))]
  [Guid(1531439099, 8512, 19487, 167, 54, 197, 149, 131, 242, 39, 216)]
  internal interface ITargetedContentContainerStatics
  {
    [RemoteAsync]
    IAsyncOperation<TargetedContentContainer> GetAsync(
      string contentId);
  }
}
