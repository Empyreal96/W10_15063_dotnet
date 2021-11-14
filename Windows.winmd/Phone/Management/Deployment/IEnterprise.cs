// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.IEnterprise
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Management.Deployment
{
  [WebHostHidden]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(2522427277, 34156, 17446, 169, 71, 176, 99, 7, 113, 128, 120)]
  [ExclusiveTo(typeof (Enterprise))]
  internal interface IEnterprise
  {
    Guid Id { get; }

    string Name { get; }

    int WorkplaceId { get; }

    global::Windows.Foundation.DateTime EnrollmentValidFrom { get; }

    global::Windows.Foundation.DateTime EnrollmentValidTo { get; }

    EnterpriseStatus Status { get; }
  }
}
