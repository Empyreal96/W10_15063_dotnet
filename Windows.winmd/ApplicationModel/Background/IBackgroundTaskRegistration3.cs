// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistration3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(4264788373, 37923, 19851, 131, 13, 177, 221, 44, 123, 173, 213)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface IBackgroundTaskRegistration3 : IBackgroundTaskRegistration
  {
    BackgroundTaskRegistrationGroup TaskGroup { get; }
  }
}
