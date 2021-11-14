// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.PhotosZuneNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Devices
{
  [SecurityCritical]
  internal static class PhotosZuneNativeMethods
  {
    [DllImport("PhotosAPI.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
    internal static extern void MediaApi_EncodeARGBIntoJpegStream(
      int[] pixelBuffer,
      uint pixelWidth,
      uint pixelHeight,
      uint targetWidth,
      uint targetHeight,
      uint orientation,
      uint quality,
      uint bufferSize,
      ReaderCallbackSig pfnRead,
      SeekCallbackSig pfnSeek,
      WriteCallbackSig pfnWrite,
      ulong lengthOfStream);

    [DllImport("PhotosAPI.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
    internal static extern void MediaApi_DecodeJpegStreamIntoARGB(
      ReaderCallbackSig pfnRead,
      SeekCallbackSig pfnSeek,
      ulong lengthOfStream,
      uint bufferSize,
      int[] pixelBuffer,
      uint pixelWidth,
      uint pixelHeight);

    [DllImport("PhotosAPI.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
    internal static extern void MediaApi_GetJpegBoundsWithLimit(
      ReaderCallbackSig pfnRead,
      SeekCallbackSig pfnSeek,
      ulong lengthOfStream,
      uint pixelWidth,
      uint pixelHeight,
      out uint widthNeeded,
      out uint heightNeeded);
  }
}
