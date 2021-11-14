// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ITargetApplicationChosenEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (TargetApplicationChosenEventArgs))]
  [Guid(3396319404, 10631, 20195, 156, 84, 216, 175, 188, 184, 108, 29)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITargetApplicationChosenEventArgs
  {
    string ApplicationName { get; }
  }
}
