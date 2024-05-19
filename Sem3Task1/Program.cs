// int [] array = new int [5];
// int [] array2 = new int [5] {3,5,6,8,4};
// int [] array3 = new int [] {3,5,6,8,4};

int[] array = {1,3,4,19,3};
int num = 8;
bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] == num)
    {
       isExistNum = true; 
        break;
    }
    
}
// string result = isExistNum == isExistNum ? "Да" : "Нет";
Console.WriteLine(isExistNum ? "Да" : "Нет");