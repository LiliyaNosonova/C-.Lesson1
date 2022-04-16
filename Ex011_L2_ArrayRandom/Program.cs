// Метод void не возвращает значения
void FillArray(int[] collection)// метод, который задает элементы массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);//обращаемся к переменной collection
                            // и кладем в нее новое случайное число из диапазона (1, 10)
        index++;
    }

}

void PrintArray(int[] col)// метод, который печатает массив. 
//В качестве аргумента метода приходит массив col
{
    int count = col.Length;// длина массива
    int position = 0;// позиция начального элемента массива
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

//Адаптируем решение задачи Ex010 с использованием этих методов
//Нужно использовать метод отличный от void,
// который будет возвращать, в данной задаче позицию, т.е. индекс элемнта массива

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//Искуственный прием обозначения отсутсвующего элемента в массиве

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];//Определили массив из 10-ти элементов

FillArray(array);//Этот метод рандомно заполнил массив
PrintArray(array);// Этот метод заполнил массив
System.Console.WriteLine();

int pos = IndexOff(array, 244);
System.Console.WriteLine(pos);