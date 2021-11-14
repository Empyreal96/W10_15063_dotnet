// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskBuilder3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskBuilder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(684150602, 35753, 19465, 162, 79, 25, 104, 62, 44, 146, 76)]
  internal interface IBackgroundTaskBuilder3 : IBackgroundTaskBuilder
  {
    bool IsNetworkRequested { set; get; }
  }
}
