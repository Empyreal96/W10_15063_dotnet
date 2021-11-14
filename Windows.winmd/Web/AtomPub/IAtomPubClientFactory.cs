// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IAtomPubClientFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Web.AtomPub
{
  [ExclusiveTo(typeof (AtomPubClient))]
  [Guid(1238716434, 22475, 19422, 171, 159, 38, 16, 177, 114, 119, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAtomPubClientFactory
  {
    AtomPubClient CreateAtomPubClientWithCredentials(
      PasswordCredential serverCredential);
  }
}
