// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IContentPrefetcherTime
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(3814849800, 4906, 20446, 167, 204, 252, 176, 230, 101, 35, 175)]
  [ExclusiveTo(typeof (ContentPrefetcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentPrefetcherTime
  {
    IReference<DateTime> LastSuccessfulPrefetchTime { get; }
  }
}
