#if USE_HOT
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Linq;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class UnityEngine_Matrix4x4_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Matrix4x4);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("Inverse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Inverse_0);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("Transpose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Transpose_1);
            args = new Type[]{};
            method = type.GetMethod("get_inverse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inverse_2);
            args = new Type[]{};
            method = type.GetMethod("get_transpose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_transpose_3);
            args = new Type[]{};
            method = type.GetMethod("get_isIdentity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isIdentity_4);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("Determinant", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Determinant_5);
            args = new Type[]{};
            method = type.GetMethod("get_determinant", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_determinant_6);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetTRS", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTRS_7);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("TRS", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TRS_8);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("Ortho", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ortho_9);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("Perspective", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Perspective_10);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("LookAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LookAt_11);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_12);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_13);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_14);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_15);
            args = new Type[]{};
            method = type.GetMethod("GetHashCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetHashCode_16);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_17);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Multiply_18);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Multiply_19);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("op_Equality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Equality_20);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("op_Inequality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Inequality_21);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetColumn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetColumn_22);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetRow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRow_23);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetColumn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetColumn_24);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetRow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRow_25);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("MultiplyPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MultiplyPoint_26);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("MultiplyPoint3x4", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MultiplyPoint3x4_27);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("MultiplyVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MultiplyVector_28);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("Scale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Scale_29);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("Translate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Translate_30);
            args = new Type[]{};
            method = type.GetMethod("get_zero", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_zero_31);
            args = new Type[]{};
            method = type.GetMethod("get_identity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_identity_32);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_33);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_34);

            field = type.GetField("m00", flag);
            app.RegisterCLRFieldGetter(field, get_m00_0);
            app.RegisterCLRFieldSetter(field, set_m00_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_m00_0, AssignFromStack_m00_0);
            field = type.GetField("m10", flag);
            app.RegisterCLRFieldGetter(field, get_m10_1);
            app.RegisterCLRFieldSetter(field, set_m10_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_m10_1, AssignFromStack_m10_1);
            field = type.GetField("m20", flag);
            app.RegisterCLRFieldGetter(field, get_m20_2);
            app.RegisterCLRFieldSetter(field, set_m20_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_m20_2, AssignFromStack_m20_2);
            field = type.GetField("m30", flag);
            app.RegisterCLRFieldGetter(field, get_m30_3);
            app.RegisterCLRFieldSetter(field, set_m30_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_m30_3, AssignFromStack_m30_3);
            field = type.GetField("m01", flag);
            app.RegisterCLRFieldGetter(field, get_m01_4);
            app.RegisterCLRFieldSetter(field, set_m01_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_m01_4, AssignFromStack_m01_4);
            field = type.GetField("m11", flag);
            app.RegisterCLRFieldGetter(field, get_m11_5);
            app.RegisterCLRFieldSetter(field, set_m11_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_m11_5, AssignFromStack_m11_5);
            field = type.GetField("m21", flag);
            app.RegisterCLRFieldGetter(field, get_m21_6);
            app.RegisterCLRFieldSetter(field, set_m21_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_m21_6, AssignFromStack_m21_6);
            field = type.GetField("m31", flag);
            app.RegisterCLRFieldGetter(field, get_m31_7);
            app.RegisterCLRFieldSetter(field, set_m31_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_m31_7, AssignFromStack_m31_7);
            field = type.GetField("m02", flag);
            app.RegisterCLRFieldGetter(field, get_m02_8);
            app.RegisterCLRFieldSetter(field, set_m02_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_m02_8, AssignFromStack_m02_8);
            field = type.GetField("m12", flag);
            app.RegisterCLRFieldGetter(field, get_m12_9);
            app.RegisterCLRFieldSetter(field, set_m12_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_m12_9, AssignFromStack_m12_9);
            field = type.GetField("m22", flag);
            app.RegisterCLRFieldGetter(field, get_m22_10);
            app.RegisterCLRFieldSetter(field, set_m22_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_m22_10, AssignFromStack_m22_10);
            field = type.GetField("m32", flag);
            app.RegisterCLRFieldGetter(field, get_m32_11);
            app.RegisterCLRFieldSetter(field, set_m32_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_m32_11, AssignFromStack_m32_11);
            field = type.GetField("m03", flag);
            app.RegisterCLRFieldGetter(field, get_m03_12);
            app.RegisterCLRFieldSetter(field, set_m03_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_m03_12, AssignFromStack_m03_12);
            field = type.GetField("m13", flag);
            app.RegisterCLRFieldGetter(field, get_m13_13);
            app.RegisterCLRFieldSetter(field, set_m13_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_m13_13, AssignFromStack_m13_13);
            field = type.GetField("m23", flag);
            app.RegisterCLRFieldGetter(field, get_m23_14);
            app.RegisterCLRFieldSetter(field, set_m23_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_m23_14, AssignFromStack_m23_14);
            field = type.GetField("m33", flag);
            app.RegisterCLRFieldGetter(field, get_m33_15);
            app.RegisterCLRFieldSetter(field, set_m33_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_m33_15, AssignFromStack_m33_15);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Matrix4x4());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Matrix4x4[s]);


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Matrix4x4 instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Matrix4x4[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* Inverse_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @m = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Matrix4x4.Inverse(@m);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Transpose_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @m = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Matrix4x4.Transpose(@m);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_inverse_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.inverse;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_transpose_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.transpose;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isIdentity_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.isIdentity;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Determinant_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @m = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Matrix4x4.Determinant(@m);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_determinant_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.determinant;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetTRS_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @s = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @q = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @pos = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetTRS(@pos, @q, @s);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* TRS_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @s = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @q = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @pos = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Matrix4x4.TRS(@pos, @q, @s);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ortho_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @zFar = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @zNear = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @top = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @bottom = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @right = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @left = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Matrix4x4.Ortho(@left, @right, @bottom, @top, @zNear, @zFar);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Perspective_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @zFar = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @zNear = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @aspect = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @fov = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Matrix4x4.Perspective(@fov, @aspect, @zNear, @zFar);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LookAt_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @up = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @to = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @from = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Matrix4x4.LookAt(@from, @to, @up);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Item_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @column = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @row = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method[row];

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Item_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @column = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @row = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method[row] = column;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_Item_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method[index];

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Item_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method[index] = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* GetHashCode_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetHashCode();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Equals_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @other = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.Equals(@other);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* op_Multiply_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @rhs = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 @lhs = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = lhs * rhs;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* op_Multiply_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @v = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 @lhs = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = lhs * v;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* op_Equality_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @rhs = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 @lhs = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = lhs == rhs;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* op_Inequality_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @rhs = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 @lhs = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = lhs != rhs;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetColumn_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @i = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetColumn(@i);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRow_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @i = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetRow(@i);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetColumn_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @v = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @i = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetColumn(@i, @v);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetRow_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @v = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @i = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetRow(@i, @v);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* MultiplyPoint_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.MultiplyPoint(@v);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MultiplyPoint3x4_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.MultiplyPoint3x4(@v);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MultiplyVector_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.MultiplyVector(@v);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Scale_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Matrix4x4.Scale(@v);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Translate_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Matrix4x4.Translate(@v);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_zero_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Matrix4x4.zero;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_identity_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Matrix4x4.identity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.ToString();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @format = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Matrix4x4 instance_of_this_method = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.ToString(@format);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_m00_0(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m00;
        }

        static StackObject* CopyToStack_m00_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m00;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m00_0(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m00 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m00_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m00 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m00 = @m00;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m10_1(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m10;
        }

        static StackObject* CopyToStack_m10_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m10;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m10_1(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m10 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m10_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m10 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m10 = @m10;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m20_2(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m20;
        }

        static StackObject* CopyToStack_m20_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m20;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m20_2(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m20 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m20_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m20 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m20 = @m20;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m30_3(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m30;
        }

        static StackObject* CopyToStack_m30_3(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m30;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m30_3(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m30 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m30_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m30 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m30 = @m30;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m01_4(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m01;
        }

        static StackObject* CopyToStack_m01_4(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m01;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m01_4(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m01 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m01_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m01 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m01 = @m01;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m11_5(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m11;
        }

        static StackObject* CopyToStack_m11_5(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m11;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m11_5(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m11 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m11_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m11 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m11 = @m11;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m21_6(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m21;
        }

        static StackObject* CopyToStack_m21_6(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m21;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m21_6(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m21 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m21_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m21 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m21 = @m21;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m31_7(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m31;
        }

        static StackObject* CopyToStack_m31_7(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m31;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m31_7(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m31 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m31_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m31 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m31 = @m31;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m02_8(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m02;
        }

        static StackObject* CopyToStack_m02_8(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m02;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m02_8(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m02 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m02_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m02 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m02 = @m02;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m12_9(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m12;
        }

        static StackObject* CopyToStack_m12_9(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m12;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m12_9(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m12 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m12_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m12 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m12 = @m12;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m22_10(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m22;
        }

        static StackObject* CopyToStack_m22_10(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m22;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m22_10(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m22 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m22_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m22 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m22 = @m22;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m32_11(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m32;
        }

        static StackObject* CopyToStack_m32_11(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m32;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m32_11(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m32 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m32_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m32 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m32 = @m32;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m03_12(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m03;
        }

        static StackObject* CopyToStack_m03_12(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m03;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m03_12(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m03 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m03_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m03 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m03 = @m03;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m13_13(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m13;
        }

        static StackObject* CopyToStack_m13_13(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m13;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m13_13(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m13 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m13_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m13 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m13 = @m13;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m23_14(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m23;
        }

        static StackObject* CopyToStack_m23_14(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m23;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m23_14(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m23 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m23_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m23 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m23 = @m23;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_m33_15(ref object o)
        {
            return ((UnityEngine.Matrix4x4)o).m33;
        }

        static StackObject* CopyToStack_m33_15(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((UnityEngine.Matrix4x4)o).m33;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m33_15(ref object o, object v)
        {
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m33 = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_m33_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m33 = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Matrix4x4 ins =(UnityEngine.Matrix4x4)o;
            ins.m33 = @m33;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Matrix4x4();
            ins = (UnityEngine.Matrix4x4)o;
            return ins;
        }


    }
}
#endif
