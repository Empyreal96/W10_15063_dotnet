// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Provider.IPhoneCallOrigin3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Calls.Provider
{
  [ExclusiveTo(typeof (PhoneCallOrigin))]
  [Guid(1228083124, 53671, 17314, 174, 238, 192, 123, 109, 186, 240, 104)]
  [ContractVersion(typeof (CallsPhoneContract), 196608)]
  internal interface IPhoneCallOrigin3 : IPhoneCallOrigin2, IPhoneCallOrigin
  {
    StorageFile DisplayPicture { get; set; }
  }
}
