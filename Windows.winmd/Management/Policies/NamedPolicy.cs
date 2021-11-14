// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.NamedPolicy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Management.Policies
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (INamedPolicyStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public static class NamedPolicy
  {
    [MethodImpl]
    public static extern NamedPolicyData GetPolicyFromPath(string area, string name);

    [MethodImpl]
    public static extern NamedPolicyData GetPolicyFromPathForUser(
      User user,
      string area,
      string name);
  }
}
