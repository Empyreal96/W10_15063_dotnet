// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ServiceRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Protection
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ServiceRequestedEventArgs : 
    IServiceRequestedEventArgs,
    IServiceRequestedEventArgs2
  {
    public extern IMediaProtectionServiceRequest Request { [MethodImpl] get; }

    public extern MediaProtectionServiceCompletion Completion { [MethodImpl] get; }

    public extern MediaPlaybackItem MediaPlaybackItem { [MethodImpl] get; }
  }
}
