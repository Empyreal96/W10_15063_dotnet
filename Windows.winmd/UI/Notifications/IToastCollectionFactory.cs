// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastCollectionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastCollection))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(374199255, 29636, 17655, 180, 255, 251, 109, 75, 241, 244, 198)]
  internal interface IToastCollectionFactory
  {
    ToastCollection CreateInstance(
      string collectionId,
      string displayName,
      string launchArgs,
      Uri iconUri);
  }
}
