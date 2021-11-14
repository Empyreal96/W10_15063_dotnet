// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDStreamParserNotifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3244797136, 11494, 17004, 172, 229, 94, 146, 117, 254, 167, 21)]
  [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public interface INDStreamParserNotifier
  {
    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnContentIDReceived(INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnMediaStreamDescriptorCreated(
      IVector<AudioStreamDescriptor> audioStreamDescriptors,
      IVector<VideoStreamDescriptor> videoStreamDescriptors);

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnSampleParsed(
      uint streamID,
      NDMediaStreamType streamType,
      MediaStreamSample streamSample,
      long pts,
      NDClosedCaptionFormat ccFormat,
      byte[] ccDataBytes);

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnBeginSetupDecryptor(IMediaStreamDescriptor descriptor, Guid keyID, byte[] proBytes);
  }
}
