// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDoubleKeyFrameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2895634115, 30008, 16569, 177, 82, 105, 111, 127, 191, 71, 34)]
  [ExclusiveTo(typeof (DoubleKeyFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDoubleKeyFrameFactory
  {
    DoubleKeyFrame CreateInstance(object outer, out object inner);
  }
}
