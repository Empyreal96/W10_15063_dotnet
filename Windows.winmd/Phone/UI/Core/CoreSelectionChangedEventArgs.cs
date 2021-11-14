// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Core.CoreSelectionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Core
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class CoreSelectionChangedEventArgs : ICoreSelectionChangedEventArgs
  {
    public extern uint Start { [MethodImpl] get; }

    public extern uint Length { [MethodImpl] get; }
  }
}
