// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionVirtualDrawingSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.UI.Composition
{
  [Guid(2848163035, 34624, 20372, 139, 157, 182, 133, 33, 231, 134, 61)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CompositionVirtualDrawingSurface))]
  internal interface ICompositionVirtualDrawingSurface
  {
    void Trim(RectInt32[] rects);
  }
}
