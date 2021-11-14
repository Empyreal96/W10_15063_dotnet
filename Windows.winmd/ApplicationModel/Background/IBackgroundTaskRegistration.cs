// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(275074242, 41582, 17343, 140, 18, 31, 180, 13, 191, 191, 160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTaskRegistration
  {
    Guid TaskId { get; }

    string Name { get; }

    event BackgroundTaskProgressEventHandler Progress;

    event BackgroundTaskCompletedEventHandler Completed;

    void Unregister(bool cancelTask);
  }
}
