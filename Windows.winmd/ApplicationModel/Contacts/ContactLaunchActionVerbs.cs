// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IContactLaunchActionVerbsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ContactLaunchActionVerbs
  {
    public static extern string Call { [MethodImpl] get; }

    public static extern string Message { [MethodImpl] get; }

    public static extern string Map { [MethodImpl] get; }

    public static extern string Post { [MethodImpl] get; }

    public static extern string VideoCall { [MethodImpl] get; }
  }
}
