// Generated by Haxe 3.4.0

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Std {
	
	public Std() {
	}
	
	
	public static bool @is(object v, object t) {
		#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		if (( v == null )) {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return global::haxe.lang.Runtime.eq(t, typeof(object));
		}
		
		#line 31 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		if (( t == null )) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return false;
		}
		
		#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		global::System.Type clt = ((global::System.Type) (( t as global::System.Type )) );
		if (global::haxe.lang.Runtime.typeEq(clt, null)) {
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return false;
		}
		
		#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		{
			#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			string _g = ( clt as global::System.Reflection.MemberInfo ).ToString();
			#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			switch (_g) {
				case "System.Boolean":
				{
					#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return v is bool;
				}
				
				
				case "System.Double":
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return v is double || v is int;
				}
				
				
				case "System.Int32":
				{
					#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return global::haxe.lang.Runtime.isInt(v);
				}
				
				
				case "System.Object":
				{
					#line 46 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return true;
				}
				
				
			}
			
		}
		
		#line 49 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		global::System.Type vt = v.GetType();
		#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		if (clt.IsAssignableFrom(((global::System.Type) (vt) ))) {
			#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return true;
		}
		
		#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		{
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			global::System.Type[] _g1_arr = clt.GetInterfaces();
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			uint _g1_idx = ((uint) (0) );
			#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			while (((bool) (( _g1_idx < ( _g1_arr as global::System.Array ).Length )) )) {
				#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				global::System.Type iface = ((global::System.Type) (_g1_arr[((int) (_g1_idx++) )]) );
				global::haxe.lang.GenericInterface g = global::haxe.lang.Runtime.getGenericAttr(iface);
				#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (( ( g != null ) && global::haxe.lang.Runtime.typeEq(g.generic, clt) )) {
					#line 58 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return iface.IsAssignableFrom(((global::System.Type) (vt) ));
				}
				
			}
			
		}
		
		#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		return false;
	}
	#line default
	
	public static string @string(object s) {
		#line 67 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		if (( s == null )) {
			#line 68 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return "null";
		}
		
		#line 69 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		if (( s is bool )) {
			#line 70 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (global::haxe.lang.Runtime.toBool(s)) {
				#line 70 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return "true";
			}
			else {
				#line 70 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return "false";
			}
			
		}
		
		#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		return s.ToString();
	}
	#line default
	
	public static int @int(double x) {
		#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
		return ((int) (x) );
	}
	#line default
	
}


