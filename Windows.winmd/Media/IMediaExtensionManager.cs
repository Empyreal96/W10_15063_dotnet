// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaExtensionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(1243998965, 9261, 19963, 151, 244, 105, 183, 196, 37, 118, 255)]
  [ExclusiveTo(typeof (MediaExtensionManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaExtensionManager
  {
    [Overload("RegisterSchemeHandler")]
    void RegisterSchemeHandler(string activatableClassId, string scheme);

    [Overload("RegisterSchemeHandlerWithSettings")]
    void RegisterSchemeHandler(
      string activatableClassId,
      string scheme,
      IPropertySet configuration);

    [Overload("RegisterByteStreamHandler")]
    void RegisterByteStreamHandler(
      string activatableClassId,
      string fileExtension,
      string mimeType);

    [Overload("RegisterByteStreamHandlerWithSettings")]
    void RegisterByteStreamHandler(
      string activatableClassId,
      string fileExtension,
      string mimeType,
      IPropertySet configuration);

    [Overload("RegisterAudioDecoder")]
    void RegisterAudioDecoder(string activatableClassId, Guid inputSubtype, Guid outputSubtype);

    [Overload("RegisterAudioDecoderWithSettings")]
    void RegisterAudioDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterAudioEncoder")]
    void RegisterAudioEncoder(string activatableClassId, Guid inputSubtype, Guid outputSubtype);

    [Overload("RegisterAudioEncoderWithSettings")]
    void RegisterAudioEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterVideoDecoder")]
    void RegisterVideoDecoder(string activatableClassId, Guid inputSubtype, Guid outputSubtype);

    [Overload("RegisterVideoDecoderWithSettings")]
    void RegisterVideoDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterVideoEncoder")]
    void RegisterVideoEncoder(string activatableClassId, Guid inputSubtype, Guid outputSubtype);

    [Overload("RegisterVideoEncoderWithSettings")]
    void RegisterVideoEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);
  }
}
