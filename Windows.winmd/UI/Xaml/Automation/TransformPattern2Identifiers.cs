// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.TransformPattern2Identifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITransformPattern2IdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TransformPattern2Identifiers : ITransformPattern2Identifiers
  {
    public static extern AutomationProperty CanZoomProperty { [MethodImpl] get; }

    public static extern AutomationProperty ZoomLevelProperty { [MethodImpl] get; }

    public static extern AutomationProperty MaxZoomProperty { [MethodImpl] get; }

    public static extern AutomationProperty MinZoomProperty { [MethodImpl] get; }
  }
}
