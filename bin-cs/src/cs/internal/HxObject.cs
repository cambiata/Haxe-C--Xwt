// Generated by Haxe 3.4.0

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public interface IHxObject {
		
		bool __hx_deleteField(string field, int hash);
		
		object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck);
		
		double __hx_lookupField_f(string field, int hash, bool throwErrors);
		
		object __hx_lookupSetField(string field, int hash, object @value);
		
		double __hx_lookupSetField_f(string field, int hash, double @value);
		
		double __hx_setField_f(string field, int hash, double @value, bool handleProperties);
		
		object __hx_setField(string field, int hash, object @value, bool handleProperties);
		
		object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties);
		
		double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties);
		
		object __hx_invokeField(string field, int hash, global::Array dynargs);
		
		void __hx_getFields(global::Array<object> baseArr);
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class HxObject : global::haxe.lang.IHxObject {
		
		public HxObject(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HxObject() {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.HxObject.__hx_ctor_haxe_lang_HxObject(this);
		}
		#line default
		
		public static void __hx_ctor_haxe_lang_HxObject(global::haxe.lang.HxObject __hx_this) {
		}
		
		
		public virtual bool __hx_deleteField(string field, int hash) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return false;
		}
		#line default
		
		public virtual object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (isCheck) {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			else if (throwErrors) {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				throw global::haxe.lang.HaxeException.wrap("Field not found.");
			}
			else {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return null;
			}
			
		}
		#line default
		
		public virtual double __hx_lookupField_f(string field, int hash, bool throwErrors) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (throwErrors) {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
			}
			else {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return default(double);
			}
			
		}
		#line default
		
		public virtual object __hx_lookupSetField(string field, int hash, object @value) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
		}
		#line default
		
		public virtual double __hx_lookupSetField_f(string field, int hash, double @value) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
		}
		#line default
		
		public virtual double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			switch (hash) {
				default:
				{
					#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_lookupSetField_f(field, hash, @value);
				}
				
			}
			
		}
		#line default
		
		public virtual object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			switch (hash) {
				default:
				{
					#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_lookupSetField(field, hash, @value);
				}
				
			}
			
		}
		#line default
		
		public virtual object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			switch (hash) {
				default:
				{
					#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_lookupField(field, hash, throwErrors, isCheck);
				}
				
			}
			
		}
		#line default
		
		public virtual double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			switch (hash) {
				default:
				{
					#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_lookupField_f(field, hash, throwErrors);
				}
				
			}
			
		}
		#line default
		
		public virtual object __hx_invokeField(string field, int hash, global::Array dynargs) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			switch (hash) {
				default:
				{
					#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
				}
				
			}
			
		}
		#line default
		
		public virtual void __hx_getFields(global::Array<object> baseArr) {
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class DynamicObject : global::haxe.lang.HxObject {
		
		public DynamicObject(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public DynamicObject() {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.DynamicObject.__hx_ctor_haxe_lang_DynamicObject(((global::haxe.lang.DynamicObject) (this) ));
		}
		#line default
		
		public DynamicObject(int[] __hx_hashes, object[] __hx_dynamics, int[] __hx_hashes_f, double[] __hx_dynamics_f) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.DynamicObject.__hx_ctor_haxe_lang_DynamicObject(((global::haxe.lang.DynamicObject) (this) ), ((int[]) (__hx_hashes) ), ((object[]) (__hx_dynamics) ), ((int[]) (__hx_hashes_f) ), ((double[]) (__hx_dynamics_f) ));
		}
		#line default
		
		public static void __hx_ctor_haxe_lang_DynamicObject(global::haxe.lang.DynamicObject __hx_this) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_hashes = new int[]{};
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_dynamics = new object[]{};
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_hashes_f = new int[]{};
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_dynamics_f = new double[]{};
		}
		#line default
		
		public static void __hx_ctor_haxe_lang_DynamicObject(global::haxe.lang.DynamicObject __hx_this, int[] __hx_hashes, object[] __hx_dynamics, int[] __hx_hashes_f, double[] __hx_dynamics_f) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_hashes = __hx_hashes;
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_dynamics = __hx_dynamics;
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_hashes_f = __hx_hashes_f;
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_dynamics_f = __hx_dynamics_f;
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_length = __hx_hashes.Length;
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_length_f = __hx_hashes_f.Length;
		}
		#line default
		
		public virtual string toString() {
			#line 45 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.Function ts = ((global::haxe.lang.Function) (global::haxe.lang.Runtime.getField(this, "toString", 946786476, false)) );
			if (( ts != null )) {
				#line 47 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return global::haxe.lang.Runtime.toString(ts.__hx_invoke0_o());
			}
			
			#line 43 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			#line 49 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			ret_b.Append(((string) ("{") ));
			bool first = true;
			#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			{
				#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g = 0;
				#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::Array<object> _g1 = global::Reflect.fields(this);
				#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				while (( _g < _g1.length )) {
					#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					string f = global::haxe.lang.Runtime.toString(_g1[_g]);
					#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					 ++ _g;
					#line 53 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					if (first) {
						#line 54 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						first = false;
					}
					else {
						#line 56 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						ret_b.Append(((string) (",") ));
					}
					
					#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					ret_b.Append(((string) (" ") ));
					#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					ret_b.Append(((string) (global::Std.@string(f)) ));
					ret_b.Append(((string) (" : ") ));
					#line 59 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					ret_b.Append(((string) (global::Std.@string(((object) (global::Reflect.field(this, f)) ))) ));
				}
				
			}
			
			#line 61 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if ( ! (first) ) {
				#line 61 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				ret_b.Append(((string) (" ") ));
			}
			
			#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			ret_b.Append(((string) ("}") ));
			return ret_b.ToString();
		}
		#line default
		
		public global::haxe.lang.FieldHashConflict __hx_conflicts;
		
		public int[] __hx_hashes;
		
		public object[] __hx_dynamics;
		
		public int[] __hx_hashes_f;
		
		public double[] __hx_dynamics_f;
		
		public int __hx_length;
		
		public int __hx_length_f;
		
		public override bool __hx_deleteField(string field, int hash) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return global::haxe.lang.FieldLookup.deleteHashConflict(ref this.__hx_conflicts, hash, field);
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( res >= 0 )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.@remove<int>(((int[]) (this.__hx_hashes) ), ((int) (this.__hx_length) ), ((int) (res) ));
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.@remove<object>(((object[]) (this.__hx_dynamics) ), ((int) (this.__hx_length) ), ((int) (res) ));
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				this.__hx_length--;
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return true;
			}
			else {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				if (( res >= 0 )) {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					global::haxe.lang.FieldLookup.@remove<int>(((int[]) (this.__hx_hashes_f) ), ((int) (this.__hx_length_f) ), ((int) (res) ));
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					global::haxe.lang.FieldLookup.@remove<double>(((double[]) (this.__hx_dynamics_f) ), ((int) (this.__hx_length_f) ), ((int) (res) ));
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					this.__hx_length_f--;
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return true;
				}
				
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return false;
		}
		#line default
		
		public override object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldHashConflict conflict = global::haxe.lang.FieldLookup.getHashConflict(this.__hx_conflicts, hash, field);
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				if (( conflict != null )) {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return conflict.@value;
				}
				
			}
			else {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				if (( res >= 0 )) {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_dynamics[res];
				}
				else {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					if (( res >= 0 )) {
						#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						return this.__hx_dynamics_f[res];
					}
					
				}
				
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (isCheck) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			else {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return null;
			}
			
		}
		#line default
		
		public override double __hx_lookupField_f(string field, int hash, bool throwErrors) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldHashConflict conflict = global::haxe.lang.FieldLookup.getHashConflict(this.__hx_conflicts, hash, field);
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				if (( conflict != null )) {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return ((double) (global::haxe.lang.Runtime.toDouble(conflict.@value)) );
				}
				
			}
			else {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				if (( res >= 0 )) {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_dynamics_f[res];
				}
				else {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					if (( res >= 0 )) {
						#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_dynamics[res])) );
					}
					
				}
				
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return default(double);
		}
		#line default
		
		public override object __hx_lookupSetField(string field, int hash, object @value) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.setHashConflict(ref this.__hx_conflicts, hash, field, @value);
			}
			else {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				if (( res >= 0 )) {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_dynamics[res] = @value;
				}
				else {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					int res2 = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					if (( res2 >= 0 )) {
						#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						global::haxe.lang.FieldLookup.@remove<int>(((int[]) (this.__hx_hashes_f) ), ((int) (this.__hx_length_f) ), ((int) (res2) ));
						#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						global::haxe.lang.FieldLookup.@remove<double>(((double[]) (this.__hx_dynamics_f) ), ((int) (this.__hx_length_f) ), ((int) (res2) ));
						#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						this.__hx_length_f--;
					}
					
				}
				
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.insert<int>(ref this.__hx_hashes, ((int) (this.__hx_length) ), ((int) ( ~ (res) ) ), ((int) (hash) ));
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.insert<object>(ref this.__hx_dynamics, ((int) (this.__hx_length) ), ((int) ( ~ (res) ) ), ((object) (@value) ));
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				this.__hx_length++;
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return @value;
		}
		#line default
		
		public override double __hx_lookupSetField_f(string field, int hash, double @value) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.setHashConflict(ref this.__hx_conflicts, hash, field, @value);
			}
			else {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				if (( res >= 0 )) {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_dynamics_f[res] = @value;
				}
				else {
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					int res2 = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					if (( res2 >= 0 )) {
						#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						global::haxe.lang.FieldLookup.@remove<int>(((int[]) (this.__hx_hashes) ), ((int) (this.__hx_length) ), ((int) (res2) ));
						#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						global::haxe.lang.FieldLookup.@remove<object>(((object[]) (this.__hx_dynamics) ), ((int) (this.__hx_length) ), ((int) (res2) ));
						#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						this.__hx_length--;
					}
					
				}
				
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.insert<int>(ref this.__hx_hashes_f, ((int) (this.__hx_length_f) ), ((int) ( ~ (res) ) ), ((int) (hash) ));
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.insert<double>(ref this.__hx_dynamics_f, ((int) (this.__hx_length_f) ), ((int) ( ~ (res) ) ), ((double) (@value) ));
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				this.__hx_length_f++;
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return @value;
		}
		#line default
		
		public override void __hx_getFields(global::Array<object> baseArr) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			int i = default(int);
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			i = 0;
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			while (( i < this.__hx_length )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				baseArr.push(global::haxe.lang.FieldLookup.lookupHash(this.__hx_hashes[i++]));
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			i = 0;
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			while (( i < this.__hx_length_f )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				baseArr.push(global::haxe.lang.FieldLookup.lookupHash(this.__hx_hashes_f[i++]));
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.FieldLookup.addHashConflictNames(this.__hx_conflicts, baseArr);
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public interface IGenericObject : global::haxe.lang.IHxObject {
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class GenericInterface : global::System.Attribute {
		
		public GenericInterface(global::System.Type generic) : base() {
			#line 79 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this.generic = generic;
		}
		#line default
		
		public readonly global::System.Type generic;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Enum {
		
		public Enum(int index) {
			#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this.index = index;
		}
		#line default
		
		public readonly int index;
		
		public virtual string getTag() {
			#line 99 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			throw global::haxe.lang.HaxeException.wrap("Not Implemented");
		}
		#line default
		
		public virtual global::Array<object> getParams() {
			#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return new global::Array<object>(new object[]{});
		}
		#line default
		
		public virtual string toString() {
			#line 109 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return this.getTag();
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class ParamEnum : global::haxe.lang.Enum {
		
		public ParamEnum(int index, object[] @params) : base(index) {
			#line 121 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this.@params = @params;
		}
		#line default
		
		public readonly object[] @params;
		
		public override global::Array<object> getParams() {
			#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( this.@params == null )) {
				#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return new global::Array<object>(new object[]{});
			}
			else {
				#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return new global::Array<object>(((object[]) (this.@params) ));
			}
			
		}
		#line default
		
		public override string toString() {
			#line 131 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( ( this.@params == null ) || ( ( ((object[]) (this.@params) ) as global::System.Array ).Length == 0 ) )) {
				#line 131 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return this.getTag();
			}
			
			#line 129 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			#line 133 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			ret_b.Append(((string) (global::Std.@string(this.getTag())) ));
			#line 133 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			ret_b.Append(((string) ("(") ));
			bool first = true;
			#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			{
				#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g = 0;
				#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				object[] _g1 = this.@params;
				#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				while (( _g < ( ((object[]) (_g1) ) as global::System.Array ).Length )) {
					#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					object p = ((object) (((object[]) (_g1) )[_g]) );
					#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					 ++ _g;
					#line 137 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					if (first) {
						#line 138 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						first = false;
					}
					else {
						#line 140 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						ret_b.Append(((string) (",") ));
					}
					
					#line 141 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					ret_b.Append(((string) (global::Std.@string(((object) (p) ))) ));
				}
				
			}
			
			#line 143 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			ret_b.Append(((string) (")") ));
			return ret_b.ToString();
		}
		#line default
		
		public override bool Equals(object obj) {
			#line 149 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (global::haxe.lang.Runtime.eq(obj, this)) {
				#line 150 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return true;
			}
			
			#line 151 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.ParamEnum obj1 = ((global::haxe.lang.ParamEnum) (( ((object) (obj) ) as global::haxe.lang.ParamEnum )) );
			#line 153 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if ( ! ((( ( ( obj1 != null ) && global::Std.@is(obj1, global::Type.getClass<object>(((object) (this) ))) ) && ( obj1.index == this.index ) ))) ) {
				#line 154 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return false;
			}
			
			#line 155 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( obj1.@params == this.@params )) {
				#line 156 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return true;
			}
			
			#line 157 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			int len = 0;
			bool tmp = default(bool);
			if ( ! ((( ( obj1.@params == null ) || ( this.@params == null ) ))) ) {
				#line 158 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				len = ( ((object[]) (this.@params) ) as global::System.Array ).Length;
				#line 158 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				tmp = ( len != ( ((object[]) (obj1.@params) ) as global::System.Array ).Length );
			}
			else {
				#line 158 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				tmp = true;
			}
			
			#line 158 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (tmp) {
				#line 159 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return false;
			}
			
			#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			{
				#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g1 = 0;
				#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g = len;
				#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				while (( _g1 < _g )) {
					#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					int i = _g1++;
					#line 162 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					if ( ! (global::Type.enumEq<object>(((object) (((object[]) (obj1.@params) )[i]) ), ((object) (((object[]) (this.@params) )[i]) ))) ) {
						#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						return false;
					}
					
				}
				
			}
			
			#line 165 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return true;
		}
		#line default
		
		public override int GetHashCode() {
			unchecked {
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int h = 19;
				if (( this.@params != null )) {
					#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					int _g = 0;
					#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					object[] _g1 = this.@params;
					#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					while (( _g < ( ((object[]) (_g1) ) as global::System.Array ).Length )) {
						#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						object p = ((object) (((object[]) (_g1) )[_g]) );
						#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						 ++ _g;
						#line 173 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						h *= 31;
						if (( p != null )) {
							#line 175 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
							h += ((int) (global::haxe.lang.Runtime.toInt(p.GetHashCode())) );
						}
						
					}
					
				}
				
				#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				h += this.index;
				return h;
			}
			#line default
		}
		
		
	}
}


