// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IRangeBaseAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class RangeBaseAutomationPeer : 
    FrameworkElementAutomationPeer,
    IRangeBaseAutomationPeer,
    IRangeValueProvider
  {
    [MethodImpl]
    public extern RangeBaseAutomationPeer(RangeBase owner);

    public extern bool IsReadOnly { [MethodImpl] get; }

    public extern double LargeChange { [MethodImpl] get; }

    public extern double Maximum { [MethodImpl] get; }

    public extern double Minimum { [MethodImpl] get; }

    public extern double SmallChange { [MethodImpl] get; }

    public extern double Value { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetValue(double value);
  }
}
