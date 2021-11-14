// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDropTargetItemThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(411158888, 6180, 17963, 135, 232, 195, 87, 33, 43, 151, 123)]
  [ExclusiveTo(typeof (DropTargetItemThemeAnimation))]
  internal interface IDropTargetItemThemeAnimation
  {
    string TargetName { get; set; }
  }
}
