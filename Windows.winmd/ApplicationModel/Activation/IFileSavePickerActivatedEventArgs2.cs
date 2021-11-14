// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1802763795, 11506, 19784, 140, 188, 175, 103, 210, 63, 28, 231)]
  public interface IFileSavePickerActivatedEventArgs2
  {
    string CallerPackageFamilyName { get; }

    string EnterpriseId { get; }
  }
}
