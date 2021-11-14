// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.TransformPatternIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Static(typeof (ITransformPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TransformPatternIdentifiers : ITransformPatternIdentifiers
  {
    public static extern AutomationProperty CanMoveProperty { [MethodImpl] get; }

    public static extern AutomationProperty CanResizeProperty { [MethodImpl] get; }

    public static extern AutomationProperty CanRotateProperty { [MethodImpl] get; }
  }
}
