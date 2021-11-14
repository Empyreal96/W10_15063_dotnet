// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.Enterprise
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Management.Deployment
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class Enterprise : IEnterprise
  {
    public extern Guid Id { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern int WorkplaceId { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime EnrollmentValidFrom { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime EnrollmentValidTo { [MethodImpl] get; }

    public extern EnterpriseStatus Status { [MethodImpl] get; }
  }
}
