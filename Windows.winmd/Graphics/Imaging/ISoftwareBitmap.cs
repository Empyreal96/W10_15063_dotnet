// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ISoftwareBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  [Guid(1755186952, 32495, 18495, 150, 63, 218, 147, 136, 24, 224, 115)]
  [ExclusiveTo(typeof (SoftwareBitmap))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISoftwareBitmap : IClosable
  {
    BitmapPixelFormat BitmapPixelFormat { get; }

    BitmapAlphaMode BitmapAlphaMode { get; }

    int PixelWidth { get; }

    int PixelHeight { get; }

    bool IsReadOnly { get; }

    double DpiX { set; get; }

    double DpiY { set; get; }

    BitmapBuffer LockBuffer(BitmapBufferAccessMode mode);

    void CopyTo(SoftwareBitmap bitmap);

    void CopyFromBuffer(IBuffer buffer);

    void CopyToBuffer(IBuffer buffer);

    SoftwareBitmap GetReadOnlyView();
  }
}
