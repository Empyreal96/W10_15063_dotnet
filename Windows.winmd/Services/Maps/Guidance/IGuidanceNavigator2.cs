// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceNavigator2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [Guid(1826377937, 1052, 19443, 182, 51, 161, 1, 252, 47, 107, 87)]
  [ContractVersion(typeof (GuidanceContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GuidanceNavigator))]
  internal interface IGuidanceNavigator2
  {
    event TypedEventHandler<GuidanceNavigator, GuidanceAudioNotificationRequestedEventArgs> AudioNotificationRequested;

    bool IsGuidanceAudioMuted { get; set; }
  }
}
