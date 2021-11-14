// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (User))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(358527547, 9258, 17888, 162, 233, 49, 113, 252, 106, 127, 221)]
  internal interface IUserStatics
  {
    UserWatcher CreateWatcher();

    [DefaultOverload]
    [Overload("FindAllAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<User>> FindAllAsync();

    [Overload("FindAllAsyncByType")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<User>> FindAllAsync(UserType type);

    [RemoteAsync]
    [Overload("FindAllAsyncByTypeAndStatus")]
    IAsyncOperation<IVectorView<User>> FindAllAsync(
      UserType type,
      UserAuthenticationStatus status);

    User GetFromId(string nonRoamableId);
  }
}
