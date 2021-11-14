// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAnnotationPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3773014877, 53607, 18140, 149, 171, 51, 10, 246, 26, 235, 181)]
  [ExclusiveTo(typeof (AnnotationPatternIdentifiers))]
  [WebHostHidden]
  internal interface IAnnotationPatternIdentifiersStatics
  {
    AutomationProperty AnnotationTypeIdProperty { get; }

    AutomationProperty AnnotationTypeNameProperty { get; }

    AutomationProperty AuthorProperty { get; }

    AutomationProperty DateTimeProperty { get; }

    AutomationProperty TargetProperty { get; }
  }
}
