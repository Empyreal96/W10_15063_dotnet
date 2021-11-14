// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.NamedPolicyKind
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Policies
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum NamedPolicyKind
  {
    Invalid,
    Binary,
    Boolean,
    Int32,
    Int64,
    String,
  }
}
