int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 1;
int a2 = 7;
int a3 = 4;
int a4 = 79;
int a5 = 6;
int a6 = 65;
int a7 = 19;
int a8 = 187;
int a9 = 14;

int max1 = Max(a1,a2,a3);
Console.WriteLine (max1);
int max2 = Max(a4,a5,a6);
Console.WriteLine (max2);
int max3 = Max(a7,a8,a9);
Console.WriteLine (max3);
int max4 = Max(max1,max2,max3);
Console.WriteLine (max4);