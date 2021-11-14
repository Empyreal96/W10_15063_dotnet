// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX.Direct3D11
{
  [Guid(200581446, 5057, 18068, 190, 227, 122, 191, 21, 234, 245, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDirect3DSurface : IClosable
  {
    Direct3DSurfaceDescription Description { get; }
  }
}
