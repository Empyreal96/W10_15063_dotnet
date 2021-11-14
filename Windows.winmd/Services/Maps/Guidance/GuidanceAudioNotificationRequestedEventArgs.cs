// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceAudioNotificationRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (GuidanceContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GuidanceAudioNotificationRequestedEventArgs : 
    IGuidanceAudioNotificationRequestedEventArgs
  {
    public extern GuidanceAudioNotificationKind AudioNotification { [MethodImpl] get; }

    public extern IVectorView<string> AudioFilePaths { [MethodImpl] get; }

    public extern string AudioText { [MethodImpl] get; }
  }
}
