// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.UserProfile.GameServices.Core.GameServicePropertyCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.UserProfile.GameServices.Core
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class GameServicePropertyCollection : IGameServicePropertyCollection
  {
    [MethodImpl]
    [return: HasVariant]
    public extern IAsyncOperation<object> GetPropertyAsync(string propertyName);
  }
}
