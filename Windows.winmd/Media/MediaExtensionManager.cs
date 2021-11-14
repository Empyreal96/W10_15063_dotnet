// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaExtensionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaExtensionManager : IMediaExtensionManager, IMediaExtensionManager2
  {
    [MethodImpl]
    public extern MediaExtensionManager();

    [Overload("RegisterSchemeHandler")]
    [MethodImpl]
    public extern void RegisterSchemeHandler(string activatableClassId, string scheme);

    [Overload("RegisterSchemeHandlerWithSettings")]
    [MethodImpl]
    public extern void RegisterSchemeHandler(
      string activatableClassId,
      string scheme,
      IPropertySet configuration);

    [Overload("RegisterByteStreamHandler")]
    [MethodImpl]
    public extern void RegisterByteStreamHandler(
      string activatableClassId,
      string fileExtension,
      string mimeType);

    [Overload("RegisterByteStreamHandlerWithSettings")]
    [MethodImpl]
    public extern void RegisterByteStreamHandler(
      string activatableClassId,
      string fileExtension,
      string mimeType,
      IPropertySet configuration);

    [Overload("RegisterAudioDecoder")]
    [MethodImpl]
    public extern void RegisterAudioDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype);

    [Overload("RegisterAudioDecoderWithSettings")]
    [MethodImpl]
    public extern void RegisterAudioDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterAudioEncoder")]
    [MethodImpl]
    public extern void RegisterAudioEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype);

    [Overload("RegisterAudioEncoderWithSettings")]
    [MethodImpl]
    public extern void RegisterAudioEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterVideoDecoder")]
    [MethodImpl]
    public extern void RegisterVideoDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype);

    [Overload("RegisterVideoDecoderWithSettings")]
    [MethodImpl]
    public extern void RegisterVideoDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterVideoEncoder")]
    [MethodImpl]
    public extern void RegisterVideoEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype);

    [Overload("RegisterVideoEncoderWithSettings")]
    [MethodImpl]
    public extern void RegisterVideoEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [MethodImpl]
    public extern void RegisterMediaExtensionForAppService(
      IMediaExtension extension,
      AppServiceConnection connection);
  }
}
