// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DTextureResource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing3D
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  public sealed class Printing3DTextureResource : IPrinting3DTextureResource
  {
    [MethodImpl]
    public extern Printing3DTextureResource();

    public extern IRandomAccessStreamWithContentType TextureData { [MethodImpl] get; [MethodImpl] set; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }
  }
}
