// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletItemPropertyType
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.Wallet
{
  internal enum WalletItemPropertyType
  {
    Unknown = 0,
    Id = 1,
    Flags = 2,
    Notes = 10, // 0x0000000A
    Nickname = 11, // 0x0000000B
    Terms = 12, // 0x0000000C
    BrandColor = 13, // 0x0000000D
    Issuer = 100, // 0x00000064
    IssuerUri = 101, // 0x00000065
    IsNfcEnabled = 150, // 0x00000096
    UserAlwaysWantsNfcActive = 151, // 0x00000097
    UserImage = 200, // 0x000000C8
    BrandImageSmall = 201, // 0x000000C9
    BrandImageMedium = 202, // 0x000000CA
    BrandImageLarge = 203, // 0x000000CB
    BarcodeImage = 204, // 0x000000CC
    ExpirationDate = 300, // 0x0000012C
    StartDate = 301, // 0x0000012D
    MemberSince = 302, // 0x0000012E
    DataValidAsOf = 303, // 0x0000012F
    LastUsed = 304, // 0x00000130
    LastRefresh = 305, // 0x00000131
    CtpPaymentInstrumentId = 350, // 0x0000015E
    CtpOldPaymentInstrumentId = 351, // 0x0000015F
    CtpPaymentInstrumentUniqueId = 352, // 0x00000160
    CardName = 400, // 0x00000190
    CardAccountNumber = 401, // 0x00000191
    CardPaymentNetwork = 402, // 0x00000192
    CardholderName = 404, // 0x00000194
    CardOtherPaymentNetworks = 405, // 0x00000195
    Balance = 407, // 0x00000197
    AvailableBalance = 408, // 0x00000198
    CreditLimit = 409, // 0x00000199
    AvailableCredit = 410, // 0x0000019A
    PaymentCardType = 411, // 0x0000019B
    FirstName = 412, // 0x0000019C
    LastName = 413, // 0x0000019D
    UserEmail = 414, // 0x0000019E
    CouponTitle = 500, // 0x000001F4
    CouponCode = 501, // 0x000001F5
    CouponDetails = 502, // 0x000001F6
    CouponUrl = 503, // 0x000001F7
    CouponIsUsed = 504, // 0x000001F8
    CouponMerchant = 505, // 0x000001F9
    CouponId = 506, // 0x000001FA
    CouponProvider = 507, // 0x000001FB
    BusinessPhone = 1000, // 0x000003E8
    BusinessAddressStreet = 1010, // 0x000003F2
    BusinessAddressCity = 1011, // 0x000003F3
    BusinessAddressState = 1012, // 0x000003F4
    BusinessAddressZip = 1013, // 0x000003F5
    BusinessAddressCountry = 1014, // 0x000003F6
    Business2AddressStreet = 1110, // 0x00000456
    Business2AddressCity = 1111, // 0x00000457
    Business2AddressState = 1112, // 0x00000458
    Business2AddressZip = 1113, // 0x00000459
    Business2AddressCountry = 1114, // 0x0000045A
    BillingPhone = 1200, // 0x000004B0
    BillingAddressStreet = 1210, // 0x000004BA
    BillingAddressCity = 1211, // 0x000004BB
    BillingAddressState = 1212, // 0x000004BC
    BillingAddressZip = 1213, // 0x000004BD
    BillingAddressCountry = 1214, // 0x000004BE
    PaymentsAddressStreet = 1310, // 0x0000051E
    PaymentsAddressCity = 1311, // 0x0000051F
    PaymentsAddressState = 1312, // 0x00000520
    PaymentsAddressZip = 1313, // 0x00000521
    PaymentsAddressCountry = 1314, // 0x00000522
    HeadquartersAddressStreet = 1410, // 0x00000582
    HeadquartersAddressCity = 1411, // 0x00000583
    HeadquartersAddressState = 1412, // 0x00000584
    HeadquartersAddressZip = 1413, // 0x00000585
    HeadquartersAddressCountry = 1414, // 0x00000586
    CustomerServicePhone = 1900, // 0x0000076C
    CustomerService2Phone = 1901, // 0x0000076D
    ReportLostCardPhone = 1902, // 0x0000076E
    ReportLostCard2Phone = 1903, // 0x0000076F
    FaxPhone = 1904, // 0x00000770
    OtherPhone = 1905, // 0x00000771
    NFCState = 2001, // 0x000007D1
    NFCLastError = 2002, // 0x000007D2
    NFCLastErrorOperation = 2003, // 0x000007D3
    NFCAppletId = 2004, // 0x000007D4
    NFCServiceId = 2005, // 0x000007D5
    NFCUiccId = 2006, // 0x000007D6
    NFCActivationType = 2007, // 0x000007D7
    AppProductId = 3000, // 0x00000BB8
    AppItemId = 3001, // 0x00000BB9
    AppNavigationUri = 3002, // 0x00000BBA
    AppLinkState = 3003, // 0x00000BBB
    AppStatusMessage = 3004, // 0x00000BBC
    AppStatusMessageUri = 3005, // 0x00000BBD
    AgentReturnData = 3006, // 0x00000BBE
    AgentReturnTransactionAmount = 3007, // 0x00000BBF
    MoreTransactionsNavigationUri = 3008, // 0x00000BC0
    ActivationRequiresAuth = 3010, // 0x00000BC2
    ActivationAuthResult = 3011, // 0x00000BC3
    Root_MobileOperator_WalletItemId = 10000, // 0x00002710
    Notification_WalletItemId = 20001, // 0x00004E21
    Notification_Date = 20002, // 0x00004E22
    TransactionWalletItemId = 30000, // 0x00007530
    TransactionAmount = 30001, // 0x00007531
    TransactionDescription = 30002, // 0x00007532
    TransactionLocation = 30003, // 0x00007533
    TransactionDate = 30004, // 0x00007534
    TransactionTimeIsValid = 30005, // 0x00007535
  }
}
