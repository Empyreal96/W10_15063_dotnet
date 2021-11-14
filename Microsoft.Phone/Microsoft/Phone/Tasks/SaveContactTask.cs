// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.SaveContactTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Tasks
{
  public sealed class SaveContactTask : ChooserBase<SaveContactResult>
  {
    private const string ParameterCompany = "Company";
    private const string ParameterNameFirst = "FirstName";
    private const string ParameterHomeAddressCity = "HomeAddressCity";
    private const string ParameterHomeAddressCountry = "HomeAddressCountry";
    private const string ParameterHomeAddressState = "HomeAddressState";
    private const string ParameterHomeAddressStreet = "HomeAddressStreet";
    private const string ParameterHomeAddressZipCode = "HomeAddressZipCode";
    private const string ParameterHomePhone = "HomePhone";
    private const string ParameterJobTitle = "JobTitle";
    private const string ParameterNameLast = "LastName";
    private const string ParameterNameMiddle = "MiddleName";
    private const string ParameterMobilePhone = "MobilePhone";
    private const string ParameterNickname = "Nickname";
    private const string ParameterNotes = "Notes";
    private const string ParameterOtherEmail = "OtherEmail";
    private const string ParameterPersonalEmail = "PersonalEmail";
    private const string ParameterNameSuffix = "Suffix";
    private const string ParameterNameTitle = "Title";
    private const string ParameterWebsite = "Website";
    private const string ParameterWorkAddressCity = "WorkAddressCity";
    private const string ParameterWorkAddressCountry = "WorkAddressCountry";
    private const string ParameterWorkAddressState = "WorkAddressState";
    private const string ParameterWorkAddressStreet = "WorkAddressStreet";
    private const string ParameterWorkAddressZipCode = "WorkAddressZipCode";
    private const string ParameterWorkEmail = "WorkEmail";
    private const string ParameterWorkPhone = "WorkPhone";

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public string Nickname { get; set; }

    public string Suffix { get; set; }

    public string Company { get; set; }

    public string Title { get; set; }

    public string MobilePhone { get; set; }

    public string HomePhone { get; set; }

    public string WorkPhone { get; set; }

    public string PersonalEmail { get; set; }

    public string WorkEmail { get; set; }

    public string OtherEmail { get; set; }

    public string HomeAddressStreet { get; set; }

    public string HomeAddressCity { get; set; }

    public string HomeAddressState { get; set; }

    public string HomeAddressZipCode { get; set; }

    public string HomeAddressCountry { get; set; }

    public string WorkAddressStreet { get; set; }

    public string WorkAddressCity { get; set; }

    public string WorkAddressState { get; set; }

    public string WorkAddressZipCode { get; set; }

    public string WorkAddressCountry { get; set; }

    public string Website { get; set; }

    public string Notes { get; set; }

    public string JobTitle { get; set; }

    public override void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      this.Show(this.BuildUri(), this.BuildParameterPropertyBag());
    }

    internal override Uri BuildUri() => new Uri("ms-people:savecontacttask?", UriKind.Absolute);

    internal override ParameterPropertyBag BuildParameterPropertyBag()
    {
      ParameterPropertyBag parameterPropertyBag = new ParameterPropertyBag();
      if (this.FirstName != null)
        parameterPropertyBag.CreateProperty("FirstName").StringValue = this.FirstName;
      if (this.LastName != null)
        parameterPropertyBag.CreateProperty("LastName").StringValue = this.LastName;
      if (this.MiddleName != null)
        parameterPropertyBag.CreateProperty("MiddleName").StringValue = this.MiddleName;
      if (this.Nickname != null)
        parameterPropertyBag.CreateProperty("Nickname").StringValue = this.Nickname;
      if (this.Suffix != null)
        parameterPropertyBag.CreateProperty("Suffix").StringValue = this.Suffix;
      if (this.Company != null)
        parameterPropertyBag.CreateProperty("Company").StringValue = this.Company;
      if (this.Title != null)
        parameterPropertyBag.CreateProperty("Title").StringValue = this.Title;
      if (this.MobilePhone != null)
        parameterPropertyBag.CreateProperty("MobilePhone").StringValue = this.MobilePhone;
      if (this.HomePhone != null)
        parameterPropertyBag.CreateProperty("HomePhone").StringValue = this.HomePhone;
      if (this.WorkPhone != null)
        parameterPropertyBag.CreateProperty("WorkPhone").StringValue = this.WorkPhone;
      if (this.PersonalEmail != null)
        parameterPropertyBag.CreateProperty("PersonalEmail").StringValue = this.PersonalEmail;
      if (this.WorkEmail != null)
        parameterPropertyBag.CreateProperty("WorkEmail").StringValue = this.WorkEmail;
      if (this.OtherEmail != null)
        parameterPropertyBag.CreateProperty("OtherEmail").StringValue = this.OtherEmail;
      if (this.HomeAddressStreet != null)
        parameterPropertyBag.CreateProperty("HomeAddressStreet").StringValue = this.HomeAddressStreet;
      if (this.HomeAddressCity != null)
        parameterPropertyBag.CreateProperty("HomeAddressCity").StringValue = this.HomeAddressCity;
      if (this.HomeAddressState != null)
        parameterPropertyBag.CreateProperty("HomeAddressState").StringValue = this.HomeAddressState;
      if (this.HomeAddressZipCode != null)
        parameterPropertyBag.CreateProperty("HomeAddressZipCode").StringValue = this.HomeAddressZipCode;
      if (this.HomeAddressCountry != null)
        parameterPropertyBag.CreateProperty("HomeAddressCountry").StringValue = this.HomeAddressCountry;
      if (this.WorkAddressStreet != null)
        parameterPropertyBag.CreateProperty("WorkAddressStreet").StringValue = this.WorkAddressStreet;
      if (this.WorkAddressCity != null)
        parameterPropertyBag.CreateProperty("WorkAddressCity").StringValue = this.WorkAddressCity;
      if (this.WorkAddressState != null)
        parameterPropertyBag.CreateProperty("WorkAddressState").StringValue = this.WorkAddressState;
      if (this.WorkAddressZipCode != null)
        parameterPropertyBag.CreateProperty("WorkAddressZipCode").StringValue = this.WorkAddressZipCode;
      if (this.WorkAddressCountry != null)
        parameterPropertyBag.CreateProperty("WorkAddressCountry").StringValue = this.WorkAddressCountry;
      if (this.Website != null)
        parameterPropertyBag.CreateProperty("Website").StringValue = this.Website;
      if (this.Notes != null)
        parameterPropertyBag.CreateProperty("Notes").StringValue = this.Notes;
      if (this.JobTitle != null)
        parameterPropertyBag.CreateProperty("JobTitle").StringValue = this.JobTitle;
      return parameterPropertyBag;
    }

    internal override void OnInvokeReturned(byte[] outputBuffer, Delegate fireThisHandlerOnly) => this.FireCompleted((object) this, new SaveContactResult((outputBuffer == null ? 0 : ((uint) outputBuffer.Length > 0U ? 1 : 0)) != 0 ? TaskResult.OK : TaskResult.Cancel), fireThisHandlerOnly);

    internal override ChooserLaunchType LaunchType => ChooserLaunchType.ModernChooser;

    internal override string ChooserTargetPackageFamilyName => "Microsoft.People_8wekyb3d8bbwe";
  }
}
