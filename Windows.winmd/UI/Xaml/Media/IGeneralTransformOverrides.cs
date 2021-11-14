// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeneralTransformOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(1326583939, 9423, 17700, 144, 173, 138, 66, 177, 193, 39, 131)]
  [ExclusiveTo(typeof (GeneralTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeneralTransformOverrides
  {
    GeneralTransform InverseCore { get; }

    bool TryTransformCore(Point inPoint, out Point outPoint);

    Rect TransformBoundsCore(Rect rect);
  }
}
