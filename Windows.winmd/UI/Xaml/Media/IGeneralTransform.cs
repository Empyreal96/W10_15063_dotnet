// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeneralTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (GeneralTransform))]
  [Guid(2691143863, 41708, 16735, 173, 226, 234, 222, 147, 51, 242, 199)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeneralTransform
  {
    GeneralTransform Inverse { get; }

    Point TransformPoint(Point point);

    bool TryTransform(Point inPoint, out Point outPoint);

    Rect TransformBounds(Rect rect);
  }
}
