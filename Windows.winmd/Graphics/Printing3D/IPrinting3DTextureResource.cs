// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DTextureResource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DTextureResource))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(2802709293, 27313, 17582, 188, 69, 162, 115, 130, 192, 211, 140)]
  internal interface IPrinting3DTextureResource
  {
    IRandomAccessStreamWithContentType TextureData { get; set; }

    string Name { get; set; }
  }
}
