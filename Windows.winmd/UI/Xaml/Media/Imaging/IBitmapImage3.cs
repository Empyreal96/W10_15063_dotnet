// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapImage3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4057886502, 15475, 17727, 167, 186, 155, 133, 193, 139, 55, 51)]
  [ExclusiveTo(typeof (BitmapImage))]
  internal interface IBitmapImage3
  {
    bool IsAnimatedBitmap { get; }

    bool IsPlaying { get; }

    bool AutoPlay { get; set; }

    void Play();

    void Stop();
  }
}
