// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactBindings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [Static(typeof (IContactBindingsStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.Both)]
  public static class ContactBindings
  {
    [MethodImpl]
    public static extern IAsyncOperation<ContactBindingManager> GetAppContactBindingManagerAsync();
  }
}
