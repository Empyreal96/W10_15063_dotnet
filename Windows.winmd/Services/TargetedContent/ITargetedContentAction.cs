// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentAction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [ExclusiveTo(typeof (TargetedContentAction))]
  [Guid(3613092126, 27862, 19616, 157, 143, 71, 40, 176, 183, 230, 182)]
  internal interface ITargetedContentAction
  {
    [RemoteAsync]
    IAsyncAction InvokeAsync();
  }
}
