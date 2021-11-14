// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.WindowPatternIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWindowPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class WindowPatternIdentifiers : IWindowPatternIdentifiers
  {
    public static extern AutomationProperty CanMaximizeProperty { [MethodImpl] get; }

    public static extern AutomationProperty CanMinimizeProperty { [MethodImpl] get; }

    public static extern AutomationProperty IsModalProperty { [MethodImpl] get; }

    public static extern AutomationProperty IsTopmostProperty { [MethodImpl] get; }

    public static extern AutomationProperty WindowInteractionStateProperty { [MethodImpl] get; }

    public static extern AutomationProperty WindowVisualStateProperty { [MethodImpl] get; }
  }
}
