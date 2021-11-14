// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectedContentRevokedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [Guid(1667786785, 22713, 18414, 147, 217, 240, 247, 65, 207, 67, 240)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [ExclusiveTo(typeof (ProtectedContentRevokedEventArgs))]
  internal interface IProtectedContentRevokedEventArgs
  {
    IVectorView<string> Identities { get; }
  }
}
