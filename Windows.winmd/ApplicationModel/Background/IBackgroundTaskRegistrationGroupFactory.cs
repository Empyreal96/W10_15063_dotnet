// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistrationGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2212047721, 17615, 17969, 151, 64, 3, 199, 216, 116, 27, 197)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BackgroundTaskRegistrationGroup))]
  internal interface IBackgroundTaskRegistrationGroupFactory
  {
    BackgroundTaskRegistrationGroup Create(string id);

    BackgroundTaskRegistrationGroup CreateWithName(
      string id,
      string name);
  }
}
