// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IBeginStoryboard
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (BeginStoryboard))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1679335373, 18924, 20050, 166, 246, 85, 50, 76, 146, 16, 83)]
  internal interface IBeginStoryboard
  {
    Storyboard Storyboard { get; set; }
  }
}
