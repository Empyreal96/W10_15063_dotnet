// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserPicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UserPicker))]
  [Guid(2102689800, 61923, 19052, 141, 220, 169, 187, 15, 72, 138, 237)]
  internal interface IUserPicker
  {
    bool AllowGuestAccounts { get; set; }

    User SuggestedSelectedUser { get; set; }

    IAsyncOperation<User> PickSingleUserAsync();
  }
}
