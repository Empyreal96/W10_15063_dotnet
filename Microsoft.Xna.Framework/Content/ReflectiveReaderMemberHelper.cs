// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ReflectiveReaderMemberHelper
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;
using System.Reflection;
using System.Security;

namespace Microsoft.Xna.Framework.Content
{
  internal class ReflectiveReaderMemberHelper
  {
    private ContentTypeReader typeReader;
    private FieldInfo fieldInfo;
    private PropertyInfo propertyInfo;
    private bool canWrite;
    private bool sharedResource;

    public static ReflectiveReaderMemberHelper TryCreate(
      ContentTypeReaderManager manager,
      Type declaringType,
      FieldInfo fieldInfo)
    {
      bool canRead = true;
      bool canWrite = !fieldInfo.IsInitOnly && !fieldInfo.IsLiteral;
      if (ReflectiveReaderMemberHelper.ShouldSerializeMember(manager, declaringType, (MemberInfo) fieldInfo, fieldInfo.FieldType, fieldInfo.IsPublic, canRead, canWrite))
        return new ReflectiveReaderMemberHelper(manager, fieldInfo, (PropertyInfo) null, fieldInfo.FieldType, canWrite);
      ReflectiveReaderMemberHelper.ValidateSkippedMember((MemberInfo) fieldInfo);
      return (ReflectiveReaderMemberHelper) null;
    }

    public static ReflectiveReaderMemberHelper TryCreate(
      ContentTypeReaderManager manager,
      Type declaringType,
      PropertyInfo propertyInfo)
    {
      if (!ReflectiveReaderMemberHelper.ShouldSerializeProperty(manager, declaringType, propertyInfo))
      {
        ReflectiveReaderMemberHelper.ValidateSkippedMember((MemberInfo) propertyInfo);
        return (ReflectiveReaderMemberHelper) null;
      }
      ContentTypeReaderManager manager1 = manager;
      PropertyInfo propertyInfo1 = propertyInfo;
      Type propertyType = propertyInfo1.PropertyType;
      int num = propertyInfo.CanWrite ? 1 : 0;
      return new ReflectiveReaderMemberHelper(manager1, (FieldInfo) null, propertyInfo1, propertyType, num != 0);
    }

    private ReflectiveReaderMemberHelper(
      ContentTypeReaderManager manager,
      FieldInfo fieldInfo,
      PropertyInfo propertyInfo,
      Type memberType,
      bool canWrite)
    {
      this.typeReader = manager.GetTypeReader(memberType);
      this.fieldInfo = fieldInfo;
      this.propertyInfo = propertyInfo;
      this.canWrite = canWrite;
      if (fieldInfo != null)
        this.sharedResource = ReflectiveReaderMemberHelper.IsSharedResource((MemberInfo) fieldInfo);
      else
        this.sharedResource = ReflectiveReaderMemberHelper.IsSharedResource((MemberInfo) propertyInfo);
    }

    private static bool ShouldSerializeMember(
      ContentTypeReaderManager manager,
      Type declaringType,
      MemberInfo memberInfo,
      Type memberType,
      bool isPublic,
      bool canRead,
      bool canWrite)
    {
      return canRead && !memberInfo.IsDefined(typeof (ContentSerializerIgnoreAttribute), false) && (isPublic || Attribute.GetCustomAttribute(memberInfo, typeof (ContentSerializerAttribute)) != null) && (canWrite || ContentTypeReaderManager.ContainsTypeReader(memberType) && manager.GetTypeReader(memberType).CanDeserializeIntoExistingObject) && (!declaringType.IsValueType || !ReflectiveReaderMemberHelper.IsSharedResource(memberInfo));
    }

    private static bool ShouldSerializeProperty(
      ContentTypeReaderManager manager,
      Type declaringType,
      PropertyInfo propertyInfo)
    {
      if (propertyInfo.GetIndexParameters().Length != 0)
        return false;
      bool isPublic = true;
      foreach (MethodInfo accessor in propertyInfo.GetAccessors(true))
      {
        if (accessor.GetBaseDefinition() != accessor)
          return false;
        if (!accessor.IsPublic)
          isPublic = false;
      }
      return ReflectiveReaderMemberHelper.ShouldSerializeMember(manager, declaringType, (MemberInfo) propertyInfo, propertyInfo.PropertyType, isPublic, propertyInfo.CanRead, propertyInfo.CanWrite);
    }

    private static bool IsSharedResource(MemberInfo memberInfo)
    {
      Attribute customAttribute = Attribute.GetCustomAttribute(memberInfo, typeof (ContentSerializerAttribute));
      return customAttribute != null && ((ContentSerializerAttribute) customAttribute).SharedResource;
    }

    private static void ValidateSkippedMember(MemberInfo memberInfo)
    {
      if (Attribute.GetCustomAttribute(memberInfo, typeof (ContentSerializerAttribute)) != null)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.CantSerializeMember, (object) memberInfo.Name, (object) memberInfo.DeclaringType));
    }

    [SecuritySafeCritical]
    public void Read(ContentReader input, object parentInstance)
    {
      if (this.sharedResource)
      {
        if (!this.canWrite)
          throw new InvalidOperationException(FrameworkResources.ReadOnlySharedResource);
        input.ReadSharedResource<object>((Action<object>) (value => this.FixupSharedResource(input, parentInstance, value)));
      }
      else if (this.canWrite)
      {
        object obj = input.ReadObject<object>(this.typeReader, (object) null);
        if (this.propertyInfo != null)
          this.propertyInfo.SetValue(parentInstance, obj, (object[]) null);
        else
          this.fieldInfo.SetValue(parentInstance, obj);
      }
      else
      {
        object existingInstance = this.propertyInfo == null ? this.fieldInfo.GetValue(parentInstance) : this.propertyInfo.GetValue(parentInstance, (object[]) null);
        if (existingInstance == null)
        {
          MemberInfo memberInfo = this.propertyInfo == null ? (MemberInfo) this.fieldInfo : (MemberInfo) this.propertyInfo;
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.CantSerializeReadOnlyNull, (object) memberInfo.Name, (object) memberInfo.DeclaringType));
        }
        input.ReadObject<object>(this.typeReader, existingInstance);
      }
    }

    [SecuritySafeCritical]
    private void FixupSharedResource(ContentReader input, object parentInstance, object value)
    {
      if (!this.typeReader.TargetType.IsAssignableFrom(value.GetType()))
        throw input.CreateContentLoadException(FrameworkResources.BadXnbWrongType, (object) value.GetType(), (object) this.typeReader.TargetType);
      if (this.propertyInfo != null)
        this.propertyInfo.SetValue(parentInstance, value, (object[]) null);
      else
        this.fieldInfo.SetValue(parentInstance, value);
    }
  }
}
