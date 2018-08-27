// Copyright 2013-2018 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.
// <auto-generated/>

using System;
using System.Security;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
    public partial class MagickImageCollection
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int ReadWriteStreamDelegate(IntPtr data, UIntPtr length, IntPtr user_data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate long SeekStreamDelegate(long offset, IntPtr whence, IntPtr user_data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate long TellStreamDelegate(IntPtr user_data);
        #if !NETSTANDARD1_3
        [SuppressUnmanagedCodeSecurity]
        #endif
        private static class NativeMethods
        {
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            public static class X64
            {
                #if PLATFORM_AnyCPU
                [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MagickImageCollection+NativeMethods.X64#.cctor()")]
                static X64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Append(IntPtr image, [MarshalAs(UnmanagedType.Bool)] bool stack, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Coalesce(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Combine(IntPtr image, UIntPtr colorSpace, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Deconstruct(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_Dispose(IntPtr value);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Evaluate(IntPtr image, UIntPtr evaluateOperator, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Flatten(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_Map(IntPtr image, IntPtr settings, IntPtr remapImage, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Merge(IntPtr image, UIntPtr method, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Montage(IntPtr image, IntPtr settings, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Morph(IntPtr image, UIntPtr frames, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Optimize(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_OptimizePlus(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_OptimizeTransparency(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Polynomial(IntPtr image, double[] terms, UIntPtr length, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_Quantize(IntPtr image, IntPtr settings, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_ReadBlob(IntPtr settings, byte[] data, UIntPtr length, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_ReadFile(IntPtr settings, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_ReadStream(IntPtr settings, ReadWriteStreamDelegate reader, SeekStreamDelegate seeker, TellStreamDelegate teller, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Smush(IntPtr image, IntPtr offset, [MarshalAs(UnmanagedType.Bool)] bool stack, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_WriteFile(IntPtr image, IntPtr settings, out IntPtr exception);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_WriteStream(IntPtr image, IntPtr settings, ReadWriteStreamDelegate writer, SeekStreamDelegate seeker, TellStreamDelegate teller, ReadWriteStreamDelegate reader, out IntPtr exception);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MagickImageCollection+NativeMethods.X86#.cctor()")]
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Append(IntPtr image, [MarshalAs(UnmanagedType.Bool)] bool stack, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Coalesce(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Combine(IntPtr image, UIntPtr colorSpace, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Deconstruct(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_Dispose(IntPtr value);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Evaluate(IntPtr image, UIntPtr evaluateOperator, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Flatten(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_Map(IntPtr image, IntPtr settings, IntPtr remapImage, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Merge(IntPtr image, UIntPtr method, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Montage(IntPtr image, IntPtr settings, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Morph(IntPtr image, UIntPtr frames, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Optimize(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_OptimizePlus(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_OptimizeTransparency(IntPtr image, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Polynomial(IntPtr image, double[] terms, UIntPtr length, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_Quantize(IntPtr image, IntPtr settings, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_ReadBlob(IntPtr settings, byte[] data, UIntPtr length, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_ReadFile(IntPtr settings, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_ReadStream(IntPtr settings, ReadWriteStreamDelegate reader, SeekStreamDelegate seeker, TellStreamDelegate teller, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_Smush(IntPtr image, IntPtr offset, [MarshalAs(UnmanagedType.Bool)] bool stack, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickImageCollection_WriteFile(IntPtr image, IntPtr settings, out IntPtr exception);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickImageCollection_WriteStream(IntPtr image, IntPtr settings, ReadWriteStreamDelegate writer, SeekStreamDelegate seeker, TellStreamDelegate teller, ReadWriteStreamDelegate reader, out IntPtr exception);
            }
            #endif
        }
        private sealed class NativeMagickImageCollection : NativeHelper
        {
            static NativeMagickImageCollection() { Environment.Initialize(); }
            public IntPtr Append(IMagickImage image, bool stack)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Append(image.GetInstance(), stack, out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Append(image.GetInstance(), stack, out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public IntPtr Coalesce(IMagickImage image)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Coalesce(image.GetInstance(), out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Coalesce(image.GetInstance(), out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public IntPtr Combine(IMagickImage image, ColorSpace colorSpace)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Combine(image.GetInstance(), (UIntPtr)colorSpace, out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Combine(image.GetInstance(), (UIntPtr)colorSpace, out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public IntPtr Deconstruct(IMagickImage image)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Deconstruct(image.GetInstance(), out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Deconstruct(image.GetInstance(), out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public static void Dispose(IntPtr value)
            {
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                NativeMethods.X64.MagickImageCollection_Dispose(value);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                NativeMethods.X86.MagickImageCollection_Dispose(value);
                #endif
            }
            public IntPtr Evaluate(IMagickImage image, EvaluateOperator evaluateOperator)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Evaluate(image.GetInstance(), (UIntPtr)evaluateOperator, out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Evaluate(image.GetInstance(), (UIntPtr)evaluateOperator, out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public IntPtr Flatten(IMagickImage image)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Flatten(image.GetInstance(), out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Flatten(image.GetInstance(), out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public void Map(IMagickImage image, QuantizeSettings settings, IMagickImage remapImage)
            {
                using (INativeInstance settingsNative = QuantizeSettings.CreateInstance(settings))
                {
                    IntPtr exception = IntPtr.Zero;
                    #if PLATFORM_AnyCPU
                    if (NativeLibrary.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    NativeMethods.X64.MagickImageCollection_Map(image.GetInstance(), settingsNative.Instance, remapImage.GetInstance(), out exception);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    NativeMethods.X86.MagickImageCollection_Map(image.GetInstance(), settingsNative.Instance, remapImage.GetInstance(), out exception);
                    #endif
                    CheckException(exception);
                }
            }
            public IntPtr Merge(IMagickImage image, LayerMethod method)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Merge(image.GetInstance(), (UIntPtr)method, out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Merge(image.GetInstance(), (UIntPtr)method, out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public IntPtr Montage(IMagickImage image, MontageSettings settings)
            {
                using (INativeInstance settingsNative = MontageSettings.CreateInstance(settings))
                {
                    IntPtr exception = IntPtr.Zero;
                    IntPtr result;
                    #if PLATFORM_AnyCPU
                    if (NativeLibrary.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickImageCollection_Montage(image.GetInstance(), settingsNative.Instance, out exception);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickImageCollection_Montage(image.GetInstance(), settingsNative.Instance, out exception);
                    #endif
                    MagickException magickException = MagickExceptionHelper.Create(exception);
                    if (MagickExceptionHelper.IsError(magickException))
                    {
                        if (result != IntPtr.Zero)
                            Dispose(result);
                        throw magickException;
                    }
                    RaiseWarning(magickException);
                    return result;
                }
            }
            public IntPtr Morph(IMagickImage image, int frames)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Morph(image.GetInstance(), (UIntPtr)frames, out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Morph(image.GetInstance(), (UIntPtr)frames, out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public IntPtr Optimize(IMagickImage image)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Optimize(image.GetInstance(), out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Optimize(image.GetInstance(), out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public IntPtr OptimizePlus(IMagickImage image)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_OptimizePlus(image.GetInstance(), out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_OptimizePlus(image.GetInstance(), out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public void OptimizeTransparency(IMagickImage image)
            {
                IntPtr exception = IntPtr.Zero;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                NativeMethods.X64.MagickImageCollection_OptimizeTransparency(image.GetInstance(), out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                NativeMethods.X86.MagickImageCollection_OptimizeTransparency(image.GetInstance(), out exception);
                #endif
                CheckException(exception);
            }
            public IntPtr Polynomial(IMagickImage image, double[] terms, int length)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Polynomial(image.GetInstance(), terms, (UIntPtr)length, out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Polynomial(image.GetInstance(), terms, (UIntPtr)length, out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public void Quantize(IMagickImage image, QuantizeSettings settings)
            {
                using (INativeInstance settingsNative = QuantizeSettings.CreateInstance(settings))
                {
                    IntPtr exception = IntPtr.Zero;
                    #if PLATFORM_AnyCPU
                    if (NativeLibrary.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    NativeMethods.X64.MagickImageCollection_Quantize(image.GetInstance(), settingsNative.Instance, out exception);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    NativeMethods.X86.MagickImageCollection_Quantize(image.GetInstance(), settingsNative.Instance, out exception);
                    #endif
                    CheckException(exception);
                }
            }
            public IntPtr ReadBlob(MagickSettings settings, byte[] data, int length)
            {
                using (INativeInstance settingsNative = MagickSettings.CreateInstance(settings))
                {
                    IntPtr exception = IntPtr.Zero;
                    IntPtr result;
                    #if PLATFORM_AnyCPU
                    if (NativeLibrary.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickImageCollection_ReadBlob(settingsNative.Instance, data, (UIntPtr)length, out exception);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickImageCollection_ReadBlob(settingsNative.Instance, data, (UIntPtr)length, out exception);
                    #endif
                    MagickException magickException = MagickExceptionHelper.Create(exception);
                    if (MagickExceptionHelper.IsError(magickException))
                    {
                        if (result != IntPtr.Zero)
                            Dispose(result);
                        throw magickException;
                    }
                    RaiseWarning(magickException);
                    return result;
                }
            }
            public IntPtr ReadFile(MagickSettings settings)
            {
                using (INativeInstance settingsNative = MagickSettings.CreateInstance(settings))
                {
                    IntPtr exception = IntPtr.Zero;
                    IntPtr result;
                    #if PLATFORM_AnyCPU
                    if (NativeLibrary.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickImageCollection_ReadFile(settingsNative.Instance, out exception);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickImageCollection_ReadFile(settingsNative.Instance, out exception);
                    #endif
                    MagickException magickException = MagickExceptionHelper.Create(exception);
                    if (MagickExceptionHelper.IsError(magickException))
                    {
                        if (result != IntPtr.Zero)
                            Dispose(result);
                        throw magickException;
                    }
                    RaiseWarning(magickException);
                    return result;
                }
            }
            public IntPtr ReadStream(MagickSettings settings, ReadWriteStreamDelegate reader, SeekStreamDelegate seeker, TellStreamDelegate teller)
            {
                using (INativeInstance settingsNative = MagickSettings.CreateInstance(settings))
                {
                    IntPtr exception = IntPtr.Zero;
                    IntPtr result;
                    #if PLATFORM_AnyCPU
                    if (NativeLibrary.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickImageCollection_ReadStream(settingsNative.Instance, reader, seeker, teller, out exception);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickImageCollection_ReadStream(settingsNative.Instance, reader, seeker, teller, out exception);
                    #endif
                    MagickException magickException = MagickExceptionHelper.Create(exception);
                    if (MagickExceptionHelper.IsError(magickException))
                    {
                        if (result != IntPtr.Zero)
                            Dispose(result);
                        throw magickException;
                    }
                    RaiseWarning(magickException);
                    return result;
                }
            }
            public IntPtr Smush(IMagickImage image, int offset, bool stack)
            {
                IntPtr exception = IntPtr.Zero;
                IntPtr result;
                #if PLATFORM_AnyCPU
                if (NativeLibrary.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.MagickImageCollection_Smush(image.GetInstance(), (IntPtr)offset, stack, out exception);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.MagickImageCollection_Smush(image.GetInstance(), (IntPtr)offset, stack, out exception);
                #endif
                MagickException magickException = MagickExceptionHelper.Create(exception);
                if (MagickExceptionHelper.IsError(magickException))
                {
                    if (result != IntPtr.Zero)
                        Dispose(result);
                    throw magickException;
                }
                RaiseWarning(magickException);
                return result;
            }
            public void WriteFile(IMagickImage image, MagickSettings settings)
            {
                using (INativeInstance settingsNative = MagickSettings.CreateInstance(settings))
                {
                    IntPtr exception = IntPtr.Zero;
                    #if PLATFORM_AnyCPU
                    if (NativeLibrary.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    NativeMethods.X64.MagickImageCollection_WriteFile(image.GetInstance(), settingsNative.Instance, out exception);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    NativeMethods.X86.MagickImageCollection_WriteFile(image.GetInstance(), settingsNative.Instance, out exception);
                    #endif
                    CheckException(exception);
                }
            }
            public IntPtr WriteStream(IMagickImage image, MagickSettings settings, ReadWriteStreamDelegate writer, SeekStreamDelegate seeker, TellStreamDelegate teller, ReadWriteStreamDelegate reader)
            {
                using (INativeInstance settingsNative = MagickSettings.CreateInstance(settings))
                {
                    IntPtr exception = IntPtr.Zero;
                    IntPtr result;
                    #if PLATFORM_AnyCPU
                    if (NativeLibrary.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickImageCollection_WriteStream(image.GetInstance(), settingsNative.Instance, writer, seeker, teller, reader, out exception);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickImageCollection_WriteStream(image.GetInstance(), settingsNative.Instance, writer, seeker, teller, reader, out exception);
                    #endif
                    MagickException magickException = MagickExceptionHelper.Create(exception);
                    if (MagickExceptionHelper.IsError(magickException))
                    {
                        if (result != IntPtr.Zero)
                            Dispose(result);
                        throw magickException;
                    }
                    RaiseWarning(magickException);
                    return result;
                }
            }
        }
    }
}
