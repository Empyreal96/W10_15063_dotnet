// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ITimelineFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (Timeline))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(492223239, 48548, 18315, 138, 218, 235, 4, 213, 128, 205, 94)]
  internal interface ITimelineFactory
  {
    Timeline CreateInstance(object outer, out object inner);
  }
}
