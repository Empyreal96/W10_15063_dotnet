﻿// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EnterpriseKeyCredentialRegistrationInfo : 
    IEnterpriseKeyCredentialRegistrationInfo
  {
    public extern string TenantId { [MethodImpl] get; }

    public extern string TenantName { [MethodImpl] get; }

    public extern string Subject { [MethodImpl] get; }

    public extern string KeyId { [MethodImpl] get; }

    public extern string KeyName { [MethodImpl] get; }
  }
}
