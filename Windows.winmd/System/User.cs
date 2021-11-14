// Decompiled with JetBrains decompiler
// Type: Windows.System.User
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class User : IUser
  {
    public extern string NonRoamableId { [MethodImpl] get; }

    public extern UserAuthenticationStatus AuthenticationStatus { [MethodImpl] get; }

    public extern UserType Type { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<object> GetPropertyAsync(string value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IPropertySet> GetPropertiesAsync(
      IVectorView<string> values);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamReference> GetPictureAsync(
      UserPictureSize desiredSize);

    [MethodImpl]
    public static extern UserWatcher CreateWatcher();

    [Overload("FindAllAsync")]
    [RemoteAsync]
    [DefaultOverload]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<User>> FindAllAsync();

    [RemoteAsync]
    [Overload("FindAllAsyncByType")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<User>> FindAllAsync(
      UserType type);

    [Overload("FindAllAsyncByTypeAndStatus")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<User>> FindAllAsync(
      UserType type,
      UserAuthenticationStatus status);

    [MethodImpl]
    public static extern User GetFromId(string nonRoamableId);
  }
}
