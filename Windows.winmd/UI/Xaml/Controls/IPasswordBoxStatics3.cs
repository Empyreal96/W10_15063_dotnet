// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBoxStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2731397913, 44394, 17234, 181, 144, 246, 150, 255, 203, 142, 63)]
  [ExclusiveTo(typeof (PasswordBox))]
  [WebHostHidden]
  internal interface IPasswordBoxStatics3
  {
    DependencyProperty PasswordRevealModeProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }

    DependencyProperty InputScopeProperty { get; }
  }
}
