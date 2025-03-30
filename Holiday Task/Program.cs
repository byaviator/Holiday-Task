using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Holiday_Task;

internal class Program
{
    static void Main(string[] args)
    {

        
    }

    static void Task1()
    //iki ədəd dəyişən yaradın və onların cəmini ekranda çap edən proqramı yazın.
    {
        int a = 5;
        int b = 10;
        int c = a + b;
        Console.WriteLine($"cəmi: {c}");
    }
    static void Task2()
    //Bir dəyişəndə saxlanan ədədin kvadratını(özünə vurulmasını) ekranda çap edən proqramı yazın.
    {
        int a = 7;
        int b = a * a;
        Console.WriteLine($"Kvadrat: {b}");
    }
    static void Task3()
    //Adınızı və yaşınızı ayrı dəyişənlərdə saxlayın, sonra bunları aşağıdakı kimi çap edən proqramı yazın:
    //Salam, mənim adım Boss-dur və mənim 222 yaşım var.
    {
        string name = "Abdullah";
        int age = 20;
        Console.WriteLine($"Salam, menim adim {name} -dir ve menim {age} yasim var.");
    }
    static void Task4()
    //İki dəyişəndə saxlanılan ədədlərin dəyərlərinin yerini dəyişin və ekrana aşağıdaki kimi çap edən proqramı yazın(Üçüncü dəyişəndən əlavə etmək olar):
    //a dəyişəninin əvvəlki dəyəri 10, yer dəyişmədən sonra 20 - dir.
    //b dəyişəninin əvvəlki dəyəri 20, yer dəyişmədən sonra 10 - dur.
    {
        int a = 10;
        int b = 20;
        Console.WriteLine($"a dəyişəninin əvvəlki dəyəri {a},b dəyişəninin əvvəlki dəyəri {b}");
        int c = a;
        a = b;
        b = c;
        Console.WriteLine($"a dəyişəninin yer dəyişmədən sonra {a} - dir,b dəyişəninin yer dəyişmədən sonra {c} - dur");
    }

    static void Task5()
    //Daxil edilən üç tam ədədin cəmi və ədədi ortasını hesablayıb çap edən proqramı yazın.
    {
        Console.WriteLine("Birinci ədədi daxil edin:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci ədədi daxil edin:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Üçüncü ədədi daxil edin:");
        int c = Convert.ToInt32(Console.ReadLine());
        int sum = a + b + c;
        double average = sum / 3;
        Console.WriteLine($"Cəmi: {sum},Ededi Orta: {average}");
    }
    static void Task6()
    //İstifadəçidən alınan ədədin rəqəmlərinin cəmini hesablayıb çap edən proqramı yazın.
    {
        Console.WriteLine("Dördrəqəmli ədəd daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine($"Daxil edilən ədədin rəqəmlərinin cəmi: {sum}");
    }
    static void Task7()
    // istifadəçidən alınan ədədin cüt və ya tək olduğunu yoxlayan və çap edən proqramı yazın.
    {
        Console.WriteLine("Ədəd daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Cüt ədəddir");
        }
        else
        {
            Console.WriteLine("Tək ədəddir");
        }

    }
    static void Task8()
    // İstifadəçinin daxil etdiyi iki ədədi müqayisə edib, hansı ədədin böyük olduğunu çap edən proqram yazın.
    {
        Console.WriteLine("Birinci ədədi daxil edin:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci ədədi daxil edin:");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("Birinci ədəd böyükdür");
        }
        else
        {
            Console.WriteLine("İkinci ədəd böyükdür");
        }

    }
    static void Task9()
    //İstifadəçinin daxil etdiyi ədədin müsbət, mənfi və ya sıfır olduğunu yoxlayan və çap edən proqramı yazın.
    {
        Console.WriteLine("Ədəd daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("Müsbət ədəddir");
        }
        else if (number < 0)
        {
            Console.WriteLine("Mənfi ədəddir");
        }
        else if (number == 0)
        {
            Console.WriteLine("Sıfırdır");
        }
    }
    static void Task10()
    //İstifadəçidən alınan ədədin həm 3-ə həm də 5-ə bölünüb-bölünmədiyini yoxlayan və çap edən proqramı yazın.
    {
        Console.WriteLine("ədəd daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine($"{number} 3-ə və 5-ə bölünür ");
        }
        else
        {
            Console.WriteLine($"{number} 3-ə və 5-ə bölünmür");
        }

    }
    static void Task11()
    //İstifadəçinin daxil etdiyi ədədin 2 - yə və ya 3 - ə eyni zamanda bölünə bildiyini yoxlayan və çap edən proqramı yazın.
    {
        Console.WriteLine("Ədəd daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0 && number % 3 == 0)
        {
            Console.WriteLine($"{number} 2 - yə və 3 - ə bölünür ");
        }
        else
        {
            Console.WriteLine($"{number} 2 - yə və 3 - ə bölünmür");
        }
    }
    static void Task12()
    //İstifadəçi ayın nömrəsini daxil edir(1 - 12 arasında).Proqram həmin ayın adını ekrana yazdıran proqramı yazın.(switch-case istifadə edin)

    {
        Console.WriteLine("Ayın nömrəsini daxil edin:");
        int month = Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
            case 1:
                Console.WriteLine("Yanvar");
                break;
            case 2:
                Console.WriteLine("Fevral");
                break;
            case 3:
                Console.WriteLine("Mart");
                break;
            case 4:
                Console.WriteLine("Aprel");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("İyun");
                break;
            case 7:
                Console.WriteLine("İyul");
                break;
            case 8:
                Console.WriteLine("Avqust");
                break;
            case 9:
                Console.WriteLine("Sentyabr");
                break;
            case 10:
                Console.WriteLine("Oktyabr");
                break;
            case 11:
                Console.WriteLine("Noyabr");
                break;
            case 12:
                Console.WriteLine("Dekabr");
                break;
            default:
                Console.WriteLine("Xahiş edirəm, 1-dən 12-ə qədər bir nömrə daxil edin.");
                break;
        }

    }
    static void Task13()
    //İstifadəçi daxil etdiyi bal əsasında qiymət çap edən proqramı yazın.(istənilən bal sistemi){
    {
        Console.WriteLine($"Bali daxil edin :");
        int bal = Convert.ToInt32(Console.ReadLine());
        if (bal >= 91 && bal <= 100)
        {
            Console.WriteLine("A");
        }
        else if (bal >= 81 && bal <= 90)
        {
            Console.WriteLine("B");
        }
        else if (bal >= 71 && bal <= 80)
        {
            Console.WriteLine("C");
        }
        else if (bal >= 61 && bal <= 70)
        {
            Console.WriteLine("D");
        }
        else if (bal >= 51 && bal <= 60)
        {
            Console.WriteLine("E");
        }
        else if (bal >= 0 && bal <= 50)
        {
            Console.WriteLine("F");
        }
        else
        {
            Console.WriteLine("0-dan 100-ə qədər bir nömrə daxil edin.");
        }




    }
    static void Task14()
    //İstifadəçi iki ədəd və bir əməliyyat işarəsi daxil edir. Nəticəni hesablayan və çap edən proqramı yazın. (+, -, *, /)
    {
        Console.WriteLine("Birinci ədədi daxil edin:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci ədədi daxil edin:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Əməliyyat işarəsini daxil edin:");
        string operation = Console.ReadLine();


        switch (operation)
        {
            case "+":
                Console.WriteLine($"Cavab: {a + b}");
                break;
            case "-":
                Console.WriteLine($"Cavab: {a - b}");
                break;
            case "*":
                Console.WriteLine($"Cavab: {a * b}");
                break;
            case "/":
                Console.WriteLine($"Cavab: {a / b}");
                break;
            default:
                Console.WriteLine("Yalnız +, -, *, / əməliyyat işarələrindən birini daxil edin.");
                break;
        }

    }

    static void Task15()
    //İstifadəçinin daxil etdiyi məbləğə əsasən endirim edən və aşağıdaki şəkildə nəticəni çap edən proqramı yazın.
    //Məbləğ 100 AZN və ya daha çoxdursa, 10% endirim.
    //Məbləğ 50-99 AZN arasında olsa, 5% endirim.
    //Məbləğ 50 AZN-dən aşağıdırsa, endirim yoxdur.
    //Endirimli qiymət: Alınan məhsulun dəyəri 120 AZN.Ödəyəcəyiniz məbləğ 108 AZN(10% endirim tətbiq edildi)
    {
        Console.WriteLine($"Məbləği daxil edin :");
        double mebleg = Convert.ToDouble(Console.ReadLine());
        double endirim = 0;
        if (mebleg >= 100)
        {
            endirim = mebleg * 0.1;
            Console.WriteLine($"Endirimli qiymət: Alınan məhsulun dəyəri {mebleg} AZN.Ödəyəcəyiniz məbləğ {mebleg - endirim} AZN({endirim} AZN endirim tətbiq edildi)");
        }
        else if (mebleg >= 50 && mebleg <= 99)
        {
            endirim = mebleg * 0.05;
            Console.WriteLine($"Endirimli qiymət: Alınan məhsulun dəyəri {mebleg} AZN.Ödəyəcəyiniz məbləğ {mebleg - endirim} AZN({endirim} AZN endirim tətbiq edildi)");
        }
        else if (mebleg < 50)
        {
            endirim = 0;
            Console.WriteLine($"Ödəyəcəyiniz məbləğ {mebleg} AZN({endirim} AZN endirim,50 AZN - den az alis veris etdiyiniz ucun endirim  tətbiq edilmedi)");
        }
    }
    static void Task16()
    //İstifadəçi adını və şifrəsini daxil edir. Əvvəldən təyin olunmuş istifadəçi adı və şifrəyə uyğun olarsa girişə icazə verən və nəticəni çap edən proqramı yazın.
    //Qeyd: əvvəlcədən istifadəçi adı "admin", şifrə "2222" olsun.
    {
        Console.WriteLine("İstifadəçi adını daxil edin:");
        string username = Console.ReadLine();

        Console.WriteLine("Şifrəni daxil edin:");
        int password = Convert.ToInt32(Console.ReadLine());

        if (username == "admin" && password == 2222)
        {
            Console.WriteLine("Giriş uğurludur");
        }
        else
        {
            Console.WriteLine("İstifadəçi adı və ya şifrə yalnışdır");
        }

    }
    static void Task17()
    //AZN-dən USD və ya USD-dən AZN-ə məzənnə çevrilməsi həyata keçirən və nəticəni çap edən proqram yazın. (sabit məzənnə təyin edin).
    {
        Console.WriteLine($"Meblegi daxil edin");
        double mebleg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("AZN-dən USD-ə çevirmək üçün USD, USD-dən AZN-ə çevirmək üçün AZN daxil edin:");
        string operation = Console.ReadLine();
        double m = 1.70;
        double u = 0.58824;
        if (operation == "USD")
        {
            Console.WriteLine($"{mebleg} AZN = {mebleg * u} USD");
        }
        else if (operation == "AZN")
        {
            Console.WriteLine($"{mebleg} USD = {mebleg * m} AZN");
        }
        else
        {
            Console.WriteLine("Yalnız AZN və ya USD daxil edin");
        }

    }
    static void Task18()
    //İstifadəçinin boyunu (metr ilə) və çəkisini (kg ilə) alıb BMI (Body Mass Index) hesablayın
    //və nəticəyə uyğun olaraq aşağıdakı mesajlardan birini çap edən proqramı 
    {
        Console.WriteLine($"Boyunuzu daxil edin sm :");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Çəkinizi daxil edin kg :");
        double weight = Convert.ToDouble(Console.ReadLine());
        double bmi = weight / (height * height);
        Console.WriteLine($"Sizin BMI indexiniz {bmi}");
        if (bmi < 18.5)
        {
            Console.WriteLine($"Çəki azlığı");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine($"Normal çəki");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine($"Artıq çəki");
        }
        else if (bmi >= 30)
        {
            Console.WriteLine($"Piylənmə");
        }

    }
    static void Task19()
    //Aşağıdaki funksionallıqlara sahib olan ATM proqramı yazılsın.
    //İstifadəçinin ilkin balansı müəyyən edilsin.
    //İstifadəçi balansı yoxlaya bilsin, vəsait əlavə edə bilsin, pul çıxara bilsin.
    //(məbləğ mənfi olmamalı, çıxarılan məbləğ balansdan çox olmamalıdır və s.yoxlamalar aparın).
    {
        double balance = 100;
        Console.WriteLine("1 - Balansı yoxla");
        Console.WriteLine("2 - Vəsait əlavə et");
        Console.WriteLine("3 - Pul çıxar");
        Console.WriteLine("Seçiminizi daxil edin:");
        int operation = Convert.ToInt32(Console.ReadLine());
        switch (operation)
        {
            case 1:
                Console.WriteLine($"Balansınız: {balance}");
                break;
            case 2:
                Console.WriteLine("Vəsaiti daxil edin:");
                double amount = Convert.ToDouble(Console.ReadLine());
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Balansınız: {balance}");
                }
                else
                {
                    Console.WriteLine("Məbləğ sıfırdan böyük olmalıdır");
                }
                break;
            case 3:
                Console.WriteLine("Çıxarılacaq məbləği daxil edin:");
                double amount1 = Convert.ToDouble(Console.ReadLine());
                if (amount1 > 0 && amount1 <= balance)
                {
                    balance -= amount1;
                    Console.WriteLine($"Balansınız: {balance}");
                }
                else
                {
                    Console.WriteLine("Məbləğ sıfırdan böyük və balansdan çox olmamalıdır");
                }
                break;
            default:
                Console.WriteLine("Yalnız 1, 2 və 3 əməliyyatlarından birini seçin");
                break;

        }
    }
    static void Task20()
    //Yaratmış olduğunuz massivin elementlərini ekrana çap edən proqram yazın.
    {
        int[] massive = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < massive.Length; i++)
        {
            Console.WriteLine(massive[i]);
        }
    }
    static void Task21()
    //Yaratmış olduğunuz massivin bütün elementlərin cəmini hesablayıb nəticəni çap edən proqramı yazın.
    {
        int[] massive = { 4, 1, 3, 8, 5 };
        int sum = 0;
        for (int i = 0; i < massive.Length; i++)
        {
            sum += massive[i];
        }
        Console.WriteLine(sum);

    }

    static void Task22()
    //Yaratmış olduğunuz integer massivdə olan elementlərin ortalamasını hesablayıb nəticəni çap edən proqramı yazın.
    {
        int[] massive = { 7, 2, 6, 8, 3 };
        double sum = 0;
        for (int i = 0; i < massive.Length; i++)
        {
            sum += massive[i];
        }
        double average = sum / massive.Length;
        Console.WriteLine(average);
    }
    static void Task23()
    //Yaratmış olduğunuz integer massivdə olan ən böyük və ən kiçik elementləri index-i ilə birgə çap edən proqramı yazın.
    {
        int[] massive = { 5, 9, 6, 1, 7};
        int max = massive[0];
        int min = massive[0];
        int maxIndex = 0;
        int minIndex = 0;
        for (int i = 0; i < massive.Length; i++)
        {
            if (massive[i] > max)
            {
                max = massive[i];
                maxIndex = i;               
            }
            if (massive[i] < min)
            {
                min = massive[i];
                minIndex = i;
            }
        }
        Console.WriteLine($"ən böyük : {max}");
        Console.WriteLine($"ən böyük reqemin indexi :{maxIndex}");
        Console.WriteLine($"ən kiçik : {min}");
        Console.WriteLine($"ən kiçik reqemin indexi :{minIndex}");
    }
    static void Task24()
    //Yaratmış olduğunuz integer massivdə olan cüt ədədləri çap edən proqramı yazın.
    {
        int[] massive = { 5, 9, 6, 1, 7, 8, 4, 2, 3 };
        for (int i = 0; i < massive.Length; i++)
        {
            if (massive[i] % 2 == 0)
            {
                Console.WriteLine(massive[i]);
            }
        }
    }
    static void Task25()
    //Yaratmış olduğunuz massivdəki elementləri əks sıralama ilə yeni massivə əlavə edib nəticəni çap edən proqramı yazın.
    {
        int[] massive = { 5, 9, 2, 7, 11 };
        int[] massive2 = new int[massive.Length];
        for (var i = 0; i < massive.Length; i++)
        {
            massive2[i] = massive[massive.Length - 1 - i];
        }

        foreach (var item in massive2)
        {
            Console.WriteLine(item);
        }
    }

    static void Task26()
    //Massivdə konkret ədədin olub-olmadığını yoxlayan və indexini çap edən proqramı yazın.(yoxdursa -1)
    {
        int[] massive = { 5, 9, 2, 7, 11 };
        Console.WriteLine("Axtarılacaq ədədi daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        int index = -1;
        for (int i = 0; i < massive.Length; i++)
        {
            if (massive[i] == number)
            {
                index = i;
                break;
            }
        }
        Console.WriteLine(index);

    }
    static void Task27()
    //Massivdə təkrarlanan elementləri tapıb, nəticəni çap edən proqramı yazın.(bütün təkrarlanan ədədlər)
    {






    }
    static void Task28()
    //Massivdəki ikinci ən böyük elementi tapan və nəticəni çap edən proqramı yazın.
    {
        int[] massive = { 5, 9, 2, 7, 11, 8, 4, 2, 3 };
        int max = massive[0];
        int secondMax = massive[0];
        for (int i = 0; i < massive.Length; i++)
        {
            if (massive[i] > max)
            {
                secondMax = max;
                max = massive[i];
            }
            else if (massive[i] > secondMax && massive[i] != max)
            {
                secondMax = massive[i];
            }
        }
        Console.WriteLine(secondMax);

    }
    static void Task29()
    //Verilmiş N rəqəmli ədədin rəqəmləri cəmini tapan və nəticəni çap edən proqramı yazın.
    {
        Console.WriteLine("N rəqəmli ədəd daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine(sum);

    }
    static void Task30()
    //Verilmiş N rəqəmli ədədin rəqəmlərinin sayını tapan və nəticəni çap edən proqramı yazın.
    {
        Console.WriteLine("N rəqəmli ədəd daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        Console.WriteLine(count);
    }
    static void Task31()
    //Verilmiş N rəqəmli ədədin sadə və ya mürəkkəb olduğunu tapan və nəticəni çap edən proqramı yazın.
    {
        Console.WriteLine("N rəqəmli ədəd daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            Console.WriteLine("Sadə ədəddir");
        }
        else
        {
            Console.WriteLine("Mürəkkəb ədəddir");
        }
    }
    static bool IsStringIspolindrome(string str)
    //Verilmiş N rəqəmli ədədin Palindrome olub-olmamasını yoxlayan və nəticəni çap edən proqramı yazın.
    {
       
        for (var i = 0; i < str.Length / 2 ; ++ i){
            if (str[i] != str[str.Length - 1 - i])
                return false;
        }
        return true;

    }


    static void Task32()
    {
        Console.WriteLine($"Reqemi daxil edin");
        int a =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsStringIspolindrome(a.ToString()));

    }

    static void Task33()
    //Fibonaçi ədədlərindən ilk N həddini tapan və çap edən proqramı yazın.
    {
      
    }
}























