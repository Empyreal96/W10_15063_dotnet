// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionDrawingSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionDrawingSurface))]
  [Guid(2707866368, 64208, 19729, 158, 103, 228, 51, 22, 47, 244, 158)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  internal interface ICompositionDrawingSurface
  {
    DirectXAlphaMode AlphaMode { get; }

    DirectXPixelFormat PixelFormat { get; }

    Size Size { get; }
  }
}
