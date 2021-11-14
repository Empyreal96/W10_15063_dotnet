// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapEncoderWithSoftwareBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(1751962177, 17200, 19575, 172, 228, 3, 52, 150, 139, 23, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapEncoder))]
  internal interface IBitmapEncoderWithSoftwareBitmap
  {
    void SetSoftwareBitmap(SoftwareBitmap bitmap);
  }
}
