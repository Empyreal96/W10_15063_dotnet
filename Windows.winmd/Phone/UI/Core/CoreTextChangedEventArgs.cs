// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Core.CoreTextChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class CoreTextChangedEventArgs : ICoreTextChangedEventArgs
  {
    public extern uint Start { [MethodImpl] get; }

    public extern uint OldLength { [MethodImpl] get; }

    public extern string NewText { [MethodImpl] get; }
  }
}
