// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskRegenerationProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ExclusiveTo(typeof (UserDataTaskRegenerationProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2460680199, 2318, 18180, 187, 92, 132, 252, 11, 13, 156, 49)]
  internal interface IUserDataTaskRegenerationProperties
  {
    UserDataTaskRegenerationUnit Unit { get; set; }

    IReference<int> Occurrences { get; set; }

    IReference<DateTime> Until { get; set; }

    int Interval { get; set; }
  }
}
