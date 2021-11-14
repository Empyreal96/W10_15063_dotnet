// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ILockScreenActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(1017608550, 24840, 19009, 130, 32, 238, 125, 19, 60, 133, 50)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ILockScreenActivatedEventArgs : IActivatedEventArgs
  {
    object Info { get; }
  }
}
