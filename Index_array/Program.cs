
int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;

int fing = 18;

int index = 0;

while (index < n)
{
    if(array[index] == fing)
    {
        Console.WriteLine(index);
        //break;
    }
    //index = index +1;
    index++;
}