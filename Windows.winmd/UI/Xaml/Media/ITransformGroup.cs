// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITransformGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (TransformGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1665240268, 36141, 18231, 185, 81, 42, 252, 225, 221, 196, 196)]
  internal interface ITransformGroup
  {
    TransformCollection Children { get; set; }

    Matrix Value { get; }
  }
}
