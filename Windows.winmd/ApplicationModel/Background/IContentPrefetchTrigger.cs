// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IContentPrefetchTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1896228846, 1274, 17419, 128, 192, 23, 50, 2, 25, 158, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPrefetchTrigger))]
  internal interface IContentPrefetchTrigger : IBackgroundTrigger
  {
    TimeSpan WaitInterval { get; }
  }
}
