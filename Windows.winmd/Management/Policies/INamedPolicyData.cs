// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.INamedPolicyData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Management.Policies
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(953987480, 38316, 16503, 166, 67, 128, 120, 202, 226, 100, 0)]
  [ExclusiveTo(typeof (NamedPolicyData))]
  internal interface INamedPolicyData
  {
    string Area { get; }

    string Name { get; }

    NamedPolicyKind Kind { get; }

    bool IsManaged { get; }

    bool IsUserPolicy { get; }

    User User { get; }

    bool GetBoolean();

    IBuffer GetBinary();

    int GetInt32();

    long GetInt64();

    string GetString();

    event TypedEventHandler<NamedPolicyData, object> Changed;
  }
}
