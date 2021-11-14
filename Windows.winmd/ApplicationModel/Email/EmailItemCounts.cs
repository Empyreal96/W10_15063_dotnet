// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailItemCounts
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailItemCounts : IEmailItemCounts
  {
    public extern uint Flagged { [MethodImpl] get; }

    public extern uint Important { [MethodImpl] get; }

    public extern uint Total { [MethodImpl] get; }

    public extern uint Unread { [MethodImpl] get; }
  }
}
