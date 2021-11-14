// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  [Guid(485530526, 39266, 18742, 128, 255, 175, 200, 232, 174, 92, 140)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IActivatedEventArgsWithUser : IActivatedEventArgs
  {
    User User { get; }
  }
}
