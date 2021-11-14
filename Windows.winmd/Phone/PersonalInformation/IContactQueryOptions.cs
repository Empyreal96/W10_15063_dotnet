// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ExclusiveTo(typeof (ContactQueryOptions))]
  [Guid(1477225334, 16177, 18113, 154, 80, 66, 74, 83, 218, 202, 227)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IContactQueryOptions
  {
    IVector<string> DesiredFields { get; }

    ContactQueryResultOrdering OrderBy { get; set; }
  }
}
