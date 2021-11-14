// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.PasswordVault
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PasswordVault : IPasswordVault
  {
    [MethodImpl]
    public extern PasswordVault();

    [MethodImpl]
    public extern void Add(PasswordCredential credential);

    [MethodImpl]
    public extern void Remove(PasswordCredential credential);

    [MethodImpl]
    public extern PasswordCredential Retrieve(string resource, string userName);

    [MethodImpl]
    public extern IVectorView<PasswordCredential> FindAllByResource(
      string resource);

    [MethodImpl]
    public extern IVectorView<PasswordCredential> FindAllByUserName(
      string userName);

    [MethodImpl]
    public extern IVectorView<PasswordCredential> RetrieveAll();
  }
}
