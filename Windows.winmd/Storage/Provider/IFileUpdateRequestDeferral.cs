// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.IFileUpdateRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [Guid(4291746603, 35550, 17573, 187, 0, 22, 76, 78, 114, 241, 58)]
  [ExclusiveTo(typeof (FileUpdateRequestDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFileUpdateRequestDeferral
  {
    void Complete();
  }
}
