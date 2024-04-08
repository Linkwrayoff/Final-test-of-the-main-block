string[] arr = { "Hello", "2", "world", ":-)" };
int j = 0;
 
for(int index = 0; index < arr.Length; index++){
	if(arr[index].Length <= 3){
		j++;
	}
} 

string [] arr2 = new string[j] ;
j = 0;
for(int index = 0; index < arr.Length; index++){
	if(arr[index].Length <= 3){
		arr2[j] = arr[index];
		j++;
	}
} 
Console.WriteLine(string.Join(", ", arr2));
