// Generated by Haxe 3.4.0

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public sealed class FieldHashConflict {
		
		public FieldHashConflict(int hash, string name, object @value, global::haxe.lang.FieldHashConflict next) {
			this.hash = hash;
			this.name = name;
			this.@value = @value;
			this.next = next;
		}
		
		
		public readonly int hash;
		
		public readonly string name;
		
		public object @value;
		
		public global::haxe.lang.FieldHashConflict next;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public sealed class FieldLookup {
		
		#pragma warning disable 628
		static FieldLookup() {
			global::haxe.lang.FieldLookup.length = ( global::haxe.lang.FieldLookup.fieldIds as global::System.Array ).Length;
		}
		
		
		public FieldLookup() {
		}
		
		
		protected static int[] fieldIds = new int[]{105, 4745537, 4849249, 5393365, 5442204, 5594513, 57476627, 76061764, 87367608, 302979532, 328878574, 359333139, 407283053, 452737314, 501039929, 520590566, 946786476, 1067353468, 1103412149, 1181037546, 1204816148, 1224901875, 1228056441, 1247875546, 1280845662, 1282943179, 1352786672, 1398464674, 1431819701, 1436822557, 1532710347, 1547539107, 1620824029, 1621420777, 1623148745, 1648581351, 1705629508, 1768617329, 1830310359, 1915412854, 1916009602, 1981972957, 2025055113, 2054707467, 2082663554, 2127021138};
		
		protected static string[] fields = new string[]{"i", "__a", "arr", "len", "map", "pop", "getEnumConstructs", "remove", "filter", "methodName", "iterator", "lastIndexOf", "hasNext", "reverse", "insert", "length", "toString", "splice", "copy", "join", "concat", "next", "enumConstructor", "push", "sort", "quicksort", "spliceVoid", "getEnumName", "createEnumIndex", "createEnum", "concatNative", "className", "__unsafe_get", "__unsafe_set", "indexOf", "fileName", "toDynamic", "allEnums", "customParams", "__get", "__set", "lineNumber", "unshift", "enumParameters", "shift", "slice"};
		
		protected static int length;
		
		public static void addFields(int[] nids, string[] nfields) {
			unchecked {
				int[] cids = global::haxe.lang.FieldLookup.fieldIds;
				string[] cfields = global::haxe.lang.FieldLookup.fields;
				int nlen = ( nids as global::System.Array ).Length;
				int clen = global::haxe.lang.FieldLookup.length;
				if (( ( nfields as global::System.Array ).Length != nlen )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Different fields length: ", global::haxe.lang.Runtime.toString(nlen)), " and "), global::haxe.lang.Runtime.toString(( nfields as global::System.Array ).Length)));
				}
				
				bool needsChange = false;
				{
					int[] _g_arr = nids;
					uint _g_idx = ((uint) (0) );
					while (((bool) (( _g_idx < ( _g_arr as global::System.Array ).Length )) )) {
						if (( global::haxe.lang.FieldLookup.findHash(((int) (_g_arr[((int) (_g_idx++) )]) ), cids, clen) < 0 )) {
							needsChange = true;
							break;
						}
						
					}
					
				}
				
				if (needsChange) {
					lock(typeof(global::haxe.lang.FieldLookup)){
						int[] ansIds = new int[( clen + nlen )];
						string[] ansFields = new string[( clen + nlen )];
						int ci = 0;
						int ni = 0;
						int ansi = 0;
						while (true) {
							if ( ! ((( (( ci < clen )) ? (( ni < nlen )) : (false) ))) ) {
								break;
							}
							
							if (( cids[ci] < nids[ni] )) {
								ansIds[ansi] = cids[ci];
								ansFields[ansi] = cfields[ci];
								ci = ( ci + 1 );
							}
							else {
								ansIds[ansi] = nids[ni];
								ansFields[ansi] = nfields[ni];
								ni = ( ni + 1 );
							}
							
							ansi = ( ansi + 1 );
						}
						
						if (( ci < clen )) {
							global::System.Array.Copy(((global::System.Array) (cids) ), ((int) (ci) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
							global::System.Array.Copy(((global::System.Array) (cfields) ), ((int) (ci) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
							ansi = ( ansi + (( clen - ci )) );
						}
						
						if (( ni < nlen )) {
							global::System.Array.Copy(((global::System.Array) (nids) ), ((int) (ni) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
							global::System.Array.Copy(((global::System.Array) (nfields) ), ((int) (ni) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
							ansi = ( ansi + (( nlen - ni )) );
						}
						
						global::haxe.lang.FieldLookup.fieldIds = ansIds;
						global::haxe.lang.FieldLookup.fields = ansFields;
						global::haxe.lang.FieldLookup.length = ansi;
					}
					;
				}
				
			}
		}
		
		
		public static int doHash(string s) {
			unchecked {
				int acc = 0;
				{
					int _g1 = 0;
					int _g = s.Length;
					while (( _g1 < _g )) {
						acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[_g1++]) ) ) << 1 );
					}
					
				}
				
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
		}
		
		
		public static string lookupHash(int key) {
			unchecked {
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = global::haxe.lang.FieldLookup.length;
				while (( min < max )) {
					int mid = ( min + ( (( max - min )) / 2 ) );
					int imid = ids[mid];
					if (( key < imid )) {
						max = mid;
					}
					else if (( key > imid )) {
						min = ( mid + 1 );
					}
					else {
						return global::haxe.lang.FieldLookup.fields[mid];
					}
					
				}
				
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat("Field not found for hash ", global::haxe.lang.Runtime.toString(key)));
			}
		}
		
		
		public static int hash(string s) {
			unchecked {
				if (string.Equals(s, null)) {
					return 0;
				}
				
				int acc = 0;
				{
					int _g1 = 0;
					int _g = s.Length;
					while (( _g1 < _g )) {
						acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[_g1++]) ) ) << 1 );
					}
					
				}
				
				int key = ((int) (( ((uint) (acc) ) >> 1 )) );
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				string[] fld = global::haxe.lang.FieldLookup.fields;
				int min = 0;
				int max = global::haxe.lang.FieldLookup.length;
				int len = global::haxe.lang.FieldLookup.length;
				while (( min < max )) {
					int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
					int imid = ids[mid];
					if (( key < imid )) {
						max = mid;
					}
					else if (( key > imid )) {
						min = ( mid + 1 );
					}
					else {
						if ( ! (string.Equals(fld[mid], s)) ) {
							return  ~ (key) ;
						}
						
						return key;
					}
					
				}
				
				lock(typeof(global::haxe.lang.FieldLookup)){
					if (( len != global::haxe.lang.FieldLookup.length )) {
						return global::haxe.lang.FieldLookup.hash(s);
					}
					
					global::haxe.lang.FieldLookup.insert<int>(ref global::haxe.lang.FieldLookup.fieldIds, ((int) (global::haxe.lang.FieldLookup.length) ), ((int) (min) ), ((int) (key) ));
					global::haxe.lang.FieldLookup.insert<string>(ref global::haxe.lang.FieldLookup.fields, ((int) (global::haxe.lang.FieldLookup.length) ), ((int) (min) ), ((string) (s) ));
					 ++ global::haxe.lang.FieldLookup.length;
				}
				;
				return key;
			}
		}
		
		
		public static int findHash(int hash, int[] hashs, int length) {
			unchecked {
				int min = 0;
				int max = length;
				while (( min < max )) {
					int mid = ( (( max + min )) / 2 );
					int imid = hashs[mid];
					if (( hash < imid )) {
						max = mid;
					}
					else if (( hash > imid )) {
						min = ( mid + 1 );
					}
					else {
						return mid;
					}
					
				}
				
				return  ~ (min) ;
			}
		}
		
		
		public static void @remove<T>(T[] a, int length, int pos) {
			unchecked {
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = default(T);
			}
		}
		
		
		public static void insert<T>(ref T[] a, int length, int pos, T x) {
			unchecked {
				int capacity = ( a as global::System.Array ).Length;
				if (( pos == length )) {
					if (( capacity == length )) {
						T[] newarr = new T[( (( length << 1 )) + 1 )];
						( a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						a = ((T[]) (newarr) );
					}
					
				}
				else if (( pos == 0 )) {
					if (( capacity == length )) {
						T[] newarr1 = new T[( (( length << 1 )) + 1 )];
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						a = ((T[]) (newarr1) );
					}
					else {
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					T[] newarr2 = new T[( (( length << 1 )) + 1 )];
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					a = ((T[]) (newarr2) );
				}
				else {
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (pos) ));
				}
				
				a[pos] = x;
			}
		}
		
		
		public static global::haxe.lang.FieldHashConflict getHashConflict(global::haxe.lang.FieldHashConflict head, int hash, string name) {
			while (( head != null )) {
				if (( ( head.hash == hash ) && string.Equals(head.name, name) )) {
					return head;
				}
				
				head = head.next;
			}
			
			return null;
		}
		
		
		public static void setHashConflict(ref global::haxe.lang.FieldHashConflict head, int hash, string name, object @value) {
			global::haxe.lang.FieldHashConflict node = head;
			while (( node != null )) {
				if (( ( node.hash == hash ) && string.Equals(node.name, name) )) {
					node.@value = @value;
					return;
				}
				
				node = ((global::haxe.lang.FieldHashConflict) (node.next) );
			}
			
			head = ((global::haxe.lang.FieldHashConflict) (new global::haxe.lang.FieldHashConflict(hash, name, @value, ((global::haxe.lang.FieldHashConflict) (head) ))) );
		}
		
		
		public static bool deleteHashConflict(ref global::haxe.lang.FieldHashConflict head, int hash, string name) {
			if (( head == null )) {
				return false;
			}
			
			if (( ( head.hash == hash ) && string.Equals(head.name, name) )) {
				head = ((global::haxe.lang.FieldHashConflict) (head.next) );
				return true;
			}
			
			global::haxe.lang.FieldHashConflict prev = head;
			global::haxe.lang.FieldHashConflict node = head.next;
			while (( node != null )) {
				if (( ( node.hash == hash ) && string.Equals(node.name, name) )) {
					prev.next = node.next;
					return true;
				}
				
				node = node.next;
			}
			
			return false;
		}
		
		
		public static void addHashConflictNames(global::haxe.lang.FieldHashConflict head, global::Array<object> arr) {
			while (( head != null )) {
				arr.push(head.name);
				head = head.next;
			}
			
		}
		
		
	}
}


