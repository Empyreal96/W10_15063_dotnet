// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AnnotationPatternIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAnnotationPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AnnotationPatternIdentifiers : IAnnotationPatternIdentifiers
  {
    public static extern AutomationProperty AnnotationTypeIdProperty { [MethodImpl] get; }

    public static extern AutomationProperty AnnotationTypeNameProperty { [MethodImpl] get; }

    public static extern AutomationProperty AuthorProperty { [MethodImpl] get; }

    public static extern AutomationProperty DateTimeProperty { [MethodImpl] get; }

    public static extern AutomationProperty TargetProperty { [MethodImpl] get; }
  }
}
