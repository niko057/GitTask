﻿

//Tapşırıq: 2 array verilmişdir, 2ci arraydəki bütün elementlər həm də 1cidə varsa , true əks halda false çap olunsun.

int[] arr1 = { 211, 9, -6, 12, 34, 56, 32, 5, 19 };

int[] arr2 = { 211,9,-6, };

       bool check = false;



for (int i = 0; i < arr2.Length; i++)
{
    check = false;

    for (int j = 0; j < arr1.Length; j++)
    {
        if (arr2[i] == arr1[j])

        {
            check = true;
            break;
           
        }
       
       
    }
    if (check == false)
    {
        check= false;
        break;
    }
}
Console.WriteLine(check);

