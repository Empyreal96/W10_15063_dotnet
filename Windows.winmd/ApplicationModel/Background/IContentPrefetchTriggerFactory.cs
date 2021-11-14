// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IContentPrefetchTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(3261349594, 35331, 16542, 184, 196, 136, 129, 76, 40, 204, 182)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPrefetchTrigger))]
  internal interface IContentPrefetchTriggerFactory
  {
    ContentPrefetchTrigger Create(TimeSpan waitInterval);
  }
}
