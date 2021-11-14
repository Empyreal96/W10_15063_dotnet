// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IWriteableBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3205201519, 57212, 19077, 132, 19, 161, 33, 98, 133, 131, 92)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WriteableBitmap))]
  internal interface IWriteableBitmap
  {
    IBuffer PixelBuffer { get; }

    void Invalidate();
  }
}
