// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.NamedPolicyData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Management.Policies
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class NamedPolicyData : INamedPolicyData
  {
    public extern string Area { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern NamedPolicyKind Kind { [MethodImpl] get; }

    public extern bool IsManaged { [MethodImpl] get; }

    public extern bool IsUserPolicy { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern bool GetBoolean();

    [MethodImpl]
    public extern IBuffer GetBinary();

    [MethodImpl]
    public extern int GetInt32();

    [MethodImpl]
    public extern long GetInt64();

    [MethodImpl]
    public extern string GetString();

    public extern event TypedEventHandler<NamedPolicyData, object> Changed;
  }
}
