// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.SignOutUserOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SignOutUserOperation : IAsyncAction, IAsyncInfo
  {
    public extern AsyncActionCompletedHandler Completed { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void GetResults();

    public extern uint Id { [MethodImpl] get; }

    public extern AsyncStatus Status { [MethodImpl] get; }

    public extern HResult ErrorCode { [MethodImpl] get; }

    [MethodImpl]
    public extern void Cancel();

    [MethodImpl]
    public extern void Close();
  }
}
