internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[10];                          //10 adet tamsayı verisi alacak dizi tanımlandı
        int[] newArray = new int[array.Length +1];          //11. eleman eklenirken yeni bir diziye ihtiyaç olacak

        for (int i = 0; i <array.Length; i++)       //dizi elemanlarına değer atandı
        {
            array[i] = i;
       
        }
        foreach (int i in array)                    //atanan değerler ekrana yazıldı
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("Diziye eklemek için yeni bir tamsayı giriniz");
        int yeni = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)       //eski dizidekileri yeni diziye atandı
        {
            newArray[i] = array[i];
        }
        Console.WriteLine("---------------");
        newArray[newArray.Length -1] = yeni;



        

        for (int i =0; i < newArray.Length-1; i++)                  //for i den newarrayın sonuncu elemanına kadar dönecek
        {
            int max = i;                                        

            for (int j = i + 1; j < newArray.Length; j++)
            {
                if (newArray[j] > newArray[max])
                {
                    max = j;
                }
            }
            if (max != i)            // Eğer en büyük eleman bulunduysa, yer değiştir
            {
                int temp = newArray[i];
                newArray[i] = newArray[max];
                newArray[max] = temp;
            }
        }

        array = newArray;       //yeni dizideki elemanlar normal dizimize atanıyor ve ekrana büyükten küçüğe sıralanmış hali yazdırılır
        foreach (int i in array)
        {
            Console.WriteLine(i);  
        }

       


    }
}