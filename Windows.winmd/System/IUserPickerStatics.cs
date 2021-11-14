// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserPickerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (UserPicker))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3727855836, 32371, 19958, 161, 174, 77, 126, 202, 130, 180, 13)]
  internal interface IUserPickerStatics
  {
    bool IsSupported();
  }
}
