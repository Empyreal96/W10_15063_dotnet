// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IBufferProtectUnprotectResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (BufferProtectUnprotectResult))]
  [Guid(1201233628, 27884, 20026, 178, 81, 158, 116, 133, 215, 158, 122)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  internal interface IBufferProtectUnprotectResult
  {
    IBuffer Buffer { get; }

    DataProtectionInfo ProtectionInfo { get; }
  }
}
