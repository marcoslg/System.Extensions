# System.Extensions


| NameSpace  | Type | Function/method| return | Descripción  |
|-------------|-----|------|:-----:|------|
| System.Collections.Generic.Extensions | IDictionary<string, string> |  GetValueSecure(string key) | string | Gets the value securely. If not EXISTS Key => return string.Empty | 
| System.Collections.Extensions | IEnumerable\<T> | IsNullOrEmpty() | bool | Indicates whether the specified enumerable is null or an empty sequence. | 
| System.Collections.Extensions | IEnumerable\<T> | ForEach(Action\<T> action) | IEnumerable\<T> | It's fluent api. Invokes an action for every item of the enumerable.  | 
| System.Collections.Extensions | IEnumerable | ForEach(Action\<T> action) | IEnumerable\<T> | It's fluent api. Casts the enumerable to the specified type and invokes an action for every item of the enumerable.  | 
| System.Collections.Extensions | IEnumerable\<T> | ForEach(Func\<T, TResult> func) | IEnumerable\<T> | Shortcut for foreach and create new list. func => map function | 
| System.Extensions | string | ToUpperFirstCharForEveryWord( char separator = ' ') | string | Transforms the string by upper-casing the first character of each word and lower-casing the rest, separated by the specified separator.| 
| System.Extensions | string | ToUpperFirstCharacter() | string | Transforms the string by upper-casing the first character and/ the lower-casing the rest.| 
| System.Extensions | string | ToTryDouble() | double? | Parses securely the string to a nullable double. If it's valid returns the string converted to a nullable double, otherwise null.| 
| System.Extensions | string | GetValueOrNull\<T>() | T? : struct | Parses securely the string to the specified generic type. | 
| System.Extensions | string | RemoveDiacritics() | string | Removes all the diacritics from the specified text.| 
| System.Extensions | string | IsNullOrEmpty() | bool | Indicates whether the specified string is null or an empty string.| 
| System.Extensions | Func\<Task\<TResult>> | RunSync\<TResult>() | TResult(generic) | Run function task on sync and return result. | 
| System.Extensions | Func\<Task> | RunSync() | -- | Run method task on sync. | 
| System.Extensions.Guard | T(generic type) | NotNull() | T | Return T or IF null throw ArgumentNullException | 
| System.Extensions.Guard | string | NotNull() | string | Return string or IF null throw ArgumentNullException | 