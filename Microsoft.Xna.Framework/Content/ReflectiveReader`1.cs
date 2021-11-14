// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ReflectiveReader`1
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Security;

namespace Microsoft.Xna.Framework.Content
{
  internal class ReflectiveReader<T> : ContentTypeReader
  {
    private ContentTypeReader baseReader;
    private List<ReflectiveReaderMemberHelper> memberHelpers = new List<ReflectiveReaderMemberHelper>();
    private ConstructorInfo instanceConstructor;
    private int typeVersion;

    [SecuritySafeCritical]
    public ReflectiveReader()
      : base(typeof (T))
    {
      this.instanceConstructor = typeof (T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
      object[] customAttributes = typeof (T).GetCustomAttributes(typeof (ContentSerializerTypeVersionAttribute), false);
      if (customAttributes.Length != 1)
        return;
      this.typeVersion = ((ContentSerializerTypeVersionAttribute) customAttributes[0]).TypeVersion;
    }

    [SecuritySafeCritical]
    protected internal override void Initialize(ContentTypeReaderManager manager)
    {
      Type baseType = this.TargetType.BaseType;
      if (baseType != null && baseType != typeof (object) && baseType != typeof (ValueType))
        this.baseReader = manager.GetTypeReader(baseType);
      BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
      PropertyInfo[] properties = this.TargetType.GetProperties(bindingAttr);
      FieldInfo[] fields = this.TargetType.GetFields(bindingAttr);
      foreach (PropertyInfo propertyInfo in properties)
      {
        ReflectiveReaderMemberHelper readerMemberHelper = ReflectiveReaderMemberHelper.TryCreate(manager, this.TargetType, propertyInfo);
        if (readerMemberHelper != null)
          this.memberHelpers.Add(readerMemberHelper);
      }
      foreach (FieldInfo fieldInfo in fields)
      {
        ReflectiveReaderMemberHelper readerMemberHelper = ReflectiveReaderMemberHelper.TryCreate(manager, this.TargetType, fieldInfo);
        if (readerMemberHelper != null)
          this.memberHelpers.Add(readerMemberHelper);
      }
    }

    [SecuritySafeCritical]
    protected internal override object Read(ContentReader input, object existingInstance)
    {
      if (input == null)
        throw new ArgumentNullException(nameof (input));
      object obj = existingInstance;
      if (obj == null)
      {
        if (this.instanceConstructor != null)
          obj = this.instanceConstructor.Invoke((object[]) null);
        else if (this.TargetIsValueType)
          obj = Activator.CreateInstance(this.TargetType);
        else
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NoDefaultConstructor, (object) this.TargetType));
      }
      if (this.baseReader != null && this.baseReader.Read(input, obj) != obj)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.ReaderConstructedNewInstance, (object) this.baseReader.GetType()));
      foreach (ReflectiveReaderMemberHelper memberHelper in this.memberHelpers)
        memberHelper.Read(input, obj);
      return obj;
    }

    public override bool CanDeserializeIntoExistingObject => this.TargetType.IsClass;

    public override int TypeVersion => this.typeVersion;
  }
}
