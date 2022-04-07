using System;

namespace Arac_Kiralama_1._1_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            string arac_secimi;
            Console.Write("1-Volkswagen\n2-Hyundai\n3-Renault\n4-Toyota\nQ-Çıkış\n\tSeçim: ");
            arac_secimi = Console.ReadLine();
            while (true)
            {
                if (arac_secimi == "Q" || arac_secimi == "q")
                {
                    Console.WriteLine("Yine bekleriz.");
                    break;
                }
                else if (arac_secimi == "1")
                {
                    string model_secimi;
                    Console.Write("VOLKSWAGEN ARAÇ MODELLERİMİZ\n\n1-Passat\n2-Arteon\n3-Transporter\n4-Amarok\nQ-Çıkış\n\tSeçim: ");
                    model_secimi = Console.ReadLine();

                    while (true)
                    {
                        if (model_secimi == "Q" || model_secimi == "q")
                        {
                            arac_secimi = "q";
                            break;
                        }
                        else if (model_secimi == "1")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 5;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }                                
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 40;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 120;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "2")
                        {                            
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 7;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 45;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 130;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }                            
                        }
                        else if (model_secimi == "3")
                        {                                                        
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 6;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 42;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 125;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }                            
                        }
                        else if (model_secimi == "4")
                        {    
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 8;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }                                
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 50;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 135;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        
                        }
                        else
                        {
                            Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                            Console.Write("VOLKSWAGEN ARAÇ MODELLERİMİZ\n\n1-Passat\n2-Arteon\n3-Transporter\n4-Amarok\nQ-Çıkış\n\tSeçim: ");
                            model_secimi = Console.ReadLine();
                        }
                    }
                }
                else if (arac_secimi == "2")
                {
                    string model_secimi;
                    Console.Write("HYUNDAI ARAÇ MODELLERİMİZ\n\n1-Accent\n2-i20\n3-Tucson\n4-ix35\nQ-Çıkış\n\tSeçim: ");
                    model_secimi = Console.ReadLine();

                    while (true)
                    {
                        if (model_secimi == "Q" || model_secimi == "q")
                        {
                            arac_secimi = "q";
                            break;
                        }
                        else if (model_secimi == "1")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 5;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 40;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 120;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "2")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 7;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 45;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 130;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "3")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 6;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 42;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 125;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "4")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 8;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 50;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 135;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                            Console.Write("VOLKSWAGEN ARAÇ MODELLERİMİZ\n\n1-Passat\n2-Arteon\n3-Transporter\n4-Amarok\nQ-Çıkış\n\tSeçim: ");
                            model_secimi = Console.ReadLine();
                        }
                    }
                }
                else if (arac_secimi == "3")
                {
                    string model_secimi;
                    Console.Write("RENAULT ARAÇ MODELLERİMİZ\n\n1-Clio\n2-Symbol\n3-Megane\n4-Talisman\nQ-Çıkış\n\tSeçim: ");
                    model_secimi = Console.ReadLine();

                    while (true)
                    {
                        if (model_secimi == "Q" || model_secimi == "q")
                        {
                            arac_secimi = "q";
                            break;
                        }
                        else if (model_secimi == "1")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 5;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 40;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 120;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "2")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 7;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 45;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 130;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "3")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 6;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 42;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 125;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "4")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 8;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 50;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 135;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                            Console.Write("VOLKSWAGEN ARAÇ MODELLERİMİZ\n\n1-Passat\n2-Arteon\n3-Transporter\n4-Amarok\nQ-Çıkış\n\tSeçim: ");
                            model_secimi = Console.ReadLine();
                        }
                    }
                }
                else if (arac_secimi == "4")
                {
                    string model_secimi;
                    Console.Write("TOYOTA ARAÇ MODELLERİMİZ\n\n1-Corolla\n2-Yaris\n3-Supra\n4-Hybrit\nQ-Çıkış\n\tSeçim: ");
                    model_secimi = Console.ReadLine();

                    while (true)
                    {
                        if (model_secimi == "Q" || model_secimi == "q")
                        {
                            arac_secimi = "q";
                            break;
                        }
                        else if (model_secimi == "1")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 5;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 40;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 120;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "2")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 7;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 45;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 130;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "3")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 6;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 42;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 125;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }
                        }
                        else if (model_secimi == "4")
                        {
                            string zaman_dilimi;
                            Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                            zaman_dilimi = Console.ReadLine();

                            while (true)
                            {
                                if (zaman_dilimi == "Q" || zaman_dilimi == "q")
                                {
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "1")
                                {
                                    int hesap = 1;
                                    int saat_gir;
                                    Console.Write("Kaç saat: ");
                                    saat_gir = Convert.ToInt32(Console.ReadLine());

                                    if (saat_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (saat_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }
                                    else
                                    {
                                        hesap = hesap * saat_gir;
                                        hesap = hesap * 8;
                                        Console.WriteLine("Toplam tutar = " + hesap);
                                        model_secimi = "q";
                                        break;
                                    }
                                }
                                else if (zaman_dilimi == "2")
                                {
                                    int hesap = 1;
                                    int gun_gir;
                                    Console.Write("Kaç gün: ");
                                    gun_gir = Convert.ToInt32(Console.ReadLine());

                                    if (gun_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (gun_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * gun_gir;
                                    hesap = hesap * 50;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else if (zaman_dilimi == "3")
                                {
                                    int hesap = 1;
                                    int hafta_gir;
                                    Console.Write("Kaç hafta: ");
                                    hafta_gir = Convert.ToInt32(Console.ReadLine());

                                    if (hafta_gir == 0)
                                    {
                                        zaman_dilimi = "q";
                                        break;
                                    }
                                    else if (hafta_gir <= -1)
                                    {
                                        Console.WriteLine("Saat dilimi negatif bir değer içermez\nTekrar giriş yapınız\n\n");
                                        continue;
                                    }

                                    hesap = hesap * hafta_gir;
                                    hesap = hesap * 135;
                                    Console.WriteLine("Toplam tutar = " + hesap);
                                    model_secimi = "q";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                                    Console.Write("1-Saatlik\n2-Günlük\n3-Haftalık\nQ-Çıkış\n\tSeçim: ");
                                    zaman_dilimi = Console.ReadLine();
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                            Console.Write("VOLKSWAGEN ARAÇ MODELLERİMİZ\n\n1-Passat\n2-Arteon\n3-Transporter\n4-Amarok\nQ-Çıkış\n\tSeçim: ");
                            model_secimi = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı kodlama tekrar deneyiniz.\n");
                    Console.Write("1-Volkswagen\n2-Hyundai\n3-Renault\n4-Toyota\nQ-Çıkış\n\tSeçim: ");
                    arac_secimi = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}