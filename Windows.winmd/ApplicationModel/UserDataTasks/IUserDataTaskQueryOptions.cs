// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2510235629, 37018, 19760, 140, 27, 51, 29, 143, 230, 103, 226)]
  [ExclusiveTo(typeof (UserDataTaskQueryOptions))]
  internal interface IUserDataTaskQueryOptions
  {
    UserDataTaskQuerySortProperty SortProperty { get; set; }

    UserDataTaskQueryKind Kind { get; set; }
  }
}
