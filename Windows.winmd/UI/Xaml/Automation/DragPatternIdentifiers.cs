// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.DragPatternIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDragPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DragPatternIdentifiers : IDragPatternIdentifiers
  {
    public static extern AutomationProperty DropEffectProperty { [MethodImpl] get; }

    public static extern AutomationProperty DropEffectsProperty { [MethodImpl] get; }

    public static extern AutomationProperty GrabbedItemsProperty { [MethodImpl] get; }

    public static extern AutomationProperty IsGrabbedProperty { [MethodImpl] get; }
  }
}
