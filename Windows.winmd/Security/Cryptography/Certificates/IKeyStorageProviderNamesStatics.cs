// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyStorageProviderNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyStorageProviderNames))]
  [Guid(2937613024, 21801, 17922, 189, 148, 10, 171, 145, 149, 123, 92)]
  internal interface IKeyStorageProviderNamesStatics
  {
    string SoftwareKeyStorageProvider { get; }

    string SmartcardKeyStorageProvider { get; }

    string PlatformKeyStorageProvider { get; }
  }
}
