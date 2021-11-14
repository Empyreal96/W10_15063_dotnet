// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskBuilder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskBuilder))]
  [Guid(55661838, 15972, 17778, 169, 58, 132, 7, 90, 55, 201, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundTaskBuilder
  {
    string TaskEntryPoint { set; get; }

    void SetTrigger(IBackgroundTrigger trigger);

    void AddCondition(IBackgroundCondition condition);

    string Name { set; get; }

    BackgroundTaskRegistration Register();
  }
}
