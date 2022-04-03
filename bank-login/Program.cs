string banKNum = "1234567890";
string banKPass = "0123";
//bool he = true;
//bool yox = false;
//int bankNum = Convert.ToInt32(banKNum);
//int bankPass = Convert.ToInt32(banKPass);
Console.WriteLine("Kart nomresini daxil edin");
string num = Console.ReadLine();
Console.WriteLine("sifreni daxil edin");
string pass = Console.ReadLine();


if (num == banKNum && pass == banKPass)
{
    Console.WriteLine("daxil oldunuz");
    Console.WriteLine("Hesabiniz: 500man");
    Console.WriteLine("cixaris etmek isteyirsiniz?");
    Console.WriteLine("he/yox");
    string answer = Console.ReadLine();
    if (answer == "he")
    {
        Console.WriteLine("Cixarisin meblegi:");
        string price = Console.ReadLine(); ;
        int prices = Convert.ToInt32(price);

        int accaount = 500;
        if (prices <= accaount)
        {
            Console.WriteLine("cixaris ugurla tamamlandi");
            int result = accaount - prices;
            Console.WriteLine("Hesabda olan mebleg:" + result + "man");
        }
        else
        {
            Console.WriteLine("cixaris mumkun deyil");
        }
    }
    else if (answer == "yox")
    {
        Console.WriteLine("cixaris olmadi, tesekkurler");

    }


}
else if (num == "" && pass == "")
{
    Console.WriteLine("melumatlari daxil edin");
}

else
{
    Console.WriteLine("daxil ola bilmediniz");
    if (num != banKNum)
    {
        Console.WriteLine("bank nomresini duzgun daxil edin");
    }
    else if (pass != banKPass)
    {
        Console.WriteLine("sifreni duzgun daxil edin");
    }
}
