// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISoftwareBitmapSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Guid(3537739472, 54213, 16470, 145, 181, 183, 193, 209, 232, 19, 14)]
  [ExclusiveTo(typeof (SoftwareBitmapSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISoftwareBitmapSource
  {
    [RemoteAsync]
    IAsyncAction SetBitmapAsync(SoftwareBitmap softwareBitmap);
  }
}
