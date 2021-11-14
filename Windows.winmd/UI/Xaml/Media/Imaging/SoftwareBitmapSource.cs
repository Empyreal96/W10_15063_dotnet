// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.SoftwareBitmapSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class SoftwareBitmapSource : ImageSource, ISoftwareBitmapSource, IClosable
  {
    [MethodImpl]
    public extern SoftwareBitmapSource();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetBitmapAsync(SoftwareBitmap softwareBitmap);

    [MethodImpl]
    public extern void Close();
  }
}
