// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.CommunicationBlocking.ICommunicationBlockingAppManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.CommunicationBlocking
{
  [ExclusiveTo(typeof (CommunicationBlockingAppManager))]
  [ContractVersion(typeof (CommunicationBlockingContract), 65536)]
  [Guid(2010863852, 5286, 19370, 148, 42, 106, 103, 61, 153, 155, 242)]
  internal interface ICommunicationBlockingAppManagerStatics
  {
    bool IsCurrentAppActiveBlockingApp { get; }

    void ShowCommunicationBlockingSettingsUI();
  }
}
