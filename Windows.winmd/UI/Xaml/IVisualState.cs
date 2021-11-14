// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [Guid(1663086588, 49946, 17488, 175, 222, 246, 234, 123, 209, 245, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualState))]
  internal interface IVisualState
  {
    string Name { get; }

    Storyboard Storyboard { get; set; }
  }
}
