// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ISectionsInViewChangedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class SectionsInViewChangedEventArgs : ISectionsInViewChangedEventArgs
  {
    public extern IVector<HubSection> AddedSections { [MethodImpl] get; }

    public extern IVector<HubSection> RemovedSections { [MethodImpl] get; }
  }
}
