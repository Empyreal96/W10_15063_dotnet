// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IBinaryId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(1326294321, 21909, 17588, 145, 129, 206, 78, 250, 63, 193, 104)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (BinaryId))]
  internal interface IBinaryId
  {
    byte Id { get; }

    uint Length { get; }
  }
}
