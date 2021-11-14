// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IObjectKeyFrameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ObjectKeyFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(371594302, 15981, 17624, 155, 154, 4, 174, 167, 15, 132, 146)]
  internal interface IObjectKeyFrameFactory
  {
    ObjectKeyFrame CreateInstance(object outer, out object inner);
  }
}
