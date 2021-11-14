// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IEnterpriseKeyCredentialRegistrationManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EnterpriseKeyCredentialRegistrationManager : 
    IEnterpriseKeyCredentialRegistrationManager
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EnterpriseKeyCredentialRegistrationInfo>> GetRegistrationsAsync();

    public static extern EnterpriseKeyCredentialRegistrationManager Current { [MethodImpl] get; }
  }
}
