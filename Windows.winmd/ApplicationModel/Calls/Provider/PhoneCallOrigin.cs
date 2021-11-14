// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Provider.PhoneCallOrigin
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Calls.Provider
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Activatable(65536, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhoneCallOrigin : IPhoneCallOrigin, IPhoneCallOrigin2, IPhoneCallOrigin3
  {
    [MethodImpl]
    public extern PhoneCallOrigin();

    public extern string Category { [MethodImpl] get; [MethodImpl] set; }

    public extern string CategoryDescription { [MethodImpl] get; [MethodImpl] set; }

    public extern string Location { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern StorageFile DisplayPicture { [MethodImpl] get; [MethodImpl] set; }
  }
}
