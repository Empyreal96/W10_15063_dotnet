// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.WriteableBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(typeof (IWriteableBitmapFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WriteableBitmap : BitmapSource, IWriteableBitmap
  {
    [MethodImpl]
    public extern WriteableBitmap(int pixelWidth, int pixelHeight);

    public extern IBuffer PixelBuffer { [MethodImpl] get; }

    [MethodImpl]
    public extern void Invalidate();
  }
}
