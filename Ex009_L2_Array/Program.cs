int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result;
}
//Индексы элементов массива  
//             0  1  2  3  4  5  6  7  8
int[] array = {11,211,31,44,15,61,17,18,19};
//array[0] = 12;
//System.Console.WriteLine(array[4]);


//int a1 = 15;
//int b1 = 21222;
//int c1 = 39;

//int a2 = 12;
//int b2 = 2311;
//int c2 = 33;

//int a3 = 13;
//int b3 = 23;
//int c3 = 313;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

//код определения max из Ex8
//int max = Max(
 //   Max(a1, b1, c1), 
  //  Max(a2, b2, c2), 
  //  Max(a3, b3, c3));

  //Меняем код на определение max через каждый элемент массива
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));



Console.WriteLine(max);


