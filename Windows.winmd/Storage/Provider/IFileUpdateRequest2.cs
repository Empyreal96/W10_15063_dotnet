// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.IFileUpdateRequest2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ExclusiveTo(typeof (FileUpdateRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2185774664, 48574, 17531, 162, 238, 122, 254, 106, 3, 42, 148)]
  internal interface IFileUpdateRequest2 : IFileUpdateRequest
  {
    string UserInputNeededMessage { get; set; }
  }
}
