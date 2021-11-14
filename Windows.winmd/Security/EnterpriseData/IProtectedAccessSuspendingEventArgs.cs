// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectedAccessSuspendingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Guid(1973523424, 41796, 17055, 185, 117, 4, 252, 31, 136, 193, 133)]
  [ExclusiveTo(typeof (ProtectedAccessSuspendingEventArgs))]
  internal interface IProtectedAccessSuspendingEventArgs
  {
    IVectorView<string> Identities { get; }

    DateTime Deadline { get; }

    Deferral GetDeferral();
  }
}
