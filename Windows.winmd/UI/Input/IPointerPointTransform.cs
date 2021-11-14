// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPointTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1298129231, 47228, 16424, 188, 156, 89, 233, 148, 127, 176, 86)]
  public interface IPointerPointTransform
  {
    IPointerPointTransform Inverse { get; }

    bool TryTransform(Point inPoint, out Point outPoint);

    Rect TransformBounds(Rect rect);
  }
}
