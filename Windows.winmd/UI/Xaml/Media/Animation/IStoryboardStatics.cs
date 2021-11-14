// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IStoryboardStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(3626960856, 29653, 17273, 189, 72, 126, 5, 24, 74, 139, 173)]
  [ExclusiveTo(typeof (Storyboard))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStoryboardStatics
  {
    DependencyProperty TargetPropertyProperty { get; }

    string GetTargetProperty(Timeline element);

    void SetTargetProperty(Timeline element, string path);

    DependencyProperty TargetNameProperty { get; }

    string GetTargetName(Timeline element);

    void SetTargetName(Timeline element, string name);

    void SetTarget(Timeline timeline, DependencyObject target);
  }
}
