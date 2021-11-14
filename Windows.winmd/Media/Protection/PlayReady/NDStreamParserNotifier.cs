// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDStreamParserNotifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("NDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class NDStreamParserNotifier : INDStreamParserNotifier
  {
    [MethodImpl]
    public extern NDStreamParserNotifier();

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void OnContentIDReceived(INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void OnMediaStreamDescriptorCreated(
      IVector<AudioStreamDescriptor> audioStreamDescriptors,
      IVector<VideoStreamDescriptor> videoStreamDescriptors);

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void OnSampleParsed(
      uint streamID,
      NDMediaStreamType streamType,
      MediaStreamSample streamSample,
      long pts,
      NDClosedCaptionFormat ccFormat,
      byte[] ccDataBytes);

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void OnBeginSetupDecryptor(
      IMediaStreamDescriptor descriptor,
      Guid keyID,
      byte[] proBytes);
  }
}
