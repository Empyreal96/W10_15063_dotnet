// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplineColorKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(441080129, 8160, 18234, 142, 254, 67, 22, 216, 200, 98, 41)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplineColorKeyFrame))]
  internal interface ISplineColorKeyFrame
  {
    KeySpline KeySpline { get; set; }
  }
}
