// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ITransformPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TransformPatternIdentifiers))]
  [Guid(1165028779, 55045, 16580, 161, 220, 233, 172, 252, 239, 133, 246)]
  internal interface ITransformPatternIdentifiersStatics
  {
    AutomationProperty CanMoveProperty { get; }

    AutomationProperty CanResizeProperty { get; }

    AutomationProperty CanRotateProperty { get; }
  }
}
