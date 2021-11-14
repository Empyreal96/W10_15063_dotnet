// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (TextElement))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2979455522, 51726, 18601, 131, 188, 54, 206, 80, 86, 106, 199)]
  internal interface ITextElement4
  {
    TextDecorations TextDecorations { get; set; }

    bool IsAccessKeyScope { get; set; }

    DependencyObject AccessKeyScopeOwner { get; set; }

    KeyTipPlacementMode KeyTipPlacementMode { get; set; }

    double KeyTipHorizontalOffset { get; set; }

    double KeyTipVerticalOffset { get; set; }

    event TypedEventHandler<TextElement, AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested;

    event TypedEventHandler<TextElement, AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed;

    event TypedEventHandler<TextElement, AccessKeyInvokedEventArgs> AccessKeyInvoked;
  }
}
