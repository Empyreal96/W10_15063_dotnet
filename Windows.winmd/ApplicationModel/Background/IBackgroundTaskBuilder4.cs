// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskBuilder4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BackgroundTaskBuilder))]
  [Guid(1196811554, 52130, 20021, 189, 22, 166, 218, 127, 28, 25, 170)]
  internal interface IBackgroundTaskBuilder4 : IBackgroundTaskBuilder
  {
    BackgroundTaskRegistrationGroup TaskGroup { get; set; }
  }
}
