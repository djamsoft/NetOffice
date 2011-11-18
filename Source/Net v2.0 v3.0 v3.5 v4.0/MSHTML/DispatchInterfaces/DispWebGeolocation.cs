//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface DispWebGeolocation SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispWebGeolocation : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(DispWebGeolocation);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispWebGeolocation(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispWebGeolocation(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispWebGeolocation(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispWebGeolocation() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispWebGeolocation(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="successCallback">object successCallback</param>
		/// <param name="errorCallback">object errorCallback</param>
		/// <param name="options">object options</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void getCurrentPosition(object successCallback, object errorCallback, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(successCallback, errorCallback, options);
			Invoker.Method(this, "getCurrentPosition", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="successCallback">object successCallback</param>
		/// <param name="errorCallback">object errorCallback</param>
		/// <param name="options">object options</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 watchPosition(object successCallback, object errorCallback, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(successCallback, errorCallback, options);
			object returnItem = Invoker.MethodReturn(this, "watchPosition", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="watchId">Int32 watchId</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void clearWatch(Int32 watchId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(watchId);
			Invoker.Method(this, "clearWatch", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}