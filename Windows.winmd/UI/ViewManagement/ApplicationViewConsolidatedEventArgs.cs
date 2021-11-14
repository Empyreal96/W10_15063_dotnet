// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ApplicationViewConsolidatedEventArgs : 
    IApplicationViewConsolidatedEventArgs,
    IApplicationViewConsolidatedEventArgs2
  {
    public extern bool IsUserInitiated { [MethodImpl] get; }

    public extern bool IsAppInitiated { [MethodImpl] get; }
  }
}
