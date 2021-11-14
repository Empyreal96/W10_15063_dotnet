// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.INamedPolicyStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Management.Policies
{
  [ExclusiveTo(typeof (NamedPolicy))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2138651623, 30404, 16472, 140, 173, 103, 102, 44, 208, 95, 13)]
  internal interface INamedPolicyStatics
  {
    NamedPolicyData GetPolicyFromPath(string area, string name);

    NamedPolicyData GetPolicyFromPathForUser(User user, string area, string name);
  }
}
