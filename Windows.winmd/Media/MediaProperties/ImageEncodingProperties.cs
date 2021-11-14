// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.ImageEncodingProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IImageEncodingPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IImageEncodingPropertiesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ImageEncodingProperties : IImageEncodingProperties, IMediaEncodingProperties
  {
    [MethodImpl]
    public extern ImageEncodingProperties();

    public extern uint Width { [MethodImpl] set; [MethodImpl] get; }

    public extern uint Height { [MethodImpl] set; [MethodImpl] get; }

    public extern MediaPropertySet Properties { [MethodImpl] get; }

    public extern string Type { [MethodImpl] get; }

    public extern string Subtype { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public static extern ImageEncodingProperties CreateUncompressed(
      MediaPixelFormat format);

    [MethodImpl]
    public static extern ImageEncodingProperties CreateBmp();

    [MethodImpl]
    public static extern ImageEncodingProperties CreateJpeg();

    [MethodImpl]
    public static extern ImageEncodingProperties CreatePng();

    [MethodImpl]
    public static extern ImageEncodingProperties CreateJpegXR();
  }
}
