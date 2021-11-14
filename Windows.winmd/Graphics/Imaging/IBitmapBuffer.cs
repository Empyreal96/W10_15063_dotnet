// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapBuffer))]
  [Guid(2772305092, 14748, 17292, 178, 143, 166, 58, 107, 131, 209, 161)]
  internal interface IBitmapBuffer : IMemoryBuffer, IClosable
  {
    int GetPlaneCount();

    BitmapPlaneDescription GetPlaneDescription(int index);
  }
}
