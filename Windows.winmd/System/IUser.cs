// Decompiled with JetBrains decompiler
// Type: Windows.System.IUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System
{
  [ExclusiveTo(typeof (User))]
  [Guid(3751421638, 59206, 19405, 181, 212, 18, 1, 3, 196, 32, 155)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUser
  {
    string NonRoamableId { get; }

    UserAuthenticationStatus AuthenticationStatus { get; }

    UserType Type { get; }

    [RemoteAsync]
    IAsyncOperation<object> GetPropertyAsync(string value);

    [RemoteAsync]
    IAsyncOperation<IPropertySet> GetPropertiesAsync(
      IVectorView<string> values);

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamReference> GetPictureAsync(
      UserPictureSize desiredSize);
  }
}
