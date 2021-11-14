// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.UserProfile.GameServices.Core.IGameServicePropertyCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.UserProfile.GameServices.Core
{
  [Guid(132480968, 57019, 17929, 156, 200, 82, 157, 22, 188, 43, 217)]
  [ExclusiveTo(typeof (GameServicePropertyCollection))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IGameServicePropertyCollection
  {
    [return: HasVariant]
    IAsyncOperation<object> GetPropertyAsync(string propertyName);
  }
}
