//int[] vektorA = { 52, 73, 24, 65, 83, 17, 35, 92, 41, 9 }; //soal nomer 4 out of bounds
//int nVar = 10;
//int yVar = 5;
//int xVar = 11;
//while (nVar >= yVar)
//{
//    while (nVar > yVar)
//    {
//        vektorA[nVar + 1] =vektorA[nVar];
//        nVar--;
//    }
//    vektorA[yVar + 1] = vektorA[nVar];
//    nVar--;
//}
//vektorA[nVar + 1] = vektorA[2 * (nVar + 1) + 1] * xVar;
//Console.Write(vektorA);

//int[] urutAngka = { 2, 6, 4, 5, -100, -5, 10 }; //bubble sort
//int counter = 0;
//for (int i = 0; i < urutAngka.Length - 1; i++)
//    for (int j = 0; j < urutAngka.Length - 1 - i; j++)
//        if (urutAngka[j] < urutAngka[j + 1])
//        {
//            counter = urutAngka[j];
//            urutAngka[j] = urutAngka[j + 1];
//            urutAngka[j + 1] = counter;
//        }
//Console.WriteLine("Bubble Sorted : ");
//foreach (int cetakHasil in urutAngka)
//    Console.Write($"{cetakHasil} ");

int[] urutAngka = { 2, 6, 4, 5, -100, -5, 10 }; //straight selection sort
Array.Sort(urutAngka);
Array.Reverse(urutAngka);
Console.Write("Hasil sort : ");
foreach (int i in urutAngka)
    Console.Write($"{i} ");