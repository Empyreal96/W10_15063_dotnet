// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IDragPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(704984989, 5973, 16514, 157, 144, 70, 241, 65, 29, 121, 134)]
  [ExclusiveTo(typeof (DragPatternIdentifiers))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDragPatternIdentifiersStatics
  {
    AutomationProperty DropEffectProperty { get; }

    AutomationProperty DropEffectsProperty { get; }

    AutomationProperty GrabbedItemsProperty { get; }

    AutomationProperty IsGrabbedProperty { get; }
  }
}
