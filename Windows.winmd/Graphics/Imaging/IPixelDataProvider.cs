// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IPixelDataProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(3716357925, 6236, 17813, 159, 185, 204, 190, 110, 193, 138, 111)]
  [ExclusiveTo(typeof (PixelDataProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPixelDataProvider
  {
    byte[] DetachPixelData();
  }
}
