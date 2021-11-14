// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceAudioNotificationRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [ContractVersion(typeof (GuidanceContract), 131072)]
  [Guid(3391791690, 51138, 19788, 157, 124, 73, 149, 118, 188, 237, 219)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GuidanceAudioNotificationRequestedEventArgs))]
  internal interface IGuidanceAudioNotificationRequestedEventArgs
  {
    GuidanceAudioNotificationKind AudioNotification { get; }

    IVectorView<string> AudioFilePaths { get; }

    string AudioText { get; }
  }
}
