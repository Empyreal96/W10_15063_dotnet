// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1439010910, 11207, 16397, 170, 164, 26, 41, 129, 73, 30, 224)]
  [ExclusiveTo(typeof (VisualTransition))]
  internal interface IVisualTransition
  {
    Duration GeneratedDuration { get; set; }

    EasingFunctionBase GeneratedEasingFunction { get; set; }

    string To { get; set; }

    string From { get; set; }

    Storyboard Storyboard { get; set; }
  }
}
