// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.CallRejectEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  public sealed class CallRejectEventArgs : ICallRejectEventArgs
  {
    public extern VoipPhoneCallRejectReason RejectReason { [MethodImpl] get; }
  }
}
