// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextCompositionStartedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreTextCompositionStartedEventArgs : ICoreTextCompositionStartedEventArgs
  {
    public extern bool IsCanceled { [MethodImpl] get; }

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
