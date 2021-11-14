// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapTypedValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2463872409, 52755, 18107, 149, 69, 203, 58, 63, 99, 235, 139)]
  [ExclusiveTo(typeof (BitmapTypedValue))]
  internal interface IBitmapTypedValueFactory
  {
    BitmapTypedValue Create(object value, PropertyType type);
  }
}
