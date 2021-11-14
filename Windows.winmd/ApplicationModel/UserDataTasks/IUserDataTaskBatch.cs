// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskBatch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Guid(942515710, 8373, 17180, 143, 66, 165, 210, 146, 236, 147, 12)]
  [ExclusiveTo(typeof (UserDataTaskBatch))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskBatch
  {
    IVectorView<UserDataTask> Tasks { get; }
  }
}
