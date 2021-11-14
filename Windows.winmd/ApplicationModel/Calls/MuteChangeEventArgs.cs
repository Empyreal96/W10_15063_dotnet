// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.MuteChangeEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class MuteChangeEventArgs : IMuteChangeEventArgs
  {
    public extern bool Muted { [MethodImpl] get; }
  }
}
