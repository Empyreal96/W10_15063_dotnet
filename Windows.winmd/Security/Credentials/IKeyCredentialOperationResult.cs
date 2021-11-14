// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredentialOperationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyCredentialOperationResult))]
  [Guid(4114056897, 21089, 19677, 151, 109, 204, 144, 154, 199, 22, 32)]
  internal interface IKeyCredentialOperationResult
  {
    IBuffer Result { get; }

    KeyCredentialStatus Status { get; }
  }
}
