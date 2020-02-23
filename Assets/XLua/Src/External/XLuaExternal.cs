using System.Runtime.InteropServices;
using XLua;

namespace XLua.LuaDLL
{ 
    public partial class Lua
    { 
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_sproto_core(System.IntPtr L);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_lpeg(System.IntPtr L);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_client_crypt(System.IntPtr L);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_cjson(System.IntPtr L);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_clonefunc(System.IntPtr L);//[,,m]


        [MonoPInvokeCallback(typeof(XLua.LuaDLL.lua_CSFunction))]
        public static int LoadSproto(System.IntPtr L)
        {
            return luaopen_sproto_core(L);
        }

        [MonoPInvokeCallback(typeof(XLua.LuaDLL.lua_CSFunction))]
        public static int LoadLpeg(System.IntPtr L)
        {
            return luaopen_lpeg(L);
        }

        [MonoPInvokeCallback(typeof(XLua.LuaDLL.lua_CSFunction))]
        public static int LoadCrypt(System.IntPtr L)
        {
            return luaopen_client_crypt(L);
        }

        [MonoPInvokeCallback(typeof(LuaDLL.lua_CSFunction))]
        public static int LoadCJson(System.IntPtr L)
        {
            return luaopen_cjson(L);
        }

        [MonoPInvokeCallback(typeof(LuaDLL.lua_CSFunction))]
        public static int LoadCloneFunc(System.IntPtr L)
        {
            return luaopen_clonefunc(L);
        }

    }
}