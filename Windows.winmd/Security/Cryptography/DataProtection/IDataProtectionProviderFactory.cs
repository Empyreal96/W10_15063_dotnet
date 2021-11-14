// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.DataProtection.IDataProtectionProviderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.DataProtection
{
  [Guid(2918399404, 18738, 19679, 172, 65, 114, 20, 51, 53, 20, 202)]
  [ExclusiveTo(typeof (DataProtectionProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataProtectionProviderFactory
  {
    DataProtectionProvider CreateOverloadExplicit(string protectionDescriptor);
  }
}
