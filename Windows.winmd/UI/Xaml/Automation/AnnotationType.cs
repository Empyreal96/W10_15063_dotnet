// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AnnotationType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum AnnotationType
  {
    Unknown = 60000, // 0x0000EA60
    SpellingError = 60001, // 0x0000EA61
    GrammarError = 60002, // 0x0000EA62
    Comment = 60003, // 0x0000EA63
    FormulaError = 60004, // 0x0000EA64
    TrackChanges = 60005, // 0x0000EA65
    Header = 60006, // 0x0000EA66
    Footer = 60007, // 0x0000EA67
    Highlighted = 60008, // 0x0000EA68
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Endnote = 60009, // 0x0000EA69
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Footnote = 60010, // 0x0000EA6A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] InsertionChange = 60011, // 0x0000EA6B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DeletionChange = 60012, // 0x0000EA6C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] MoveChange = 60013, // 0x0000EA6D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] FormatChange = 60014, // 0x0000EA6E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] UnsyncedChange = 60015, // 0x0000EA6F
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] EditingLockedChange = 60016, // 0x0000EA70
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ExternalChange = 60017, // 0x0000EA71
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ConflictingChange = 60018, // 0x0000EA72
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Author = 60019, // 0x0000EA73
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AdvancedProofingIssue = 60020, // 0x0000EA74
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DataValidationError = 60021, // 0x0000EA75
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] CircularReferenceError = 60022, // 0x0000EA76
  }
}
