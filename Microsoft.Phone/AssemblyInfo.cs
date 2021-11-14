﻿using Microsoft.Devices;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Markup;

[assembly: InternalsVisibleTo("Microsoft.Xna.Framework.Interop, PublicKey=0024000004800000140100000602000000240000525341310008000001000100c7835d93a2bf56c5649c2a0b9af5806803b7a4d0845e70c70f4b57d0d98d308301707d61625955bf0aa34590999324f362aedb9875ec9535a507399cf7dcaf41ab3672a6f2d2de1654fd3bda94c2ac80f7ebf73641c4d57f853a792ba33b442ae010895109171903d1b628caf31d1370fdd8774b3ce58fb2809fbfdb0cfddc7c0fe6ca9ee904c1c001db280b9d583ce3f586a6d7f412104a06a7f183a0c263bb0d9a5984e3c76d2052ad01e0f743ae4b5e19fcc1b2d6c9692de99699b0f7972f4b466f0a53e0ca18de547be55adf43a36564165bfc28de25f8a7b43038b22c07fe211d33cb24ad93fef0de4d67b28236bee129b08b943b1dbf702a6a305a6ab6")]
[assembly: AssemblyTitle("Microsoft.Phone")]
[assembly: AssemblyDescription("Microsoft Phone Core Assembly")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® Silverlight")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("969e33fe-1289-4bc2-863a-c848bb476cc0")]
[assembly: XmlnsPrefix("clr-namespace:System.Windows.Controls;assembly=Microsoft.Phone", "navigation")]
[assembly: XmlnsDefinition("clr-namespace:System.Windows.Controls;assembly=Microsoft.Phone", "System.Windows.Controls")]
[assembly: XmlnsPrefix("clr-namespace:System.Windows.Navigation;assembly=Microsoft.Phone", "uriMapper")]
[assembly: XmlnsDefinition("clr-namespace:System.Windows.Navigation;assembly=Microsoft.Phone", "System.Windows.Navigation")]
[assembly: XmlnsPrefix("clr-namespace:Microsoft.Phone.Controls;assembly=Microsoft.Phone", "phone")]
[assembly: XmlnsDefinition("clr-namespace:Microsoft.Phone.Controls;assembly=Microsoft.Phone", "Microsoft.Phone.Controls")]
[assembly: XmlnsPrefix("clr-namespace:Microsoft.Phone.Shell;assembly=Microsoft.Phone", "shell")]
[assembly: XmlnsDefinition("clr-namespace:Microsoft.Phone.Shell;assembly=Microsoft.Phone", "Microsoft.Phone.Shell")]
[assembly: NeutralResourcesLanguage("en-us")]
[assembly: InternalsVisibleTo("Microsoft.AppFx.UnitTests.Silverlight, PublicKey=0024000004800000940000000602000000240000525341310004000001000100e338f2a3d602838b9188d41698e3e386fb88eb1f754a24d2b0dda5f4d4523dfe5bf40666e0c18e62ffa17a7bf4a89db0713a58a70401a28ce628a89eede3676c0a458ccbd4ccbda13bc095cca3d8c73e14d186f087953fcc77f10689bf57d85eae579e4819c71847d48a7a8a81fa3ec6a81a86cf4a5510767678b555fab5e999")]
[assembly: AssemblyFileVersion("3.0.30701.2350")]
[assembly: InternalsVisibleTo("system.windows, PublicKey=00240000048000009400000006020000002400005253413100040000010001008d56c76f9e8649383049f383c44be0ec204181822a6c31cf5eb7ef486944d032188ea1d3920763712ccb12d75fb77e9811149e6148e5d32fbaab37611c1878ddc19e20ef135d0cb2cff2bfec3d115810c3d9069638fe4be215dbf795861920e5ab6f7db2e2ceef136ac23d5dd2bf031700aec232f6c6b1c785b4305c123b37ab")]
[assembly: InternalsVisibleTo("Microsoft.Xna.Framework.Game, PublicKey=0024000004800000140100000602000000240000525341310008000001000100c7835d93a2bf56c5649c2a0b9af5806803b7a4d0845e70c70f4b57d0d98d308301707d61625955bf0aa34590999324f362aedb9875ec9535a507399cf7dcaf41ab3672a6f2d2de1654fd3bda94c2ac80f7ebf73641c4d57f853a792ba33b442ae010895109171903d1b628caf31d1370fdd8774b3ce58fb2809fbfdb0cfddc7c0fe6ca9ee904c1c001db280b9d583ce3f586a6d7f412104a06a7f183a0c263bb0d9a5984e3c76d2052ad01e0f743ae4b5e19fcc1b2d6c9692de99699b0f7972f4b466f0a53e0ca18de547be55adf43a36564165bfc28de25f8a7b43038b22c07fe211d33cb24ad93fef0de4d67b28236bee129b08b943b1dbf702a6a305a6ab6")]
[assembly: InternalsVisibleTo("Microsoft.Xna.Framework.Input.Touch, PublicKey=0024000004800000140100000602000000240000525341310008000001000100c7835d93a2bf56c5649c2a0b9af5806803b7a4d0845e70c70f4b57d0d98d308301707d61625955bf0aa34590999324f362aedb9875ec9535a507399cf7dcaf41ab3672a6f2d2de1654fd3bda94c2ac80f7ebf73641c4d57f853a792ba33b442ae010895109171903d1b628caf31d1370fdd8774b3ce58fb2809fbfdb0cfddc7c0fe6ca9ee904c1c001db280b9d583ce3f586a6d7f412104a06a7f183a0c263bb0d9a5984e3c76d2052ad01e0f743ae4b5e19fcc1b2d6c9692de99699b0f7972f4b466f0a53e0ca18de547be55adf43a36564165bfc28de25f8a7b43038b22c07fe211d33cb24ad93fef0de4d67b28236bee129b08b943b1dbf702a6a305a6ab6")]
[assembly: InternalsVisibleTo("Microsoft.Devices.Sensors, PublicKey=0024000004800000140100000602000000240000525341310008000001000100cb8f76dae05d352c117a8467ef3260e002108aa9e70956e705f6430f6cbcfe359d02117563400017d1004d68d13fe574a25649580ed1ee225aa4bbc093062da0b168bbea3f5795508fcbd7531374c745ce6327a91ac7243571f2b4e8e4fc248ca1a2f3c873e149b3430b37bd51a6a3adc95f685c91745769130fa10fbfc7b2282f25dffd4ba2c0bd7c8288cde4806c8bdc817d126c7e543610d3476a6317b5d54876a0e3b3ad42b12c5138db2ffb669f1be6314bc9587ac1ace4751d6c5884db048115907c090dbbdf98c65ed4c042c3775acaa7d6042307fae2aafae7128e17658192446c07400d22c5ba43f3a1e7a3e5af81be0e65a5016c5f0c62a3c0deb3")]
[assembly: InternalsVisibleTo("System.Device, PublicKey=0024000004800000140100000602000000240000525341310008000001000100cb8f76dae05d352c117a8467ef3260e002108aa9e70956e705f6430f6cbcfe359d02117563400017d1004d68d13fe574a25649580ed1ee225aa4bbc093062da0b168bbea3f5795508fcbd7531374c745ce6327a91ac7243571f2b4e8e4fc248ca1a2f3c873e149b3430b37bd51a6a3adc95f685c91745769130fa10fbfc7b2282f25dffd4ba2c0bd7c8288cde4806c8bdc817d126c7e543610d3476a6317b5d54876a0e3b3ad42b12c5138db2ffb669f1be6314bc9587ac1ace4751d6c5884db048115907c090dbbdf98c65ed4c042c3775acaa7d6042307fae2aafae7128e17658192446c07400d22c5ba43f3a1e7a3e5af81be0e65a5016c5f0c62a3c0deb3")]
[assembly: Extension]
[assembly: InternalsVisibleTo("Microsoft.Xna.Framework.GamerServices, PublicKey=0024000004800000140100000602000000240000525341310008000001000100c7835d93a2bf56c5649c2a0b9af5806803b7a4d0845e70c70f4b57d0d98d308301707d61625955bf0aa34590999324f362aedb9875ec9535a507399cf7dcaf41ab3672a6f2d2de1654fd3bda94c2ac80f7ebf73641c4d57f853a792ba33b442ae010895109171903d1b628caf31d1370fdd8774b3ce58fb2809fbfdb0cfddc7c0fe6ca9ee904c1c001db280b9d583ce3f586a6d7f412104a06a7f183a0c263bb0d9a5984e3c76d2052ad01e0f743ae4b5e19fcc1b2d6c9692de99699b0f7972f4b466f0a53e0ca18de547be55adf43a36564165bfc28de25f8a7b43038b22c07fe211d33cb24ad93fef0de4d67b28236bee129b08b943b1dbf702a6a305a6ab6")]
[assembly: InternalsVisibleTo("NavigationUnitTests, PublicKey=0024000004800000140100000602000000240000525341310008000001000100cb8f76dae05d352c117a8467ef3260e002108aa9e70956e705f6430f6cbcfe359d02117563400017d1004d68d13fe574a25649580ed1ee225aa4bbc093062da0b168bbea3f5795508fcbd7531374c745ce6327a91ac7243571f2b4e8e4fc248ca1a2f3c873e149b3430b37bd51a6a3adc95f685c91745769130fa10fbfc7b2282f25dffd4ba2c0bd7c8288cde4806c8bdc817d126c7e543610d3476a6317b5d54876a0e3b3ad42b12c5138db2ffb669f1be6314bc9587ac1ace4751d6c5884db048115907c090dbbdf98c65ed4c042c3775acaa7d6042307fae2aafae7128e17658192446c07400d22c5ba43f3a1e7a3e5af81be0e65a5016c5f0c62a3c0deb3")]
[assembly: InternalsVisibleTo("Microsoft.Phone.UserData.TestContacts, PublicKey=0024000004800000140100000602000000240000525341310008000001000100cb8f76dae05d352c117a8467ef3260e002108aa9e70956e705f6430f6cbcfe359d02117563400017d1004d68d13fe574a25649580ed1ee225aa4bbc093062da0b168bbea3f5795508fcbd7531374c745ce6327a91ac7243571f2b4e8e4fc248ca1a2f3c873e149b3430b37bd51a6a3adc95f685c91745769130fa10fbfc7b2282f25dffd4ba2c0bd7c8288cde4806c8bdc817d126c7e543610d3476a6317b5d54876a0e3b3ad42b12c5138db2ffb669f1be6314bc9587ac1ace4751d6c5884db048115907c090dbbdf98c65ed4c042c3775acaa7d6042307fae2aafae7128e17658192446c07400d22c5ba43f3a1e7a3e5af81be0e65a5016c5f0c62a3c0deb3")]
[assembly: InternalsVisibleTo("Microsoft.Phone.Test.AppPlatform.SLM.MessagingLibrary, PublicKey=00240000048000009400000006020000002400005253413100040000010001008d56c76f9e8649383049f383c44be0ec204181822a6c31cf5eb7ef486944d032188ea1d3920763712ccb12d75fb77e9811149e6148e5d32fbaab37611c1878ddc19e20ef135d0cb2cff2bfec3d115810c3d9069638fe4be215dbf795861920e5ab6f7db2e2ceef136ac23d5dd2bf031700aec232f6c6b1c785b4305c123b37ab")]
[assembly: InternalsVisibleTo("Microsoft.Phone.Test.AppPlatform.YTestService, PublicKey=00240000048000009400000006020000002400005253413100040000010001008d56c76f9e8649383049f383c44be0ec204181822a6c31cf5eb7ef486944d032188ea1d3920763712ccb12d75fb77e9811149e6148e5d32fbaab37611c1878ddc19e20ef135d0cb2cff2bfec3d115810c3d9069638fe4be215dbf795861920e5ab6f7db2e2ceef136ac23d5dd2bf031700aec232f6c6b1c785b4305c123b37ab")]
[assembly: InternalsVisibleTo("Microsoft.Phone.TestHelper, PublicKey=0024000004800000140100000602000000240000525341310008000001000100cb8f76dae05d352c117a8467ef3260e002108aa9e70956e705f6430f6cbcfe359d02117563400017d1004d68d13fe574a25649580ed1ee225aa4bbc093062da0b168bbea3f5795508fcbd7531374c745ce6327a91ac7243571f2b4e8e4fc248ca1a2f3c873e149b3430b37bd51a6a3adc95f685c91745769130fa10fbfc7b2282f25dffd4ba2c0bd7c8288cde4806c8bdc817d126c7e543610d3476a6317b5d54876a0e3b3ad42b12c5138db2ffb669f1be6314bc9587ac1ace4751d6c5884db048115907c090dbbdf98c65ed4c042c3775acaa7d6042307fae2aafae7128e17658192446c07400d22c5ba43f3a1e7a3e5af81be0e65a5016c5f0c62a3c0deb3")]
[assembly: InternalsVisibleTo("Microsoft.Phone.Controls.Navigation, PublicKey=0024000004800000140100000602000000240000525341310008000001000100cb8f76dae05d352c117a8467ef3260e002108aa9e70956e705f6430f6cbcfe359d02117563400017d1004d68d13fe574a25649580ed1ee225aa4bbc093062da0b168bbea3f5795508fcbd7531374c745ce6327a91ac7243571f2b4e8e4fc248ca1a2f3c873e149b3430b37bd51a6a3adc95f685c91745769130fa10fbfc7b2282f25dffd4ba2c0bd7c8288cde4806c8bdc817d126c7e543610d3476a6317b5d54876a0e3b3ad42b12c5138db2ffb669f1be6314bc9587ac1ace4751d6c5884db048115907c090dbbdf98c65ed4c042c3775acaa7d6042307fae2aafae7128e17658192446c07400d22c5ba43f3a1e7a3e5af81be0e65a5016c5f0c62a3c0deb3")]
[assembly: InternalsVisibleTo("ApplicationBarUnitTesting, PublicKey=00240000048000009400000006020000002400005253413100040000010001000fc5993e0f511ad5e16e8b226553493e09067afc41039f70daeb94a968d664f40e69a46b617d15d3d5328be7dbedd059eb98495a3b03cb4ea4ba127444671c3c84cbc1fdc393d7e10b5ee3f31f5a29f005e5eed7e3c9c8af74f413f0004f0c2cabb22f9dd4f75a6f599784e1bab70985ef8174ca6c684278be82ce055a03ebaf")]
[assembly: InternalsVisibleTo("Microsoft.MobileDevices.Test.AppPlatform.CoreX.AppBarTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001000fc5993e0f511ad5e16e8b226553493e09067afc41039f70daeb94a968d664f40e69a46b617d15d3d5328be7dbedd059eb98495a3b03cb4ea4ba127444671c3c84cbc1fdc393d7e10b5ee3f31f5a29f005e5eed7e3c9c8af74f413f0004f0c2cabb22f9dd4f75a6f599784e1bab70985ef8174ca6c684278be82ce055a03ebaf")]
[assembly: InternalsVisibleTo("UT_Tasks, PublicKey=0024000004800000940000000602000000240000525341310004000001000100d93a83413aa6d0e50d95a494c6580d10e720dac4c23dc3cdadc253c32775689cf6137dcf17989865674488aa9a7961c8d14a13336d490d8284d6d288557344e8244378890608eb3fc80a8b11290f3cbab0f0d504ee350464e0781da1e3d18df27831521414fcc8c983e37729e38fe6a61b4a36c22b1b832d03d141f086865eac")]
[assembly: InternalsVisibleTo("Microsoft.MobileDevices.Tests.WebApps.IExplore.PanZoomContainerWrapper, PublicKey=0024000004800000940000000602000000240000525341310004000001000100d93a83413aa6d0e50d95a494c6580d10e720dac4c23dc3cdadc253c32775689cf6137dcf17989865674488aa9a7961c8d14a13336d490d8284d6d288557344e8244378890608eb3fc80a8b11290f3cbab0f0d504ee350464e0781da1e3d18df27831521414fcc8c983e37729e38fe6a61b4a36c22b1b832d03d141f086865eac")]
[assembly: InternalsVisibleTo("System.Runtime.Serialization, PublicKey=00240000048000009400000006020000002400005253413100040000010001008d56c76f9e8649383049f383c44be0ec204181822a6c31cf5eb7ef486944d032188ea1d3920763712ccb12d75fb77e9811149e6148e5d32fbaab37611c1878ddc19e20ef135d0cb2cff2bfec3d115810c3d9069638fe4be215dbf795861920e5ab6f7db2e2ceef136ac23d5dd2bf031700aec232f6c6b1c785b4305c123b37ab")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Justification = "These namespaces are being used for WPF compat.", Scope = "namespace", Target = "System.Windows.Controls")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Justification = "Automation peers are shipped in this namespace.", Scope = "namespace", Target = "System.Windows.Automation.Peers")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Justification = "This EventHandler type is being used for WPF compat.", Scope = "type", Target = "System.Windows.Navigation.NavigatedEventHandler")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Justification = "This EventHandler type is being used for WPF compat.", Scope = "type", Target = "System.Windows.Navigation.NavigatingCancelEventHandler")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Justification = "This EventHandler type is being used for WPF compat.", Scope = "type", Target = "System.Windows.Navigation.NavigationFailedEventHandler")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Justification = "This EventHandler type is being used for WPF compat.", Scope = "type", Target = "System.Windows.Navigation.NavigationStoppedEventHandler")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Justification = "This EventHandler type is being used for WPF compat.", Scope = "type", Target = "System.Windows.Navigation.FragmentNavigationEventHandler")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", Justification = "This is a common acronym used throughout the web.", MessageId = "URIs", Scope = "resource", Target = "System.Windows.Navigation.Resource.resources")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "URIs")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion("8.0.0.0")]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: TypeForwardedTo(typeof (FlashMode))]
[assembly: TypeForwardedTo(typeof (CameraType))]
[assembly: TypeForwardedTo(typeof (CameraVideoBrushExtensions))]
[assembly: TypeForwardedTo(typeof (CameraOperationCompletedEventArgs))]
[assembly: TypeForwardedTo(typeof (Camera))]
[assembly: TypeForwardedTo(typeof (YCbCrPixelLayout))]
[assembly: TypeForwardedTo(typeof (ContentReadyEventArgs))]
[assembly: TypeForwardedTo(typeof (PhotoCamera))]
[assembly: TypeForwardedTo(typeof (Stopwatch))]
