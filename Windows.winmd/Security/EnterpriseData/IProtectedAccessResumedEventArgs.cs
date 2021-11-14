// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectedAccessResumedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (ProtectedAccessResumedEventArgs))]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Guid(2890779225, 23936, 20117, 140, 95, 133, 57, 69, 14, 235, 224)]
  internal interface IProtectedAccessResumedEventArgs
  {
    IVectorView<string> Identities { get; }
  }
}
