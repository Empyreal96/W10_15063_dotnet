// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.ILocalCategoriesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [ExclusiveTo(typeof (LocalCategories))]
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 65536)]
  [Guid(4103313909, 33377, 17185, 153, 116, 239, 146, 212, 154, 141, 202)]
  internal interface ILocalCategoriesStatics
  {
    string BankAndCreditUnions { get; }

    string EatDrink { get; }

    string Hospitals { get; }

    string HotelsAndMotels { get; }

    string All { get; }

    string Parking { get; }

    string SeeDo { get; }

    string Shop { get; }
  }
}
